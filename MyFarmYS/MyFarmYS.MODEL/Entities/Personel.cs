using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFarmYS.MODEL.Entities
{
    public class Personel
    {
        [Key]
        public int PersonelID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Cinsiyet { get; set; }
        public Nullable<DateTime> DogumTarih { get; set; }
        public Nullable<bool> MedeniDurum { get; set; }
        public string Fotograf { get; set; }
        public string Gorev { get; set; }
        public Nullable<DateTime> BaslamaTarih { get; set; }
        public double? KıdemYili { get; set; }
        public decimal? Maas { get; set; }

        public override string ToString()
        {
            return Ad + " " + Soyad;
        }

    }
}
