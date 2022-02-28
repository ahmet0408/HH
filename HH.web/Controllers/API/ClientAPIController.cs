using HH.bll.DTOs.ClientDTO;
using HH.bll.Services.ClientService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace HH.web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientAPIController : ControllerBase
    {
        private readonly IClientService _clientService;
        public ClientAPIController(IClientService clientService)
        {
            _clientService = clientService;
        }
        //GET: api/ClientAPI
        [HttpGet]
        public object Get()
        {
            return _clientService.GetAllClient().AsQueryable();
        }
        [HttpGet("GetAllClientButThis/{id}")]
        public object GetAllClientButThis(int id)
        {
            return _clientService.GetAllClientButThis(id).AsQueryable();
        }
        //POST: api/ClientAPI
        [HttpPost]
        public async Task<IActionResult> Post(CreateClientDTO value)
        {
            if (ModelState.IsValid)
            {
                await _clientService.CreatClient(value);
                return Ok(value);
            }
            return BadRequest();
        }
        //PUT: api/ClientAPI/1
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(EditClientDTO value)
        {
            if (ModelState.IsValid)
            {
                await _clientService.EditClient(value);
                return Ok(value);
            }
            return BadRequest();
        }
        //DELETE: api/ClientAPI/1
        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id)
        {
            await _clientService.RemoveClient(id);
        }
    }
}
