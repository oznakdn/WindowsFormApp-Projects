using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFarmYS.MODEL.Entities
{
    public class Saglik
    {
        [Key]
        public int ID { get; set; }
        public Nullable<DateTime> Tarih { get; set; }
        public string HastalikAdi { get; set; }
        public string Belirtiler { get; set; }
        public string UygulananTedavi { get; set; }
        public string KullanilanIlaclar { get; set; }
        public string Durum { get; set; }
        public int? PersonelID { get; set; }

        public int? HayvanID { get; set; }


        public virtual Hayvan Hayvan { get; set; }
    }
}
