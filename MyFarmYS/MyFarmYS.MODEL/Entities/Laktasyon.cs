using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFarmYS.MODEL.Entities
{
    public class Laktasyon
    {
        [Key]
        public int ID { get; set; }
        public Nullable< bool> Durum { get; set; }
        public short LaktSira { get; set; }
        public Nullable<DateTime> LaktBasTarih { get; set; }
        public Nullable<DateTime> LaktBitTarih { get; set; }
        public short LaktSuresi { get; set; }
        public short GunOrtSutVer { get; set; }
        public short LakSutVer { get; set; }
        public double SutYagOran { get; set; }


        public int? HayvanID { get; set; }

        public virtual Hayvan Hayvan { get; set; }
    }
}
