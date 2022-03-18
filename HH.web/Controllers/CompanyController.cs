using HH.bll.DTOs.CompanyDTO;
using HH.bll.Services.CompanyService;
using HH.bll.Services.LanguageService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace HH.web.Controllers
{
    [Authorize(Roles = "Admin")]
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
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var news = await _companyService.GetNewsForEditById(id);
            if (news == null)
            {
                return NotFound();
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            return View(news);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(EditNewsDTO editNewsDTO)
        {
            if (ModelState.IsValid)
            {
                await _companyService.EditNews(editNewsDTO);
                return RedirectToAction("Index");
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            return View(editNewsDTO);
        }
        //public IActionResult Delete(int? id)
        //{
        //    ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
        //    return View();
        //}
        public IActionResult License()
        {
            return View();
        }
        public IActionResult CreateLicense()
        {
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateLicense(CreateLicenseDTO license)
        {
            if (ModelState.IsValid)
            {
                await _companyService.CreateLicense(license);

                return RedirectToAction("License");
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            return View(license);
        }
        [HttpGet]
        public async Task<IActionResult> EditLicense(int id)
        {
            var license = await _companyService.GetLicenseForEditById(id);
            if (license == null)
            {
                return NotFound();
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            return View(license);
        }
        [HttpPost]
        public async Task<IActionResult> EditLicense(EditLicenseDTO editLicenseDTO)
        {
            if (ModelState.IsValid)
            {
                await _companyService.EditLicense(editLicenseDTO);
                return RedirectToAction("License");
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            return View(editLicenseDTO);
        }
    }
}
