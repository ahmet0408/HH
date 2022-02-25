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
        // GET: api/ServiceAPI/GetAllPublishService
        [HttpGet("GetAllPublishService")]
        public object GetAll()
        {
            return (_service.GetAllPublishService().AsQueryable());  
        }
        //GET: api/ServiceAPI/GetServiceDetailById/1
        [HttpGet("GetServiceDetailById/{id}")]
        public async Task<ServiceDetailDTO> Get(int id)
        {
            ServiceDetailDTO result = await _service.GetServiceDetailById(id);
            return result;
        }
        //GET: api/ServiceAPI/GetAllServiceForProduct
        [HttpGet("GetAllServiceForProduct")]
        public object GetAllService()
        {
            return _service.GetAllService().AsQueryable();
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
