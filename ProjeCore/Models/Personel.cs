using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeCore.Models
{
    public class Personel
    {
        [Key]
        public int PersonelID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Sehir { get; set; }

        public int BirimID { get; set; } //birim clasındaki id ile aynı isimli olmalı
        public Birim Birim { get; set; } //1-1 ilişki, 1 personel 1 departmente ait- migration basınca kendisi oluşturur db de
    }
}
