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
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Email { get; set; }
        public Nullable<DateTime> Tarih { get; set; }
        public Nullable<bool> AktifMi { get; set; }
        public int? BirimId { get; set; }


        public virtual Birim Birimi { get; set; }
    }
}
