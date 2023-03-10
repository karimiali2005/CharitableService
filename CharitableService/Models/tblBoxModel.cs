using System;

namespace CharitableService.Models
{
    public partial class tblBoxModel
    {
        public int PKID { get; set; }
        public Nullable<short> fk_Type { get; set; }
        public string fld_Code { get; set; }
        public string fld_AssignDate { get; set; }
        public string fld_Transferee { get; set; }
        public Nullable<short> fk_LocationType { get; set; }
        public Nullable<short> fk_CityID { get; set; }
        public Nullable<short> fk_AreaID { get; set; }
        public Nullable<short> fld_Location { get; set; }
        public Nullable<int> fld_Order { get; set; }
        public Nullable<short> fld_DischargePeriod { get; set; }
        public string fld_MainStreet { get; set; }
        public string fld_ByStreet { get; set; }
        public string fld_Alley { get; set; }
        public string fld_Impasse { get; set; }
        public string fld_No { get; set; }
        public string fld_Floor { get; set; }
        public string fld_UnitNo { get; set; }
        public string fld_job { get; set; }
        public string fld_POBOX { get; set; }
        public string fld_HomeTel { get; set; }
        public string fld_WorkTel { get; set; }
        public string fld_Mobile { get; set; }
        public Nullable<short> fk_LastStatus { get; set; }
        public Nullable<short> fk_LevelID { get; set; }
        public string fld_ReleaseDate { get; set; }
        public Nullable<int> fk_Agent1ID { get; set; }
        public Nullable<int> fk_Agent2ID { get; set; }
        public Nullable<short> fk_AssignType { get; set; }
        public string fld_Descr { get; set; }
        public Nullable<byte> fld_EmptyPerod { get; set; }
        public Nullable<byte> fk_RowStatus { get; set; }
        public string fld_Adder { get; set; }
        public Nullable<System.DateTime> fld_AddDate { get; set; }
        public string fld_Editor { get; set; }
        public Nullable<System.DateTime> fld_EditDate { get; set; }
        public string fld_AddressNote { get; set; }
        public string fld_street3 { get; set; }
        public string fld_alley3 { get; set; }
        public Double fld_latitude { get; set; }
        public Double fld_longitude { get; set; }
        public int fk_HeaderID { get; set; }
    }
}