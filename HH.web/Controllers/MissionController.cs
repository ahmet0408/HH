using HH.bll.DTOs.MissionDTO;
using HH.bll.Services.LanguageService;
using HH.bll.Services.MissionService;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace HH.web.Controllers
{
    public class MissionController : Controller
    {
        private readonly IMissionService _missionService;
        private readonly ILanguageService _languageService;

        public MissionController(IMissionService missionService, ILanguageService languageService)
        {
            _missionService = missionService;
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
        public async Task<IActionResult> Create(CreateMissionDTO mission)
        {
            if (ModelState.IsValid)
            {
                await _missionService.CreateMission(mission);

                return RedirectToAction("Index");
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            return View(mission);
        }
    }
}
