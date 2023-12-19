using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMapp.Model
{
    public class Urun
    {
        public Urun()
        {
            MusteriUrunler = new HashSet<MusteriUrun>();
        }

        public int Id { get; set; }
        public string UrunAd { get; set; }
        public string Aciklama { get; set; }
        public int? KategoriId { get; set; }

        public virtual UrunKategori UrunKatgori { get; set; }

        public virtual ICollection<MusteriUrun> MusteriUrunler { get; set; }
    }
}
