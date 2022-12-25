

using System.Collections.Generic;

namespace CharitableService.Models
{
    public partial class SendMissionModel
    {
        public List<tblBoxModel> TblBoXModels { get; set; }
        public List<tblBoxReportModel> TblBoxReportModels { get; set; }
        public List<tblBoxDischargeItemModel> TblBoxDischargeItemModels { get; set; }
    }
}