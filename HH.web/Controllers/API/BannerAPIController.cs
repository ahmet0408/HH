using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using HH.bll.DTOs.BannerDTO;
using HH.bll.Services.BannerService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace HH.web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannerAPIController : ControllerBase
    {
        private readonly IBannerService _bannerService;

        public BannerAPIController(IBannerService bannerService)
        {
            _bannerService = bannerService;
        }
        [HttpGet("GetAllBanner")]
        public object GetAllBanner(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load<Banner>(_bannerService.GetAllBanner().AsQueryable(), loadOptions);

        }
        //api/BannerAPI
        [HttpGet]
        public BannerDTO Get()
        {
            return _bannerService.GetBanner();
        }
        [HttpGet("GetAllBannerButThis/{id}")]
        public object GetAllAboutButThis(int id)
        {
            return _bannerService.GetAllBannerButThis(id).AsQueryable();
        }
        
        //api/BannerAPI
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
        //api/BannerAPI/1
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
        //api/BannerAPI/2
        [HttpDelete("GetAllBanner/{id}")]
        public async Task DeleteAsync(int id)
        {
            await _bannerService.RemoveBanner(id);
        }
    }
}
