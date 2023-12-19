using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EntityLayer;

namespace DataAccessLayer.Context
{
    public class OtoGalerimContext:DbContext
    {
        public OtoGalerimContext():base("name=OtoGalerimContext")
        {

        }

        public virtual DbSet<Arac> Araclar { get; set; }
        public virtual DbSet<Gelir_Gider> GelirGiderler { get; set; }
        public virtual DbSet<Kullanici> Kullanicilar { get; set; }
        public virtual DbSet<Marka> Markalar { get; set; }
        public virtual DbSet<Seri> Seriler { get; set; }
        public virtual DbSet<Musteri> Musteriler { get; set; }
        public virtual DbSet<Personel> Personeller { get; set; }
        public virtual DbSet<Satis> Satislar { get; set; }

      
    }
}
