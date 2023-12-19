using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMapp.Model
{
    public class Musteri : Base
    {
        public Musteri()
        {
            MusteriUrunler = new HashSet<MusteriUrun>();
        }

        public int Id { get; set; }
        public int? iletisimId { get; set; }
        public string Meslek { get; set; }



        public virtual iletisim İletisim { get; set; }

        public virtual ICollection<MusteriUrun> MusteriUrunler { get; set; }


    }
}
