namespace DnDApp.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DbcsContext : DbContext
    {
        public DbcsContext()
            : base("name=DbcsContext")
        {
        }

        public virtual DbSet<tableA> tableAs { get; set; }
        public virtual DbSet<tableB> tableBs { get; set; }
        public virtual DbSet<tableC> tableCs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
