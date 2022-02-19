using DevExtreme.AspNet.Data;
using HH.bll.DTOs.CompanyDTO;
using HH.bll.Services.CompanyService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;
using HH.web.Binder;

namespace HH.web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyAPIController : ControllerBase
    {
        private readonly ICompanyService _companyservice;
        public CompanyAPIController(ICompanyService companyservice)
        {
            _companyservice = companyservice;
        }
        //GET: api/Company
        [HttpGet("GetAllPublishListNews")]
        public object GetAllPublishListNews()
        {
            return (_companyservice.GetAllPublishListNews().AsQueryable());
        }
        //Get: api/Company/{id}
        [HttpGet("GetPublishNewsDetail/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            NewsDetailDTO result =await  _companyservice.GetPublishNewsDetail(id);
            return Ok(result);
        }
        //POST: api/Company
        [HttpPost]
        public async Task<IActionResult> Post(CreateNewsDTO value)
        {
            if (ModelState.IsValid)
            {
                await _companyservice.CreateNews(value);
                return Ok(value);
            }
            return BadRequest();
        }
        //PUT: api/Company/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(EditNewsDTO value)
        {
            if (ModelState.IsValid)
            {
                await _companyservice.EditNews(value);
                return Ok(value); 
            }
            return BadRequest();
        }
        //DELETE: api/Company/{id}
        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id)
        {
            await _companyservice.RemoveNews(id);
        }
    }
}
