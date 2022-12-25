using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharitableService.Models
{
    [Table("tblDayMessage")]
    public partial class tblDayMessage
    {
        [Key]
        public int PKID { get; set; }
        public string fld_Message { get; set; }
        public Nullable<int> fld_Version { get; set; }
    }
}