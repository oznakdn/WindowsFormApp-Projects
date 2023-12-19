using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMapp.Model
{
    public class Kullanici
    {
        public int Id { get; set; }
        public int? PersonelId { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }

        public virtual Personel Personel { get; set; } 

    }
}
