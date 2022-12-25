using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web.Http;
using AntelopeSurvey.UI.Classes;
using CharitableService.Models;

namespace CharitableService.Controllers
{
    public class ReciveDataController : ApiController
    {
        // GET: api/ReciveData
        public List<ReceiveMissionModel> Get(int id)
        {

            try
            {


                var db = new CharitableContext();
                var CustomerIDParameter = new SqlParameter("@CustomerID", SqlDbType.VarChar);
                CustomerIDParameter.Value = id;


                PersianCalendar persianCalendar = new PersianCalendar();
                var MissionDateParameter = new SqlParameter("@MissionDate", SqlDbType.VarChar);
                MissionDateParameter.Value = persianCalendar.GetYear(DateTime.Now).ToString("0000") + "/" +
                                             persianCalendar.GetMonth(DateTime.Now).ToString("00") + "/" +
                                             persianCalendar.GetDayOfMonth(DateTime.Now).ToString("00");
                // MissionDateParameter.Value = "1390/01/19";


                var MissionDateMiladiParameter = new SqlParameter("@MissionDateMiladi", SqlDbType.DateTime);
                MissionDateMiladiParameter.Value = DateTime.Now.ChangeTime(23, 59, 59, 0);
                // MissionDateMiladiParameter.Value = "4/14/2012 11:59:59 PM";

                var result = db.Database
                    .SqlQuery<ReceiveMissionModel>("ReceiveMission @CustomerID,@MissionDate,@MissionDateMiladi",
                        CustomerIDParameter, MissionDateParameter, MissionDateMiladiParameter).ToList();

                return result;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public ReceiveFixedDataModel Get()
        {
            var db = new CharitableContext();
            var receiveFixed = new ReceiveFixedDataModel()
            {
                TblAreaModels = (from area in db.tblAreas
                    where area.IsActive == true
                    select new tblAreaModel()
                    {
                        PKID = area.PKID,
                        fld_AreaCode = area.fld_AreaCode,
                        fld_AreaTitle = area.fld_AreaTitle
                    }).ToList(),
                TblBoxLevelModels = (from boxLevel in db.tblBoxLevels
                    where boxLevel.IsActive == true
                    select new tblBoxLevelModel()
                    {
                        PKID = boxLevel.PKID,
                        fld_BoxLevel = boxLevel.fld_BoxLevel
                    }).ToList(),
                TblBoxStatusModels = (from boxStatus in db.tblBoxStatus
                    where boxStatus.IsActive == true && boxStatus.fld_ShowStatus == true
                    select new tblBoxStatusModel()
                    {
                        PKID = boxStatus.PKID,
                        fld_BoxStatus = boxStatus.fld_BoxStatus
                    }).ToList(),
                TblLocationTypeModels = (from locationType in db.tblLocationTypes
                    where locationType.IsActive == true
                    select new tblLocationTypeModel()
                    {
                        PKID = locationType.PKID,
                        fld_LocationType = locationType.fld_LocationType
                    }).ToList(),
                TblSarFaslModels = (from sarFasl in db.tblSarFasls
                    where sarFasl.IsActive == true
                    select new tblSarFaslModel()
                    {
                        PKID = sarFasl.PKID,
                        fld_SarFasl = sarFasl.fld_SarFasl
                    }).ToList()
            };
            return receiveFixed;
        }

        


    }
}
