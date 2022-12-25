using System;

namespace CharitableService.Models
{
    public partial class tblBoxReportModel
    {
        public Nullable<int> fk_BoxID { get; set; }
        public string fld_Date { get; set; }
        public Nullable<int> fk_Agent1 { get; set; }
        public Nullable<int> fk_Agent2 { get; set; }
        public Nullable<short> fk_StatusID { get; set; }
        public Nullable<short> fk_LevelID { get; set; }
        public Nullable<System.DateTime> fld_AddDate { get; set; }
        public string fld_Adder { get; set; }
        public Nullable<int> fk_MissionID { get; set; }
        public string fld_Descr { get; set; }
    }
}