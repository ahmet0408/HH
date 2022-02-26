using HH.bll.DTOs.ProductDTO;
using HH.bll.Services.ProductService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HH.web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductAPIController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductAPIController(IProductService productservice)
        {
            _productService = productservice;
        }
        [HttpGet("GetAlllProduct")]
        public object GetAlllProduct()
        {
            return _productService.GetAlllProduct().AsQueryable();
        }
        //GET: api/ProductAPI/GetOption
        [HttpGet("GetOption")]
        public object GetAll()
        {
            return (_productService.GetAll().AsQueryable());
        }
        //GET: api/ProductAPI/GetProduct
        [HttpGet("GetProduct")]
        public object GetAllProduct()
        {
            return (_productService.GetAllProduct().AsQueryable());
        }
        //GET: api/ProductAPI/GetAllPublishProduct
        [HttpGet("GetAllPublishProduct")]
        public object GetAllPublishProduct()
        {
            return (_productService.GetAllPublishProductDTO().AsQueryable());
        }
        //GET: api/Product/GetProductPage/1
        [HttpGet("GetProductPage/{id}")]
        public async Task<ProductDetailDTO> Get(int id)
        {
            ProductDetailDTO result = await _productService.GetProductPage(id);
            return result;
        }
        //GET: api/Product/GetAllOptionDetailByOptionId/1
        [HttpGet("GetAllOptionDetailByOptionId/{id}")]
        public object GetOptionContent(int id)
        {
            return (_productService.GetAllOptionDetailByOptionId(id).AsQueryable());
        }
        //POST: api/Product
        [HttpPost]
        public async Task<IActionResult> Post(CreateProductDTO value)
        {
            if (ModelState.IsValid)
            {
                await _productService.CreateProduct(value);
                return Ok(value);
            }
            return BadRequest();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(EditProductDTO value)
        {
            if (ModelState.IsValid)
            {
                await _productService.EditProduct(value);
                return Ok(value);
            }
            return BadRequest();
        }
        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id)
        {
            await _productService.RemoveProduct(id);
        }
    }
}
