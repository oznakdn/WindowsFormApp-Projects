using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFarmYS.MODEL.Entities
{
    public class Asilama
    {
        [Key]
        public int ID { get; set; }
        public string AsiAdi { get; set; }
        public string YapilisAmaci { get; set; }
        public string UygulamaSekli { get; set; }
        public Nullable<DateTime> UygulamaTarih { get; set; }
        public short? UygulananDoz { get; set; }
        public int? PersonelID { get; set; }

        public int? HayvanID { get; set; }

        public virtual Hayvan Hayvan { get; set; }



    }
}
