using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Marka
    {
        public Marka()
        {
            Serileri = new HashSet<Seri>();
        }


        public int MarkaID { get; set; }
        public string MarkaAd { get; set; }
        public string MarkaLogo { get; set; }

        public virtual ICollection<Seri> Serileri { get; set; }

    }
}
