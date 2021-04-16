using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeCore.Models
{
    public class Context: DbContext //Microsoft.EntityFrameworkCore; gerekiyor nugetten indirdik-buradan inherit edilmeli
    {
        //webconfig yerine db bağlantı ayarları
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=DESKTOP-HGL39QT; database=BirimDB; integrated security=true;");
        }
        public DbSet<Birim> Birims { get; set; } //BÜYÜK VE COĞUL ÖNERİLEN
        public DbSet<Personel> Personels { get; set; }
    }
}
