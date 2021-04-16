using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjeCore.Models;

namespace ProjeCore.Controllers
{
    public class PersonelimController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var personeller = context.Personels.Include(x=>x.Birim).ToList(); //personel tablosuna birim tablosunu eklemek için include kullandık
            return View(personeller);
        }
        //default httpget
        public IActionResult AddPersonnel()
        {
            //birimm dropdown içini doldurmak için
            List<SelectListItem> units = (from x in context.Birims.ToList()
                                          select new SelectListItem
                                          {
                                              Text = x.BirimAd, //kullancının göreceği
                                              Value = x.BirimID.ToString() //arkada tutulacak değer
                                          }).ToList();
            ViewBag.unitList = units;
            return View();
        }
        [HttpPost]
        public IActionResult AddPersonnel(Personel personel)
        {
            //ilişkili tabloyuda ekleyebilmek için yapıldı
            var unit = context.Birims.Where(x => x.BirimID == personel.Birim.BirimID).FirstOrDefault();
            personel.Birim = unit;//aynı modeller

            context.Personels.Add(personel);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        //default httpget
        public IActionResult UpdatePersonnel(int id)
        {
            //birimm dropdown içini doldurmak için
            List<SelectListItem> units = (from x in context.Birims.ToList()
                                          select new SelectListItem
                                          {
                                              Text = x.BirimAd, //kullancının göreceği
                                              Value = x.BirimID.ToString() //arkada tutulacak değer
                                          }).ToList();
            ViewBag.unitList = units;
            var person = context.Personels.Find(id);
            return View(person);
        }
        [HttpPost]
        public IActionResult UpdatePersonnel(Personel person)
        {
            //ilişkili tabloyuda ekleyebilmek için yapıldı
            var unit = context.Birims.Where(x => x.BirimID == person.Birim.BirimID).FirstOrDefault();
            person.Birim = unit;//aynı modeller

            var personnel = context.Personels.Find(person.PersonelID);
            personnel.Ad = person.Ad;
            personnel.Soyad = person.Soyad;
            personnel.Sehir = person.Sehir;
            
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeletePersonnel(int id)
        {
            var personnel = context.Personels.Find(id);
            context.Personels.Remove(personnel);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}