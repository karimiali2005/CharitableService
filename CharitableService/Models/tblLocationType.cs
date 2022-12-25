using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharitableService.Models
{
    [Table("tblLocationType")]
    public partial class tblLocationType
    {
        [Key]
        public short PKID { get; set; }
        public string fld_LocationType { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}