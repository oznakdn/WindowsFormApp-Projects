using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Arac
    {
        public int AracID { get; set; }
        public int? MarkaId { get; set; }
        public int? SeriId { get; set; }
        public string ModelAd { get; set; }
        public string Yil { get; set; }
        public string Renk { get; set; }
        public string Yakit { get; set; }
        public Nullable<bool> LpgDurum { get; set; }
        public string Vites { get; set; }
        public string KasaTipi { get; set; }
        public string Fotograf { get; set; }
        public double? Kilometre { get; set; }
        public double? MotorGucu { get; set; }
        public double? MotorHacmi { get; set; }
        public string Cekis { get; set; }
        public Nullable<bool> GarantiDurumu { get; set; }
        public Nullable<DateTime> GelisTarih { get; set; }
        public Nullable<bool> Durum { get; set; }
        public string Aciklama { get; set; }




        public double? AlisFiyati { get; set; }
        public double? SatisFiyati { get; set; }







    }
}
