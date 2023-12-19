using MyFarmYS.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFarmYS.DAL
{
    public class MyFarmYSdbContext : DbContext
    {
        public MyFarmYSdbContext() : base("MyFarmYSdbContext")
        {

        }

        public virtual DbSet<Hayvan> Hayvanlar { get; set; }
        public virtual DbSet<Laktasyon> Laktasyonlar { get; set; }
        public virtual DbSet<Ureme> Uremeler { get; set; }
        public virtual DbSet<Dogum> Dogumlar { get; set; }
        public virtual DbSet<Saglik> Sagliklar { get; set; }
        public virtual DbSet<Asilama> Asilamalar { get; set; }

        public virtual DbSet<Personel> Personeller { get; set; }
        public virtual DbSet<Kullanici> Kullanicilar { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
