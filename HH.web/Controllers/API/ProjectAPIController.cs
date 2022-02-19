using HH.bll.DTOs.ProjectDTO;
using HH.bll.Services.ProjectService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace HH.web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectAPIController : ControllerBase
    {
        private readonly IProjectService _projectService;
        public ProjectAPIController(IProjectService projectService)
        {
            _projectService = projectService;
        }
        [HttpPost("CreateStatus")]
        public async Task<IActionResult> Post(CreateStatusDTO value)
        {
            if (ModelState.IsValid)
            {
                await _projectService.CreateStatus(value);
                return Ok(value);
            }
            return BadRequest();
        }
        [HttpDelete("RemoveStatus/{id}")]
        public async Task RemoveStatus(int id)
        {
            await _projectService.RemoveStatus(id);
        }
        [HttpPost("CreateLocation")]
        public async Task<IActionResult> CreateLocation(CreateLocationDTO value)
        {
            if (ModelState.IsValid)
            {
                await _projectService.CreateLocation(value);
                return Ok(value);
            }
            return BadRequest();
        }
        [HttpDelete("RemoveLocation/{Id}")]
        public async Task RemoveLocation(int id)
        {
            await _projectService.RemoveLocation(id);
        }
        [HttpGet("GetAllPublishProject")]
        public object Get()
        {
            return _projectService.GetAllPublishProject().AsQueryable();
        } 
        [HttpGet("GetProjectDetailById/{id}")]
        public async Task<IActionResult> GetProjectDetailById(int id)
        {
            ProjectDetailDTO result =await _projectService.GetProductDetaildById(id);
            return Ok(result);
        }
        [HttpPost("CreateProject")]
        public async Task<IActionResult> CreateProject(CreateProjectDTO value)
        {
            if (ModelState.IsValid)
            {
                await _projectService.CreateProject(value);
                return Ok(value);
            }
            return BadRequest();
        }
        [HttpDelete("RemoveProject/{id}")]
        public async Task RemoveProject(int id)
        {
            await _projectService.RemoveProject(id);
        }


    }
}
