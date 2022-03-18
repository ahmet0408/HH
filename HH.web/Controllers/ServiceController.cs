using HH.bll.DTOs.ServicesDTO;
using HH.bll.Services.LanguageService;
using HH.bll.Services.ServiceService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace HH.web.Controllers
{
    [Authorize(Roles = "Admin")]
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
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var service = await _serviceService.GetServiceForEditById(id);
            if (service == null)
            {
                return NotFound();
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            return View(service);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(EditServiceDTO editServiceDTO)
        {
            if (ModelState.IsValid)
            {
                await _serviceService.EditService(editServiceDTO);
                return RedirectToAction("Index");
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            return View(editServiceDTO);
        }
        public IActionResult Delete(int? id)
        {
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            return View();
        }
    }
}
