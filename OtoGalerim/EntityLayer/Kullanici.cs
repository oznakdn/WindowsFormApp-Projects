using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Kullanici
    {
        public int KullaniciID { get; set; }
        public string AdSoyad { get; set; }
        public string Yetki { get; set; }
        public DateTime KayitTarih { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }


    }
}
