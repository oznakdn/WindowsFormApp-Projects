using CRMapp.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CRMapp.DataAccessLayer
{
    public class CRMappContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=CRMappDB; Trusted_Connection=true;");
            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<Urun> Urunler { get; set; }
        public virtual DbSet<UrunKategori> UrunKategoriler { get; set; }
        public virtual DbSet<Randevu> Randevular { get; set; }
        public virtual DbSet<Gorusme> Gorusmeler { get; set; }
        public virtual DbSet<Musteri> Musteriler { get; set; }
        public virtual DbSet<MusteriUrun> MusteriUrunler { get; set; }
        public virtual DbSet<Personel> Personeller { get; set; }
        public virtual DbSet<Kullanici> Kullanicilar { get; set; }
        public virtual DbSet<Departman> Departmanlar { get; set; }
        public virtual DbSet<iletisim> iletisimler { get; set; }
    }
}
