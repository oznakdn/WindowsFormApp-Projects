using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFarmYS.MODEL.Entities
{
    public class Hayvan
    {
        public Hayvan()
        {
            this.Laktasyon = new HashSet<Laktasyon>();
            this.Ureme = new HashSet<Ureme>();
            this.Dogum = new HashSet<Dogum>();
            this.Saglik = new HashSet<Saglik>();
            this.Asilama = new HashSet<Asilama>();
        }

        [Key]
        public int HayvanID { get; set; }
        public string Ad { get; set; }
        public string KupeNo { get; set; }
        public string Fotograf { get; set; }
        public string Grup { get; set; }
        public string Cinsiyet { get; set; }
        public Nullable<DateTime> DogumTarih { get; set; }
        public double? Yas { get; set; }
        public short? DogumAgirlik { get; set; }
        public string DogumTipi { get; set; }
        public string DogumSekli { get; set; }
        // Verim Özellikleri
        public short? CanliAgirlik { get; set; }
        public short? LaktSayisi { get; set; }
        public short? OrtLakSuresi { get; set; }
        public short? OrtGunSutVerimi { get; set; }
        public short? OrtLaktSutVerimi { get; set; }
        public string VerimGrup { get; set; }
        // Üreme ve Doğum Özellikleri
        public Nullable<DateTime> DamizliktaKullTarih { get; set; }
        public short? DamizlikYasi { get; set; }
        public short? DamizlikAgirlik { get; set; }
        public short? TopYavruSayisi { get; set; }
        public short? UremePerformansi { get; set; }




        public virtual ICollection<Laktasyon> Laktasyon { get; set; }
        public virtual ICollection<Ureme> Ureme { get; set; }
        public virtual ICollection<Dogum> Dogum { get; set; }
        public virtual ICollection<Saglik> Saglik { get; set; }
        public virtual ICollection<Asilama> Asilama { get; set; }

    }
}
