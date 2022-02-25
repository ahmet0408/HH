using HH.bll.DTOs.ProductDTO;
using HH.bll.Services.LanguageService;
using HH.bll.Services.ProductService;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace HH.web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ILanguageService _languageService;

        public ProductController(IProductService productService, ILanguageService languageService)
        {
            _productService = productService;
            _languageService = languageService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateOption()
        {       
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateOption(CreateOptionDTO option)
        {
            if (ModelState.IsValid)
            {
                await _productService.CreateOption(option);

                return RedirectToAction("Index");
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            return View(option);
        }
        public IActionResult CreateOptionContent()
        {
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateOptionContent(CreateOptionContentDTO optioncontent)
        {
            if (ModelState.IsValid)
            {
                await _productService.CreateOptionContent(optioncontent);

                return RedirectToAction("Index");
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            return View(optioncontent);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateProductDTO product)
        {
            if (ModelState.IsValid)
            {
                await _productService.CreateProduct(product);

                return RedirectToAction("Index");
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            return View(product);
        }
    }
}
