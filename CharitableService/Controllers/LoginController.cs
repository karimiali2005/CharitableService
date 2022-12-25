using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web.Http;
using CharitableService.Models;

namespace CharitableService.Controllers
{
    public class LoginController : ApiController
    {
        // GET: api/Login
        public LoginViewModel Get(string username, string pass,string serialNumber)
        {
            var db = new CharitableContext();
            var query = (from user in db.tblUsers
                join  customer in db.tblCustomers on user.fk_PersonnelID equals  customer.PKID
                where user.fld_UserName == username && user.fld_Password == pass &&(string.IsNullOrEmpty(user.fld_AppSerialNumber)||user.fld_AppSerialNumber==serialNumber)
                select customer).FirstOrDefault();
            var message = (from m in db.tblDayMessages
                select m).FirstOrDefault();
            if (query != null)
            {
                return new LoginViewModel()
                {
                    fld_UserName = username,
                    FirstName = query.fld_Name,
                    LastName = query.fld_Family,
                    UserID = query.PKID,
                    fld_Version = message.fld_Version
                };
            }
            else
            {
                return null;
            }

        }

        public MissionMessageViewModel Get(int id)
        {
            var db = new CharitableContext();
            PersianCalendar persianCalendar = new PersianCalendar();
            var missionDate = persianCalendar.GetYear(DateTime.Now).ToString("0000") + "/" +
                                         persianCalendar.GetMonth(DateTime.Now).ToString("00") + "/" +
                                         persianCalendar.GetDayOfMonth(DateTime.Now).ToString("00");
         //   missionDate = "1390/01/19";

            var agents = (from boxoxDischarge in db.tblBoxDischargeHeaders
                join customer1 in db.tblCustomers on boxoxDischarge.fk_Agent1ID equals customer1.PKID
                join customer2 in db.tblCustomers on boxoxDischarge.fk_Agent2ID equals customer2.PKID 
                where (boxoxDischarge.fk_Agent2ID == id ) &&
                      (boxoxDischarge.fld_DischargeDate == missionDate)
                select new
                {
                    fk_Agent1ID=customer1.PKID,
                    fld_Name1=customer1.fld_Name,
                    fld_Family1=customer1.fld_Family,
                    fld_Code1=customer1.fld_Code,
                    fk_Agent2ID = customer2.PKID,
                    fld_Name2 = customer2.fld_Name,
                    fld_Family2 = customer2.fld_Family,
                    fld_Code2 = customer2.fld_Code,
                }).FirstOrDefault();

            var message = (from m in db.tblDayMessages
                select m).FirstOrDefault();

            var missionMessageViewModel = new MissionMessageViewModel()
            {
                fk_Agent1ID = agents.fk_Agent2ID,
                fld_Name1 = agents.fld_Name2,
                fld_Family1 = agents.fld_Family2,
                fld_Code1 = agents.fld_Code2,
                fk_Agent2ID = agents.fk_Agent1ID,
                fld_Name2 = agents.fld_Name1,
                fld_Family2 = agents.fld_Family1,
                fld_Code2 = agents.fld_Code1,
                fld_Message = message.fld_Message,
            };
            return missionMessageViewModel;
        }


    }
}
