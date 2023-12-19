using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Birim
    {
        public Birim()
        {
            Personelleri = new HashSet<Personel>();
        }

        public int BirimID { get; set; }
        public string BirimAdi { get; set; }
        public string Aciklama { get; set; }


        public virtual ICollection<Personel> Personelleri { get; set; }
    }
}
