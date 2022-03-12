using Microsoft.AspNetCore.Mvc;

namespace HH.web.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
