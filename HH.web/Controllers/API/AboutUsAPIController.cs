using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using HH.bll.DTOs.AboutUsDTO;
using HH.bll.Services.AboutUsService;
using HH.dal.Models.AboutUs;
using Microsoft.AspNetCore.Cors;
//using HH.web.Binder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HH.web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutUsAPIController : ControllerBase
    {
        private readonly IAboutUsService _aboutUsservice;
        public AboutUsAPIController(IAboutUsService aboutUsService)
        {
            _aboutUsservice = aboutUsService;
        }
        [EnableCors("AllowOrigin")]
        [HttpGet("GetAllAboutUs")]
        public object GetAllboutUs(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load<AboutUs>(_aboutUsservice.GetAllAboutUs().AsQueryable(), loadOptions);

        }
        [HttpGet("GetMainAboutUs")]
        public AboutUsDTO Get()
        {
            return _aboutUsservice.GetAboutUs();
            
        }
        [HttpGet("GetAboutUsDetail")]
        public async Task<IActionResult> GetAboutUsDetail()
        {
            AboutUsDetailDTO result = await _aboutUsservice.GetAboutUsDetail();
            return Ok(result);
        }
        [HttpGet("GetFooter")]
        public async Task<IActionResult> GetFooter()
        {
            FooterDTO result = await _aboutUsservice.GetFooter();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateAboutUsDTO value)
        {
            if (ModelState.IsValid)
            {
                await _aboutUsservice.CreateAbout(value);
                return Ok(value);
            }
            return BadRequest();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(EditAboutUsDTO value)
        {
            if (ModelState.IsValid)
            {
                await _aboutUsservice.EditAbout(value);
                return Ok(value);
            }
            return BadRequest();
        }
        [HttpDelete("{Id}")]
        public async Task DeleteAsync(int id)
        {
            await _aboutUsservice.RemoveAbout(id);
        }
    }
}
