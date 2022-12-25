using System.Data.Entity;

namespace CharitableService.Models
{
    public partial class CharitableContext : DbContext
    {
        public CharitableContext() : base("name=CharitableContext")
        {
        }

        public virtual DbSet<tblArea> tblAreas { get; set; }
        public virtual DbSet<tblBoxLevel> tblBoxLevels { get; set; }
        public virtual DbSet<tblBoxStatus> tblBoxStatus { get; set; }
        public virtual DbSet<tblLocationType> tblLocationTypes { get; set; }
        public virtual DbSet<tblSarFasl> tblSarFasls { get; set; }
        public virtual DbSet<tblCustomer> tblCustomers { get; set; }
        public virtual DbSet<tblBoxDischargeHeader> tblBoxDischargeHeaders { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
        public virtual DbSet<tblDayMessage> tblDayMessages { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

    }
}