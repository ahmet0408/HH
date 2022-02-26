using HH.bll.DTOs.ProjectDTO;
using HH.bll.Services.LanguageService;
using HH.bll.Services.ProjectService;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace HH.web.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IProjectService _projectService;
        private readonly ILanguageService _languageService;

        public ProjectController(IProjectService projectService, ILanguageService languageService)
        {
            _projectService = projectService;
            _languageService = languageService;
        }
            
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Location()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateLocation()
        {
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateLocation(CreateLocationDTO location)
        {
            if (ModelState.IsValid)
            {
                await _projectService.CreateLocation(location);

                return RedirectToAction("Location");
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            return View(location);
        }
        [HttpGet]
        public IActionResult Status()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateStatus()
        {
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateStatus(CreateStatusDTO status)
        {
            if (ModelState.IsValid)
            {
                await _projectService.CreateStatus(status);

                return RedirectToAction("Status");
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            return View(status);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateProjectDTO project)
        {
            if (ModelState.IsValid)
            {
                await _projectService.CreateProject(project);

                return RedirectToAction("Index");
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            return View(project);
        }
    }
}
