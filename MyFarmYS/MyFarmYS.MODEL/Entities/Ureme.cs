using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFarmYS.MODEL.Entities
{
    public class Ureme
    {
        [Key]
        public int ID { get; set; }
        public Nullable<DateTime> SonDogurmaTarih { get; set; }
        public Nullable<DateTime> SonKizginlikTarih { get; set; }
        public Nullable<DateTime> SonTohumlanmaTarih { get; set; }
        public int? BogaID { get; set; }
        public int? PersonelID { get; set; }
        public short TohumlamaSayi { get; set; }
        public bool GebelikKontrolYapildiMi { get; set; }
        public bool GebelikKontrolSonuc { get; set; }
        public Nullable<DateTime> TahminDogurmaTarih { get; set; }
        public short ServisPeriyod { get; set; }

        public int? HayvanID { get; set; }


        public virtual Hayvan Hayvan { get; set; }

    }
}
