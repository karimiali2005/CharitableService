using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharitableService.Models
{
    [Table("tblBoxLevel")]
    public partial class tblBoxLevel
    {
        [Key]
        public short PKID { get; set; }
        public string fld_BoxLevel { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}