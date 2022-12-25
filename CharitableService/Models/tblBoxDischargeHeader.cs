using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharitableService.Models
{
    [Table("tblBoxDischargeHeader")]
    public partial class tblBoxDischargeHeader
    {
        [Key]
        public int PKID { get; set; }
        public string fld_DischargeNo { get; set; }
        public string fld_DischargeDate { get; set; }
        public Nullable<short> fk_AreaID { get; set; }
        public Nullable<int> fk_Shift { get; set; }
        public Nullable<short> fld_Location { get; set; }
        public Nullable<short> fld_Duration { get; set; }
        public Nullable<long> fld_PiecePrice { get; set; }
        public Nullable<long> fld_PiecePriceOK { get; set; }
        public Nullable<long> fld_PaperPrice { get; set; }
        public Nullable<long> fld_PaperPriceOK { get; set; }
        public Nullable<int> fk_Agent1ID { get; set; }
        public Nullable<int> fk_Agent2ID { get; set; }
        public Nullable<byte> WhoDriver { get; set; }
        public string fld_Descr { get; set; }
        public Nullable<short> CountOfBox { get; set; }
        public string fld_Adder { get; set; }
        public Nullable<System.DateTime> fld_AddDate { get; set; }
        public string fld_Editor { get; set; }
        public string fld_EditDate_ { get; set; }
        public string fld_DeleteDate_ { get; set; }
        public Nullable<byte> fk_RowStatus { get; set; }
        public Nullable<int> agent1Temp { get; set; }
        public string fld_Deleter { get; set; }
        public Nullable<short> fld_TotalBox { get; set; }
        public Nullable<System.DateTime> fld_EditDate { get; set; }
        public Nullable<System.DateTime> fld_DeleteDate { get; set; }

      
    }
}