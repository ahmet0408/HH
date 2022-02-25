﻿using HH.bll.DTOs.ProjectDTO;
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
        //GET: api/ProjectAPI/GetStatus
        [HttpGet("GetStatus")]
        public object GetAll()
        {
            return _projectService.GetAll().AsQueryable();
        }
        //POST: api/ProjectAPI/CreateStatus
        [HttpPost("CreateStatus")]
        public async Task<IActionResult> CreateStatus(CreateStatusDTO value)
        {
            if (ModelState.IsValid)
            {
                await _projectService.CreateStatus(value);
                return Ok(value);
            }
            return BadRequest();
        }
        //PUT: api/ProjectAPI/EditStatus/1
        [HttpPut("EditStatus/{id}")]
        public async Task<IActionResult> EditStatus(EditStatusDTO value)
        {
            if (ModelState.IsValid)
            {
                await _projectService.EditStatus(value);
                return Ok(value);
            }
            return BadRequest();
        }
        //DELETE: api/ProjectAPI/RemoveStatus/1
        [HttpDelete("RemoveStatus/{id}")]
        public async Task RemoveStatus(int id)
        {
            await _projectService.RemoveStatus(id);
        }
        //GET: api/ProjectAPI/GetLocation
        [HttpGet("GetLocation")]
        public object GetAllLocation()
        {
            return _projectService.GetAllLocation().AsQueryable();
        }
        //POST: api/ProjectAPI/CreteLocation
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
        //DELETE: api/ProjectAPI/RemoveLocation/1
        [HttpDelete("RemoveLocation/{Id}")]
        public async Task RemoveLocation(int id)
        {
            await _projectService.RemoveLocation(id);
        }
        //GET: api/ProjectAPI/
        [HttpGet]
        public object Get()
        {
            return _projectService.GetAllPublishProject().AsQueryable();
        } 
        //GET: api/ProjectAPI/1
        [HttpGet("{id}")]
        public async Task<ProjectDetailDTO> GetProject(int id)
        {
            ProjectDetailDTO result =await _projectService.GetProjectPageById(id);
            return result;
        }
        //POST: api/ProjectAPI
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
        //DELETE: api/ProjectAPI/1
        [HttpDelete("{id}")]
        public async Task RemoveProject(int id)
        {
            await _projectService.RemoveProject(id);
        }


    }
}