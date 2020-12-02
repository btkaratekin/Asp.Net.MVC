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
        public DbSet<OgrBolum> OgrenciBolum { get; set; }
        public DbSet<OgrDanisman> OgrenciDanisman { get; set; }
        public OgrIslerDbContext():base("OgrIslerConnectionString")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OgrBilgi>().ToTable("OgrBilgi");
            modelBuilder.Entity<OgrOkul>().ToTable("OgrOkul");
            modelBuilder.Entity<OgrProgram>().ToTable("OgrProgram");
            modelBuilder.Entity<OgrBolum>().ToTable("OgrBolum");
            modelBuilder.Entity<OgrDanisman>().ToTable("OgrDanisman");
            modelBuilder.Entity<OgrBilgi>().HasRequired(b => b.ogrOkul).WithRequiredPrincipal(x => x.ogrBilgi);
            modelBuilder.Entity<OgrOkul>().HasRequired(Ok => Ok.ogrProgram).WithMany(p => p.ogrOkuls).Map(m => m.MapKey("Pkodu"));
            modelBuilder.Entity<OgrProgram>().HasRequired(Op => Op.Bkodu).WithMany(x => x.ogrPrograms).Map(m => m.MapKey("Bkodu"));
            modelBuilder.Entity<OgrDanisman>().HasRequired(Od => Od.Bkodu).WithMany(b => b.ogrDanismans).Map(m => m.MapKey("Bkodu"));
            modelBuilder.Entity<OgrOkul>().HasRequired(o => o.ogrDanisman).WithMany(d => d.OgrOkuls).Map(m => m.MapKey("Dkodu"));
        }

    }
}
