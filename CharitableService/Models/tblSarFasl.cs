using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharitableService.Models
{
    [Table("tblSarFasl")]
    public partial class tblSarFasl
    {
        [Key]
        public byte PKID { get; set; }
        public string fld_SarFasl { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}