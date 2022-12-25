using System;

namespace CharitableService.Models
{
    public partial class MissionMessageViewModel
    {
        public Nullable<int> fk_Agent1ID { get; set; }
        public string fld_Name1 { get; set; }
        public string fld_Family1 { get; set; }
        public int fld_Code1 { get; set; }
        public Nullable<int> fk_Agent2ID { get; set; }
        public string fld_Name2 { get; set; }
        public string fld_Family2 { get; set; }
        public int fld_Code2 { get; set; }
        public string fld_Message { get; set; }

    }
}