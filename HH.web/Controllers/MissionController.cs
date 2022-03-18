using HH.bll.DTOs.MissionDTO;
using HH.bll.Services.LanguageService;
using HH.bll.Services.MissionService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace HH.web.Controllers
{
    [Authorize(Roles = "Admin")]
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
        [HttpGet]

        public async Task<IActionResult> Edit(int id)
        {
            var mission = await _missionService.GetMissionForEditById(id);
            if (mission == null)
            {
                return NotFound();
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            return View(mission);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(EditMissionDTO editMissionDTO)
        {
            if (ModelState.IsValid)
            {
                await _missionService.EditMission(editMissionDTO);
                return RedirectToAction("Index");
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            return View(editMissionDTO);
        }
        public IActionResult Delete(int? id)
        {
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            return View();
        }
    }
}
