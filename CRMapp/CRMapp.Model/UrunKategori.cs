using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMapp.Model
{
    public class UrunKategori
    {
        public UrunKategori()
        {
            Urunler = new HashSet<Urun>();
        }

        public int Id { get; set; }
        public string Kategori { get; set; }


        public virtual ICollection<Urun> Urunler { get; set; }
    }
}
