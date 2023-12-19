using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMapp.Model
{
    public class MusteriUrun
    {
        public int Id { get; set; }
        public int? MusteriId { get; set; }
        public int? UrunId { get; set; }


        public virtual Musteri Musteri { get; set; }
        public virtual Urun Urun { get; set; }

    }
}
