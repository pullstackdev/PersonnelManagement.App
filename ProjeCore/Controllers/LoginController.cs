using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using ProjeCore.Models;

namespace ProjeCore.Controllers
{
    public class LoginController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Admin admin)
        {
            var userInfos = context.Admins.FirstOrDefault(x => x.User == admin.User && x.Password == admin.Password);
            if (userInfos != null)//user var ise
            {
                //.netcore identity ile authentication işlemleri
                //(giriş) taleplerini güvenlik aşamaları
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, admin.User)//claimi burada ekledim (kim)
                };
                var userIdentity = new ClaimsIdentity(claims, "Login");//claim ve tipi (hangi erişim tipi)
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                //controllerdaki metodda varolan authorize attribute'u check ediyor
                return RedirectToAction("Index", "Personelim");

            }
            return View();
        }
    }
}