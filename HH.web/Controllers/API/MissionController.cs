using HH.bll.DTOs.MissionDTO;
using HH.bll.Services.MissionService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace HH.web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class MissionController : ControllerBase
    {
        private readonly IMissionService _missionService;

        public MissionController(IMissionService missionService)
        {
            _missionService = missionService;
        }
        [HttpGet]
        public object Get()
        {
            return (_missionService.GetAllPublishMission().AsQueryable());
        }
        [HttpPost]
        public async Task<IActionResult> Post(CreateMissionDTO value)
        {
            if (ModelState.IsValid)
            {
                await _missionService.CreateMission(value);
                return Ok(value);
            }
            return BadRequest();
        }
        [HttpPut]
        public async Task<IActionResult> Edit(EditMissionDTO value)
        {
            if (ModelState.IsValid)
            {
                await _missionService.EditMission(value);
                return Ok(value);
            }
            return BadRequest();
        }
        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id)
        {
            await _missionService.RemoveMission(id);
        }

    }
}
