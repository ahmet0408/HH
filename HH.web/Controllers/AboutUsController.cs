using AutoMapper;
using HH.bll.DTOs.AboutUsDTO;
using HH.bll.Services.AboutUsService;
using HH.bll.Services.LanguageService;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace HH.web.Controllers
{
    public class AboutUsController : Controller
    {
        private readonly IAboutUsService _aboutService;
        private readonly ILanguageService _languageService;
        private readonly IMapper _mapper;

        public AboutUsController(IAboutUsService aboutService, ILanguageService languageService, IMapper mapper)
        {
            _aboutService = aboutService;
            _languageService = languageService;
            _mapper = mapper;   
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
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateAboutUsDTO aboutUs)
        {
            if (ModelState.IsValid)
            {
                await _aboutService.CreateAbout(aboutUs);

                return RedirectToAction("Index");
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            return View(aboutUs);
        }
        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }
       
        public IActionResult Delete(int? id)
        {
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            return View();
        }

    }
}
