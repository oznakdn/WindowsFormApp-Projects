using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFarmYS.MODEL.Entities
{
    public class Kullanici
    {
        [Key]
        public int KullaniciID { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public Nullable<DateTime> KayitTarihi { get; set; }
        public string Gorevi { get; set; }
        public string Yetkisi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }

    }
}
