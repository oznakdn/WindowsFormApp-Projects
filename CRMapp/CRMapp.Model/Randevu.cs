using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMapp.Model
{
    public class Randevu
    {
        public Randevu()
        {
            Gorusmeler = new HashSet<Gorusme>();
        }

        public int Id { get; set; }
        public DateTime? RandevuTarihi { get; set; }
        public int? MusteriId { get; set; }
        public string Konu { get; set; }
        public string Aciklama { get; set; }


        public virtual ICollection<Gorusme> Gorusmeler { get; set; }
    }
}
