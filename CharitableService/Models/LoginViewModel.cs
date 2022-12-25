using System;

namespace CharitableService.Models
{
    public class LoginViewModel
    {
        public string fld_UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UserID { get; set; }
        public Nullable<int> fld_Version { get; set; }
    }
}