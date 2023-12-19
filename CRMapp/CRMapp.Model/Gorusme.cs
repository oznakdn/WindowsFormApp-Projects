using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMapp.Model
{
    public class Gorusme
    {
        public int Id { get; set; }
        public int? RandevuId { get; set; }
        public string Sonuc { get; set; }
        public string Aciklama { get; set; }
        public int? PersonelId { get; set; }

        public virtual Randevu Randevu { get; set; }

    }
}
