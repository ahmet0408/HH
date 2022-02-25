using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
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
    public class MissionAPIController : ControllerBase
    {
        private readonly IMissionService _missionService;

        public MissionAPIController(IMissionService missionService)
        {
            _missionService = missionService;
        }
        [HttpGet("GetAllMission")]
        public object GetAllNews(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load<Mission>(_missionService.GetAllMission().AsQueryable(), loadOptions);

        }
        //api/MissionAPI
        [HttpGet]
        public object Get()
        {
            return (_missionService.GetAllPublishMission().AsQueryable());
        }
        //api/MissionAPI
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
        //api/MissionAPI/1
        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(EditMissionDTO value)
        {
            if (ModelState.IsValid)
            {
                await _missionService.EditMission(value);
                return Ok(value);
            }
            return BadRequest();
        }
        //api/MissionAPI/1
        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id)
        {
            await _missionService.RemoveMission(id);
        }

    }
}
