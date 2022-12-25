using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharitableService.Models
{
    [Table("tblBoxStatus")]
    public partial class tblBoxStatus
    {
        [Key]
        public short PKID { get; set; }
        public string fld_BoxStatus { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> fld_ShowStatus { get; set; }
    }
}