using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
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
        [HttpGet("GetAllService")]
        public object GetAllService(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load<Service>(_service.GetAllService().AsQueryable(), loadOptions);
        }
        // GET: api/ServiceAPI/GetAllPublishService
        [HttpGet("GetAllPublishService")]
        public IActionResult GetAll()
        {
            var result = _service.GetAllPublishService();
            return Ok(result);
        }
        //GET: api/ServiceAPI/GetServiceDetailById/1
        [HttpGet("GetServiceDetailById/{id}")]
        public IActionResult Get(int id)
        {
            var result = _service.GetServiceDetailById(id);
            return Ok(result);
        }
        //GET: api/ServiceAPI/GetAllServiceForProduct
        [HttpGet("GetAllServiceForProduct")]
        public IActionResult GetAllServiceForProduct()
        {
            var result = _service.ProductAndService();
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
        [HttpDelete("GetAllService/{id}")]
        public async Task DeleteAsync(int id)
        {
            await _service.RemoveService(id);
        }
     }
}
