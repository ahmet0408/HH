using HH.bll.DTOs.AboutUsDTO;
using HH.bll.Services.AboutUsService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HH.web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutUsController : ControllerBase
    {
        private readonly IAboutUsService _aboutUsservice;
        public AboutUsController(IAboutUsService aboutUsService)
        {
            _aboutUsservice = aboutUsService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            AboutUsDTO result = await _aboutUsservice.GetAboutUs();
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
        [HttpPut]
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
