using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LocalizationNetCoreMvc.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace LocalizationNetCoreMvc.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginDTO loginDTO)
        {
            Response.Cookies.Append(
                      CookieRequestCultureProvider.DefaultCookieName,
                      CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(loginDTO.Language)),
                      new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
                  );
            return RedirectToAction("Index","Home");
        }
    }
}