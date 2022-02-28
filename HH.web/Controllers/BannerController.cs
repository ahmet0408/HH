using HH.bll.DTOs.BannerDTO;
using HH.bll.Services.BannerService;
using HH.bll.Services.LanguageService;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace HH.web.Controllers
{
    public class BannerController : Controller
    {
        private readonly IBannerService _bannerService;
        private readonly ILanguageService _languageService;
        public BannerController(IBannerService bannerService, ILanguageService languageService)
        {
            _bannerService = bannerService;
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
        public async Task<IActionResult> Create(CreateBannerDTO banner)
        {
            if (ModelState.IsValid)
            {
                await _bannerService.CreateBanner(banner);

                return RedirectToAction("Index");
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            return View(banner);
        }
        [HttpGet]
        
        public async Task<IActionResult> Edit(int id)
        {
            var about = await _bannerService.GetBannerForEditById(id);
            if (about == null)
            {
                return NotFound();
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            return View(about);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(EditBannerDTO editAboutUsDTO)
        {
            if (ModelState.IsValid)
            {
                await _bannerService.EditBanner(editAboutUsDTO);
                return RedirectToAction("Index");
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            return View(editAboutUsDTO);
        }
        public IActionResult Delete(int? id)
        {
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            return View();
        }
    }
}
