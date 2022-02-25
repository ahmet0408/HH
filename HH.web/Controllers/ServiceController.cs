using HH.bll.DTOs.ServicesDTO;
using HH.bll.Services.LanguageService;
using HH.bll.Services.ServiceService;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace HH.web.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;
        private readonly ILanguageService _languageService;

        public ServiceController(IServiceService serviceService, ILanguageService languageService)
        {
            _serviceService = serviceService;
            _languageService = languageService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateServiceDTO service)
        {
            if (ModelState.IsValid)
            {
                await _serviceService.CreateService(service);

                return RedirectToAction("Index");
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            return View(service);
        }
    }
}
