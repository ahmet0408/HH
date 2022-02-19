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
        private readonly IProductService _productservice;
        public ProductAPIController(IProductService productservice)
        {
            _productservice = productservice;
        }
        [HttpGet("GetAllPublishProductDTO")]
        public object GetAllPublishProductDTO()
        {
            return (_productservice.GetAllPublishProductDTO().AsQueryable());
        }
        //GET: api/Product
        [HttpGet("GetPublishProductDetailtDTO/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            ProductDetailDTO result = await _productservice.GetProductDetailtWithoutOption(id);

           // await _productservice.GetAllOptionNameByProductId(id);
            return Ok(result);
        }
        //GET: api/Product
        [HttpGet("GetAllOptionDetailByOptionId/{id}")]
        public object GetAllOptionDetailByOptionId(int id)
        {
            return (_productservice.GetAllOptionDetailByOptionId(id).AsQueryable());
        }
        //POST: api/Product
        [HttpPost]
        public async Task<IActionResult> Post(CreateProductDTO value)
        {
            if (ModelState.IsValid)
            {
                await _productservice.CreateProduct(value);
                return Ok(value);
            }
            return BadRequest();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(EditProductDTO value)
        {
            if (ModelState.IsValid)
            {
                await _productservice.EditProduct(value);
                return Ok(value);
            }
            return BadRequest();
        }
        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id)
        {
            await _productservice.RemoveProduct(id);
        }
    }
}
