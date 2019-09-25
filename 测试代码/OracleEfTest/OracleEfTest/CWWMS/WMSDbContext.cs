namespace OracleEfTest.CWWMS
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WmsDbContext : DbContext
    {
        public WmsDbContext()
            : base("name=WMSDbContext")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
