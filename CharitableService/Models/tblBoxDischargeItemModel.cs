using System;

namespace CharitableService.Models
{
    public partial class tblBoxDischargeItemModel
    {
        public Nullable<int> fk_HeaderID { get; set; }
        public Nullable<short> fk_AreaID { get; set; }
        public Nullable<short> fld_Location { get; set; }
        public string fld_FishNo { get; set; }
        public Nullable<int> fk_BoxID { get; set; }
        public string fld_DischargeTime { get; set; }
        public Nullable<long> fld_PiecePrice { get; set; }
        public Nullable<long> fld_PaperPrice { get; set; }
        public Nullable<byte> fk_SarFasl { get; set; }
        public string fld_Address { get; set; }
        public string fld_Transferee { get; set; }
        public string fld_Adder { get; set; }
        public Nullable<System.DateTime> fld_AddDate { get; set; }
        public Double fld_latitude { get; set; }
        public Double fld_longitude { get; set; }
        public string fld_description { get; set; }
    }
}