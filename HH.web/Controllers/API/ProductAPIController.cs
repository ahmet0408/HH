using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
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
        
        //GET: api/ProductAPI/GetAllProduct
        [HttpGet("GetAllProduct")]
        public object GetAllProduct(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load<Product>(_productService.GetAllProduct().AsQueryable(), loadOptions);
        }
        [HttpGet("GetAllOptionContentForOption/{id}")]
        public object GetAllOptionContentForOption(int id, DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load<OptionContent>(_productService.GetAllOptionContentForOption(id).AsQueryable(), loadOptions);
        }
        //GET: api/ProductAPI/GetAllPublishProduct
        [HttpGet("GetAllPublishProduct")]
        public object GetAllPublishProduct()
        {
            return (_productService.GetAllPublishProductDTO().AsQueryable());
        }
        //GET: api/ProductAPI/GetProductPage/1
        [HttpGet("GetProductPage/{id}")]
        public async Task<ProductDetailDTO> Get(int id)
        {
            ProductDetailDTO result = await _productService.GetProductPage(id);
            return result;
        }
        //GET: api/ProductAPI/GetAllOption
        [HttpGet("GetAllOption")]
        public object GetAllOption(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load<dal.Models.Product.Option>(_productService.GetOptions().AsQueryable(), loadOptions);
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
        [HttpDelete("GetAllProduct/{id}")]
        public async Task DeleteAsync(int id)
        {
            await _productService.RemoveProduct(id);
        }
        [HttpDelete("GetAllOption/{id}")]
        public async Task Delete(int id)
        {
            await _productService.RemoveOption(id);
        }
    }
}
