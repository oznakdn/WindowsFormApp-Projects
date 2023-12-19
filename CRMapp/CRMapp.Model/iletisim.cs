using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMapp.Model
{
    public class iletisim
    {
        public iletisim()
        {
            Musteriler = new HashSet<Musteri>();
            Personeller = new HashSet<Personel>();
        }

        public int Id { get; set; }
        public string Adres { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }


        public virtual ICollection<Musteri> Musteriler { get; set; }
        public virtual ICollection<Personel> Personeller { get; set; }
    }
}
