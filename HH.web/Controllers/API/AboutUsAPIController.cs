using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using HH.bll.DTOs.AboutUsDTO;
using HH.bll.Services.AboutUsService;
using HH.dal.Models.AboutUs;
using Microsoft.AspNetCore.Cors;
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

        [HttpGet("GetAllAbout")]
        public object GetAllbout(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load<About>(_aboutUsservice.GetAllAbout().AsQueryable(), loadOptions);

        }
        [HttpGet("GetMainAboutUs")]
        public async Task<IActionResult> GetMainAboutUs()
        {
            AboutUsDTO result = await _aboutUsservice.GetAboutUs();
            return Ok(result);
            
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
        //POST: api/AboutUsAPI
        [HttpPost]
        public async Task<IActionResult> Post([FromForm] CreateAboutUsDTO value)
        {
            if (ModelState.IsValid)
            {
                await _aboutUsservice.CreateAbout(value);
                return Ok(value);
            }
            return BadRequest();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromBody] EditAboutUsDTO value)
        {
            if (ModelState.IsValid)
            {
                await _aboutUsservice.EditAbout(value);
                return Ok(value);
            }
            return BadRequest();
        }
        [HttpDelete("GetAllAbout/{id}")]
        public async Task DeleteAsync(int id)
        {
            await _aboutUsservice.RemoveAbout(id);
        }
    }
}
