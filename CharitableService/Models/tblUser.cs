using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharitableService.Models
{
    [Table("tblUsers")]
    public partial class tblUser
    {
        [Key]
        public int PKID { get; set; }
        public int fk_PersonnelID { get; set; }
        public string fld_UserName { get; set; }
        public string fld_Password { get; set; }
        public string fld_LastLogin { get; set; }
        public string fld_AppSerialNumber { get; set; }
    }
}