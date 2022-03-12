using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HH.web.Controllers
{
    //[Authorize]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        ////[AllowAnonymous]
        //public IActionResult Login()
        //{
        //    return View();
        //}
        //[HttpPost]
        //[AllowAnonymous]
        //public async Task<IActionResult> Login(LoginViewModel model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(model);
        //    }
        //    var claims = new List<Claim>
        //    {
        //        new Claim("Demo", "Value")
        //    };
        //    var claimIdentity = new ClaimsIdentity(claims, "Cookie");
        //    var claimPrincipal = new ClaimsPrincipal(claimIdentity);
        //    await HttpContext.SignInAsync("Cookie", claimPrincipal);

        //    return Redirect(model.ReturnUrl);
        //}
        //public IActionResult LogOff()
        //{
        //    HttpContext.SignOutAsync("Cookie");
        //    return Redirect("/Index");
        //}

      
        [HttpGet]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return LocalRedirect(returnUrl);
        }

    }
}
