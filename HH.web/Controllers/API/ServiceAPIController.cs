using HH.bll.DTOs.ServicesDTO;
using HH.bll.Services.ServiceService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace HH.web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceAPIController : ControllerBase
    {
        private readonly IServiceService _service;

        public ServiceAPIController(IServiceService service)
        {
            _service = service;
        }
        [HttpGet("GetAllPublishServiceDTO")]
        public object GetAllPublishServiceDTO()
        {
            return (_service.GetAllPublishServiceDTO().AsQueryable());  
        }
        [HttpGet("GetByIdServiceDetailDTO/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            ServiceDetailDTO result = await _service.GetByIdServiceDetailDTO(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateServiceDTO value)
        {
            if (ModelState.IsValid)
            {
                await _service.CreateService(value);
                return Ok(value);
            }
            return BadRequest();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(EditServiceDTO value)
        {
            if (ModelState.IsValid)
            {
                await _service.EditService(value);
                return Ok(value);
            }
            return BadRequest();
        }
        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id)
        {
            await _service.RemoveService(id);
        }
     }
}
