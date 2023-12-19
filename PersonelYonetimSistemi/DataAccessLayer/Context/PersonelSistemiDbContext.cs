using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EntityLayer;

namespace DataAccessLayer.Context
{
    class PersonelSistemiDbContext:DbContext
    {
        public PersonelSistemiDbContext():base("name=PersonelSistemiDbContext")
        {

        }

        public virtual DbSet<Personel> Personeller { get; set; }
        public virtual DbSet<Birim> Birimler { get; set; }
    }
}
