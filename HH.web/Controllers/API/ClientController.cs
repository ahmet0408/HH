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
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;
        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }
        [HttpGet]
        public object Get()
        {
            return (_clientService.GetAllClient().AsQueryable());
        }
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
        [HttpPut]
        public async Task<IActionResult> Put(EditClientDTO value)
        {
            if (ModelState.IsValid)
            {
                await _clientService.EditClient(value);
                return Ok(value);
            }
            return BadRequest();
        }
        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id)
        {
            await _clientService.RemoveClient(id);
        }
    }
}
