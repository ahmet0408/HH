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
        [HttpGet]
        public async Task<IActionResult> EditOption(int id)
        {
            var option = await _productService.GetOptionForEditById(id);
            if (option == null)
            {
                return NotFound();
            }

            //option.PreviousUrl = HttpContext.Request.Headers["Referer"].ToString();
            return View(option);
        }
        [HttpPost]
        public async Task<IActionResult> EditOption(EditOptionDTO editOptionDTO)
        {
            if (ModelState.IsValid)
            {
                await _productService.EditOption(editOptionDTO);
                return RedirectToAction("Index");
            }
            return View(editOptionDTO);
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
        public async Task<IActionResult> EditOptionContent(int id)
        {
            var optionContent = await _productService.GetOptionContentForEditById(id);
            if (optionContent == null)
            {
                return NotFound();
            }
            optionContent.PreviousUrl = HttpContext.Request.Headers["Referer"].ToString();
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            return View(optionContent);
        }
        [HttpPost]
        public async Task<IActionResult> EditOptionContent(EditOptionContentDTO editOptionContentDTO)
        {
            if (ModelState.IsValid)
            {
                await _productService.EditOptionContent(editOptionContentDTO);
                return Redirect(editOptionContentDTO.PreviousUrl);
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            return View(editOptionContentDTO);
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
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var product = await _productService.GetProductForEditById(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            return View(product);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(EditProductDTO editProductDTO)
        {
            if (ModelState.IsValid)
            {
                await _productService.EditProduct(editProductDTO);
                return RedirectToAction("Index");
            }
            
            ViewBag.Languages = _languageService.GetAllPublishLanguage().OrderBy(o => o.DisplayOrder);
            return View(editProductDTO);
        }
    }
}
