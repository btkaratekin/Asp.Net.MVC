using OgrIsler.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrIsler.DataAccess.Concrete
{
    public class OgrIslerDbContext : DbContext
    {
        public DbSet<OgrBilgi> OgrenciBilgi { get; set; }
        public DbSet<OgrOkul> OgrenciOkul { get; set; }
        public DbSet<OgrProgram> OgrenciProgram { get; set; }

        public OgrIslerDbContext():base("OgrIslerConnectionString")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OgrBilgi>().ToTable("OgrBilgi");
            modelBuilder.Entity<OgrOkul>().ToTable("OgrOkul");
            modelBuilder.Entity<OgrProgram>().ToTable("OgrProgram");
            modelBuilder.Entity<OgrBilgi>().HasRequired(b => b.ogrOkul).WithRequiredPrincipal(x => x.ogrBilgi);
            modelBuilder.Entity<OgrOkul>().HasRequired(Ok => Ok.ogrProgram).WithMany(p => p.ogrOkuls).Map(;
        }
    }
}
