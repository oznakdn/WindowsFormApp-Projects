using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteCode.Model.Entities
{
    public class Konu
    {
        [Key]
        public int KonuID { get; set; }
        public string KonuAdi { get; set; }

        public int? Dersid { get; set; }



        public virtual ICollection<AltKonu> AltKonus { get; set; }

    }
}
