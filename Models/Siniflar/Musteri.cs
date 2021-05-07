using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineTicariOtomasyon.Models.Siniflar
{
    public class Musteri
    {
        [Key]
        public int MusteriID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string MusteriAd { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string MusteriSoyad { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(15)]
        public string MusteriSehir { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string MusteriMail { get; set; }
        public ICollection<SatisHareket> SatisHarekets { get; set; }
    }
}