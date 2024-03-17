using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FurkanOzden_221103052.DAL
{
    public partial class DatabaseModel : DbContext
    {
        public DatabaseModel()
            : base("name=DatabaseModel")
        {
        }

        public virtual DbSet<Detaylar> Detaylar { get; set; }
        public virtual DbSet<Kadro> Kadro { get; set; }
        public virtual DbSet<Kategoriler> Kategoriler { get; set; }
        public virtual DbSet<Masalar> Masalar { get; set; }
        public virtual DbSet<Roller> Roller { get; set; }
        public virtual DbSet<Siparisler> Siparisler { get; set; }
        public virtual DbSet<Urunler> Urunler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Detaylar>()
                .Property(e => e.Fiyat)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Detaylar>()
                .Property(e => e.AraToplam)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Kategoriler>()
                .HasMany(e => e.Urunler)
                .WithOptional(e => e.Kategoriler)
                .HasForeignKey(e => e.KategoriID);

            

            modelBuilder.Entity<Siparisler>()
                .Property(e => e.Toplam)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Siparisler>()
                .Property(e => e.Alınan)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Siparisler>()
                .Property(e => e.changed)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Urunler>()
                .Property(e => e.Fiyat)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Urunler>()
                .Property(e => e.Resim)
                .IsUnicode(false);
        }
    }
}
