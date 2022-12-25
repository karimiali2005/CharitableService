using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AntelopeSurvey.UI.Classes;
using CharitableService.Classes;
using CharitableService.Models;

namespace CharitableService.Controllers
{
    public class SendDataController : ApiController
    {
        public HttpResponseMessage Put(SendMissionModel sendMission)
        {
            try
            {
                foreach (var sendMissionTblBoXModel in sendMission.TblBoXModels)
                {
                    sendMissionTblBoXModel.fld_Code = sendMissionTblBoXModel.fld_Code.ToLatinNumber();
                    sendMissionTblBoXModel.fld_AssignDate = sendMissionTblBoXModel.fld_AssignDate.ToLatinNumber();
                    sendMissionTblBoXModel.fld_Transferee = sendMissionTblBoXModel.fld_Transferee.ToLatinNumber();
                    sendMissionTblBoXModel.fld_MainStreet = sendMissionTblBoXModel.fld_MainStreet.ToLatinNumber();
                    sendMissionTblBoXModel.fld_ByStreet = sendMissionTblBoXModel.fld_ByStreet.ToLatinNumber();
                    sendMissionTblBoXModel.fld_Alley = sendMissionTblBoXModel.fld_Alley.ToLatinNumber();
                    sendMissionTblBoXModel.fld_Impasse = sendMissionTblBoXModel.fld_Impasse.ToLatinNumber();
                    sendMissionTblBoXModel.fld_No = sendMissionTblBoXModel.fld_No.ToLatinNumber();
                    sendMissionTblBoXModel.fld_Floor = sendMissionTblBoXModel.fld_Floor.ToLatinNumber();
                    sendMissionTblBoXModel.fld_UnitNo = sendMissionTblBoXModel.fld_UnitNo.ToLatinNumber();
                    sendMissionTblBoXModel.fld_job = sendMissionTblBoXModel.fld_job.ToLatinNumber();
                    sendMissionTblBoXModel.fld_POBOX = sendMissionTblBoXModel.fld_POBOX.ToLatinNumber();
                    sendMissionTblBoXModel.fld_HomeTel = sendMissionTblBoXModel.fld_HomeTel.ToLatinNumber();
                    sendMissionTblBoXModel.fld_WorkTel = sendMissionTblBoXModel.fld_WorkTel.ToLatinNumber();
                    sendMissionTblBoXModel.fld_Mobile = sendMissionTblBoXModel.fld_Mobile.ToLatinNumber();
                    sendMissionTblBoXModel.fld_ReleaseDate = sendMissionTblBoXModel.fld_ReleaseDate.ToLatinNumber();
                    sendMissionTblBoXModel.fld_Descr = sendMissionTblBoXModel.fld_Descr.ToLatinNumber();
                    sendMissionTblBoXModel.fld_Adder = sendMissionTblBoXModel.fld_Adder.ToLatinNumber();
                    sendMissionTblBoXModel.fld_Editor = sendMissionTblBoXModel.fld_Editor.ToLatinNumber();
                    sendMissionTblBoXModel.fld_AddressNote = sendMissionTblBoXModel.fld_AddressNote.ToLatinNumber();
                    sendMissionTblBoXModel.fld_street3 = sendMissionTblBoXModel.fld_street3.ToLatinNumber();
                    sendMissionTblBoXModel.fld_alley3 = sendMissionTblBoXModel.fld_alley3.ToLatinNumber();


                }

                foreach (var sendMissionTblBoxDischargeItemModel in sendMission.TblBoxDischargeItemModels)
                {
                    sendMissionTblBoxDischargeItemModel.fld_FishNo =sendMissionTblBoxDischargeItemModel.fld_FishNo.ToLatinNumber();
                    sendMissionTblBoxDischargeItemModel.fld_DischargeTime = sendMissionTblBoxDischargeItemModel.fld_DischargeTime.ToLatinNumber();
                    sendMissionTblBoxDischargeItemModel.fld_Address = sendMissionTblBoxDischargeItemModel.fld_Address.ToLatinNumber();
                    sendMissionTblBoxDischargeItemModel.fld_Transferee = sendMissionTblBoxDischargeItemModel.fld_Transferee.ToLatinNumber();
                    sendMissionTblBoxDischargeItemModel.fld_Adder = sendMissionTblBoxDischargeItemModel.fld_Adder.ToLatinNumber();
                    sendMissionTblBoxDischargeItemModel.fld_description = sendMissionTblBoxDischargeItemModel.fld_description.ToLatinNumber();
                }

                foreach (var sendMissionTblBoxReportModel in sendMission.TblBoxReportModels)
                {
                    sendMissionTblBoxReportModel.fld_Date = sendMissionTblBoxReportModel.fld_Date.ToLatinNumber();
                    sendMissionTblBoxReportModel.fld_Adder = sendMissionTblBoxReportModel.fld_Adder.ToLatinNumber();
                    sendMissionTblBoxReportModel.fld_Descr = sendMissionTblBoxReportModel.fld_Descr.ToLatinNumber();
                }

                var db = new CharitableContext();
                var tblBoxModelListParameter = new SqlParameter("@tblBoxModelList", SqlDbType.Structured);
                if (tblBoxModelListParameter != null)
                    tblBoxModelListParameter.Value = ExportDataTable.ToDataTable(sendMission.TblBoXModels);
                tblBoxModelListParameter.TypeName = "dbo.tblBoxModelType";

                var tblBoxReportModelListParameter = new SqlParameter("@tblBoxReportModelList", SqlDbType.Structured);
                if (tblBoxReportModelListParameter != null)
                    tblBoxReportModelListParameter.Value = ExportDataTable.ToDataTable(sendMission.TblBoxReportModels);
                tblBoxReportModelListParameter.TypeName = "dbo.tblBoxReportModelType";

                var tblBoxDischargeItemModelListParameter =
                    new SqlParameter("@tblBoxDischargeItemModelList", SqlDbType.Structured);
                if (tblBoxDischargeItemModelListParameter != null)
                    tblBoxDischargeItemModelListParameter.Value =
                        ExportDataTable.ToDataTable(sendMission.TblBoxDischargeItemModels);
                tblBoxDischargeItemModelListParameter.TypeName = "dbo.tblBoxDischargeItemModelType";

                

                db.Database.ExecuteSqlCommand(
                    "exec SendMission @tblBoxModelList,@tblBoxReportModelList,@tblBoxDischargeItemModelList",
                    tblBoxModelListParameter, tblBoxReportModelListParameter, tblBoxDischargeItemModelListParameter);

                var maxMission = (from d in sendMission.TblBoxDischargeItemModels
                        select d.fld_AddDate)
                    .Union(from r in sendMission.TblBoxReportModels
                        select r.fld_AddDate).Max();

                

                var minMission = (from d in sendMission.TblBoxDischargeItemModels
                        select d.fld_AddDate)
                    .Union(from r in sendMission.TblBoxReportModels
                        select r.fld_AddDate).Min();



                if (maxMission != null && minMission != null)
                {
                    var distinct = (from d in sendMission.TblBoxDischargeItemModels
                        select d.fk_HeaderID).Distinct();
                    TimeSpan span = maxMission.Value.Subtract(minMission.Value);
                    foreach (var i in distinct)
                    {
                        var query = db.tblBoxDischargeHeaders.Find(i);
                        
                        var minutes = (span.Days*24*60)+(span.Hours*60)+span.Minutes;
                        query.fld_Duration =(short)minutes;
                        db.SaveChanges();
                    }
                    
                               
                }

                var response = new HttpResponseMessage { StatusCode = HttpStatusCode.OK };
                return response;

            }
            catch (Exception exception)
            {
                var response = new HttpResponseMessage { StatusCode = HttpStatusCode.BadGateway,Content = new StringContent(exception.Message+(exception.Source??""))};
                return response;
            }
        }
    }
}
