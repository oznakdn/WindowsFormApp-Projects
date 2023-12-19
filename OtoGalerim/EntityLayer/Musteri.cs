using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Musteri
    {
        public Musteri()
        {
            Satislari = new HashSet<Satis>();
        }

        public int MusteriID { get; set; }
        public string MusteriAdSoyad { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Email { get; set; }


        public virtual ICollection<Satis> Satislari { get; set; }
    }
}
