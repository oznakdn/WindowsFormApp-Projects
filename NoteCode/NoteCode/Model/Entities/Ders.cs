using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteCode.Model.Entities
{
    public class Ders
    {
        public int DersID{ get; set; }
        public string DersAdi { get; set; }
        public string Tur { get; set; }


        public virtual ICollection<Konu> Konus { get; set; }
        public virtual ICollection<AltKonu> AltKonus { get; set; }
    }
}
