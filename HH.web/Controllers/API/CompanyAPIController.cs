using DevExtreme.AspNet.Data;
using HH.bll.DTOs.CompanyDTO;
using HH.bll.Services.CompanyService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;
using DevExtreme.AspNet.Mvc;

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
        [HttpGet("GetAllNews")]
        public object GetAllNews(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load<News>(_companyservice.GetAllNews().AsQueryable(), loadOptions);

        }
        [HttpGet("GetAllLicense")]
        public object GetAllLicense(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load<License>(_companyservice.GetAllLicense().AsQueryable(), loadOptions);

        }
        //GET: api/Company/GetAllPublishNews
        [HttpGet("GetAllPublishNews")]
        public IActionResult GetAllPublishNews()
        {
            var result = _companyservice.GetAllPublishNews();
            return Ok(result);
        }
        //GET: api/Company/GetNewsPage/1
        [HttpGet("GetNewsPage/{id}")]
        public async Task<NewsDetailDTO> Get(int id)
        {
            NewsDetailDTO result =await  _companyservice.GetNewsPage(id);
            return result;
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
        [HttpDelete("GetAllNews/{id}")]
        public async Task DeleteAsync(int id)
        {
            await _companyservice.RemoveNews(id);
        }
        //POST: api/Company/CreateLicense
        [HttpPost("CreateLicense")]
        public async Task<IActionResult> CreateLicense(CreateLicenseDTO value)
        {
            if (ModelState.IsValid)
            {
                await _companyservice.CreateLicense(value);
                return Ok(value);
            }
            return BadRequest();
        }
        //PUT: api/Company/{id}
        [HttpPut("EditLicense/{id}")]
        public async Task<IActionResult> EditLicense(EditLicenseDTO value)
        {
            if (ModelState.IsValid)
            {
                await _companyservice.EditLicense(value);
                return Ok(value);
            }
            return BadRequest();
        }
        //DELETE: api/Company/{id}
        [HttpDelete("GetAllLicense/{id}")]
        public async Task Delete(int id)
        {
            await _companyservice.RemoveLicense(id);
        }
        //GET: api/Company/GetAllPublishLicense
        [HttpGet("GetAllPublishLicense")]
        public IActionResult GetAllPublishLicense()
        {
            var result = _companyservice.GetAllPublishLicense();
            return Ok(result);
        }
    }
}
