using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharitableService.Models
{
    [Table("tblCustomers")]
    public partial class tblCustomer
    {
        [Key]
        public int PKID { get; set; }
        public int fld_Code { get; set; }
        public string fld_EmployeeCode { get; set; }
        public Nullable<short> fk_Type { get; set; }
        public string fld_Family { get; set; }
        public string fld_Name { get; set; }
        public Nullable<bool> fk_Sex { get; set; }
        public Nullable<float> fld_Credit { get; set; }
        public string fld_HomeTel { get; set; }
        public string fld_WorkTel { get; set; }
        public string fld_Fax { get; set; }
        public string fld_Mobile { get; set; }
        public string fld_Address { get; set; }
        public string fld_FatherName { get; set; }
        public string fld_SHSH { get; set; }
        public string fld_BirthLocation { get; set; }
        public string fld_BirthDay { get; set; }
        public string fld_BimehNo { get; set; }
        public Nullable<short> fld_Rotbe { get; set; }
        public Nullable<short> fld_Jaygah { get; set; }
        public string fld_MelliCode { get; set; }
        public string fld_PoBOX { get; set; }
        public string fld_ExternalEmail { get; set; }
        public Nullable<byte> fk_MilitaryService { get; set; }
        public Nullable<bool> fld_IsMarrage { get; set; }
        public string fld_MarrageDate { get; set; }
        public string fld_InputDate { get; set; }
        public Nullable<short> fld_WorkDelay { get; set; }
        public string fld_WorkFinishedDate { get; set; }
        public Nullable<short> fk_LastDegree { get; set; }
        public string fld_GetDegreeDate { get; set; }
        public string fld_DegreeCity { get; set; }
        public Nullable<short> fk_CourseID { get; set; }
        public Nullable<short> fk_SubCourseID { get; set; }
        public string fld_Din { get; set; }
        public string fld_Mazhab { get; set; }
        public Nullable<short> fk_BloodGroupID { get; set; }
        public string fld_IncomTel { get; set; }
        public string fld_PersonalPic_FileName { get; set; }
        public byte[] fld_PersonalPic { get; set; }
        public string fld_DomainUserName { get; set; }
        public string fld_Password { get; set; }
        public Nullable<System.DateTime> fld_Lastlogin { get; set; }
        public Nullable<int> fk_AccessoryID { get; set; }
        public Nullable<int> fk_GroupID { get; set; }
        public Nullable<short> fk_MemberShipID { get; set; }
        public Nullable<byte> fk_SematID { get; set; }
        public string fld_BankAccount { get; set; }
        public string fld_JobWork { get; set; }
        public string fld_JobOrganization { get; set; }
        public Nullable<short> fld_MaxPersentTime { get; set; }
        public Nullable<float> fld_MaxExtraTime { get; set; }
        public Nullable<float> fld_Maxleavecredit { get; set; }
        public Nullable<short> fld_MaxHourLeave { get; set; }
        public Nullable<bool> IsEmployee { get; set; }
        public Nullable<bool> IsAgent { get; set; }
        public string fld_Email { get; set; }
        public string fld_URL { get; set; }
        public string fld_Title { get; set; }
        public Nullable<byte> fk_RowStatus { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> fld_AddDate { get; set; }
        public string fld_Adder { get; set; }
        public Nullable<System.DateTime> fld_EditDate { get; set; }
        public string fld_Editor { get; set; }
        public string fld_Course { get; set; }
        public string fld_SubCourse { get; set; }
        public string fld_Deleter { get; set; }
        public Nullable<System.DateTime> fld_DelDate { get; set; }

        
    }
}