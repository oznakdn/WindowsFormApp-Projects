using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMapp.Model
{
    public class Personel : Base
    {
        public Personel()
        {
            Kullanicilar = new HashSet<Kullanici>();
            Gorusmeler = new HashSet<Gorusme>();
        }

        public int Id { get; set; }
        public int? DepartmanId { get; set; }
        public int? iletisimId { get; set; }

        public virtual iletisim İletisim { get; set; }
        public virtual ICollection<Kullanici> Kullanicilar { get; set; }
        public virtual ICollection<Gorusme> Gorusmeler { get; set; }

    }
}
