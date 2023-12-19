using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Satis
    {
        public Satis()
        {
            Musterileri = new HashSet<Musteri>();
        }

        public int SatisID { get; set; }
        public int? AracId { get; set; }
        public int? MusteriId { get; set; }
        public string MusteriAdSoyad { get; set; }
        public Nullable<DateTime> SatisTarih { get; set; }
        public Nullable<bool> Kapora { get; set; }
        public Nullable<DateTime> KaporaTarih { get; set; }
        public double KaporaTutar { get; set; }
        public double SatisTutar { get; set; }
        public double KalanTutar { get; set; }
        public string OdemeTipi { get; set; }
        public int? PersonelId { get; set; }






        public virtual ICollection<Musteri> Musterileri { get; set; }

    }
}
