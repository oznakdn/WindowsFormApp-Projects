using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Personel
    {
        public int PersonelID { get; set; }
        public string AdSoyad { get; set; }
        public string Gorev { get; set; }
        public string Fotograf { get; set; }
        public string Cinsiyet { get; set; }
        public Nullable<bool> MedeniDurum { get; set; }
        public Nullable <DateTime> GirisTarih { get; set; }
        public short CalismaYili { get; set; }
        public double? Maas{ get; set; }
        public double? DigerOdemeler { get; set; }
        public double? ToplamOdeme { get; set; }

    }
}
