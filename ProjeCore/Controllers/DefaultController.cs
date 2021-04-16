using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjeCore.Models;

namespace ProjeCore.Controllers
{
    public class DefaultController : Controller
    {
        Context context = new Context(); //dbye bağlanmak için
        public IActionResult Index()
        {
            //normalde bu işlemleri repositoryde yapalım
            var unitList = context.Birims.ToList();
            return View(unitList);
        }
        [HttpGet] //sayfa yüklendiğinde çalışacak yeni sayfa
        public IActionResult AddUnit()
        {
            return View();
        }
        [HttpPost] //postta çalışacak, yeni sayfada yapılacak post işlemi için
        public IActionResult AddUnit(Birim unit)
        {
            context.Birims.Add(unit);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateUnit(int id)
        {
            //var depart = context.departments.Where(x => x.ID == id).FirstOrDefault();
            var depart = context.Birims.Find(id);

            return View(depart);
        }
        [HttpPost]
        public IActionResult UpdateUnit(Birim birim)
        {
            var unit = context.Birims.Find(birim.BirimID);
            unit.BirimAd = birim.BirimAd;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteUnit(int id)
        {
            //var depart = context.departments.Where(x => x.ID==id).FirstOrDefault();
            var depart = context.Birims.Find(id);
            context.Birims.Remove(depart);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}