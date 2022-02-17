using HH.bll.DTOs.BannerDTO;
using HH.bll.Services.BannerService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HH.web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannerController : ControllerBase
    {
        private readonly IBannerService _bannerService;

        public BannerController(IBannerService bannerService)
        {
            _bannerService = bannerService;
        }
        [HttpGet]
        public BannerDTO Get()
        {
            return (_bannerService.GetBanner());
        }
        [HttpPost]
        public async Task<IActionResult> Post(CreateBannerDTO value)
        {
            if (ModelState.IsValid)
            {
                await _bannerService.CreateBanner(value);
                return Ok(value);
            }
            return BadRequest();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(EditBannerDTO value)
        {
            if (ModelState.IsValid)
            {
                await _bannerService.EditBanner(value);
                return Ok(value);
            }
            return BadRequest();
        }
        [HttpDelete]
        public async Task DeleteAsync(int id)
        {
            await _bannerService.RemoveBanner(id);
        }
    }
}
