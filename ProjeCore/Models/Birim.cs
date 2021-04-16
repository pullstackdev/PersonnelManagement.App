using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeCore.Models
{
    public class Birim
    {
        [Key]
        public int BirimID { get; set; }
        public string BirimAd { get; set; }
        public string Detail { get; set; }
        public IList<Personel> Personels{ get; set; } //1->sonsuz ilişki-BÜYÜK HARF VE ÇOĞUL EKİ ÖNERİLEN
    }
}
