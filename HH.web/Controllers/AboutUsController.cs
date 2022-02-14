using Microsoft.AspNetCore.Mvc;

namespace HH.web.Controllers
{
    public class AboutUSController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
