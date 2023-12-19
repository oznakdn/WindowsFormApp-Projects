using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteCode.Model.Entities
{
    public class AltKonu
    {
        [Key]
        public int AltKonuID { get; set; }
        public string AltKonuAd { get; set; }
        public string KullanimAlani { get; set; }
        public string SozDizimi { get; set; }
        public string Detay { get; set; }
        public string OrnekKod { get; set; }
        public Nullable<DateTime>Tarih { get; set; }

        public int? Konuid { get; set; }
        public int? Dersid { get; set; }



    }
}
