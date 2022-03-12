using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using HH.bll.DTOs.ContactDTO;
using HH.bll.Services.ContactService;
using HH.dal.Models.Contact;
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
        [HttpGet("GetAllUser")]
        public object GetAllUser(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load<UserDTO>(_contactService.GetAllUser().AsQueryable(), loadOptions);
        }
        //POST:api/ContactAPI
        [HttpPost]
        public async Task<IActionResult> Post( [FromForm] CreateUserDTO value)
        {

            if (ModelState.IsValid)
            {
                await _contactService.CreateUser(value);
                return Ok(value);
            }
            return BadRequest();
        }
        //DELETE: api/ContactAPI/GetAllUser
        [HttpDelete("GetAllUser/{id}")]
        public async Task Delete(int id)
        {
            await _contactService.RemoveUser(id);
        }
    }
}
