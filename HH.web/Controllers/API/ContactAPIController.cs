using HH.bll.DTOs.ContactDTO;
using HH.bll.Services.ContactService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace HH.web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactAPIController : ControllerBase
    {
        private readonly IContactService _contactService;
        public ContactAPIController(IContactService contactService)
        {
            _contactService = contactService;
        }
        [HttpGet]
        public object Get()
        {
            return (_contactService.GetAllUser().AsQueryable());
        }
        [HttpPost]
        public async Task<IActionResult> Post(CreateUserDTO value)
        {
            if (ModelState.IsValid)
            {
                await _contactService.CreateUser(value);
                return Ok(value);
            }
            return BadRequest();
        }
    }
}
