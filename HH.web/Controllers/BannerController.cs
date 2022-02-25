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
    }
}
