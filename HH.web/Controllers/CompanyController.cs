using HH.bll.DTOs.CompanyDTO;
using HH.bll.Services.CompanyService;
using HH.bll.Services.LanguageService;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace HH.web.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyService _companyService;
        private readonly ILanguageService _languageService;

        public CompanyController(ICompanyService companyService, ILanguageService languageService)
        {
            _companyService = companyService;
            _languageService = languageService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            return View();
        }
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateNewsDTO news)
        {
            if (ModelState.IsValid)
            {
                await _companyService.CreateNews(news);

                return RedirectToAction("Index");
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            return View(news);
        }
    }
}
