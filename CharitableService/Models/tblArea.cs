using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharitableService.Models
{
    [Table("tblArea")]
    public partial class tblArea
    {
        [Key]
        public short PKID { get; set; }
        public Nullable<short> fld_AreaCode { get; set; }
        public string fld_AreaTitle { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}