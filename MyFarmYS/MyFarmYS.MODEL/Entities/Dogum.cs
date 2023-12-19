using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFarmYS.MODEL.Entities
{
    public class Dogum
    {
        [Key]
        public int ID { get; set; }
        public short? KacinciDogum { get; set; }
        public Nullable<DateTime> KuruyaAlmaTarih { get; set; }
        public short? KurudaKalmaSuresi { get; set; }
        public Nullable<DateTime> DogurmaTarih { get; set; }
        public string DogumSekli { get; set; }
        public string DogumTipi { get; set; }
        public string YavruCinsiyet { get; set; }
        public short? DogumAgirlik { get; set; }
        public Nullable<bool> CanliDogumMu { get; set; }

        public int? HayvanID { get; set; }


        public virtual Hayvan Hayvan { get; set; }

    }
}
