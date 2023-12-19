using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Seri
    {
        public int SeriID { get; set; }
        public string SeriAd { get; set; }
        public int? MarkaId { get; set; }



        public virtual Marka Markasi { get; set; }
    }
}
