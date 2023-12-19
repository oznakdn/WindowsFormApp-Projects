using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Gelir_Gider
    {
        [Key]
        public int KayitID { get; set; }
        public Nullable<DateTime> Baslangi { get; set; }
        public Nullable<DateTime> Bitis { get; set; }
        public double? PersonelGiderleri { get; set; }
        public double? AracAlimBedelleri { get; set; }
        public double? BankaOdemeleri { get; set; }
        public double? Elektrik { get; set; }
        public double? Su { get; set; }
        public double? Dogalgaz { get; set; }
        public double? Telefon { get; set; }
        public double? Internet { get; set; }
        public double? ToplamGider { get; set; }
        public double? AracSatisGelirleri { get; set; }
        public double? DigerGelirler { get; set; }
        public double? Kar_Zarar { get; set; }
        public Nullable<bool> Kar_ZararDurum { get; set; }




    }
}
