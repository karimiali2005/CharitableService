using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharitableService.Models
{
    [Table("tblBoxDischargeItem")]
    public partial class tblBoxDischargeItem
    {
        [Key]
        public int PKID { get; set; }
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
        public string fld_Editor { get; set; }
        public string fld_EditDate_ { get; set; }
        public string fld_DeleteDate_ { get; set; }
        public Nullable<byte> fk_RowStatus { get; set; }
        public string fld_Deleter { get; set; }
        public Nullable<System.DateTime> fld_EditDate { get; set; }
        public Nullable<System.DateTime> fld_DeleteDate { get; set; }

    }
}