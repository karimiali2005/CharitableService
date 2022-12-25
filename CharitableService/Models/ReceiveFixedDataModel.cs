using System.Collections.Generic;

namespace CharitableService.Models
{
    public partial class ReceiveFixedDataModel
    {
        public List<tblAreaModel> TblAreaModels { get; set; }
        public List<tblBoxLevelModel> TblBoxLevelModels { get; set; }
        public List<tblBoxStatusModel> TblBoxStatusModels { get; set; }
        public List<tblLocationTypeModel> TblLocationTypeModels { get; set; }
        public List<tblSarFaslModel> TblSarFaslModels { get; set; }
    }
}