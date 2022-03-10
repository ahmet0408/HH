using HH.bll.DTOs.MissionDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.Services.MissionService
{
    public interface IMissionService
    {
        Task<EditMissionDTO> GetMissionForEditById(int id);
        Task CreateMission(CreateMissionDTO modelDTO);
        Task EditMission(EditMissionDTO modelDTO);
        Task RemoveMission(int id);
        IEnumerable<MissionDTO> GetAllPublishMission();
        IEnumerable<Mission> GetAllMission();
    }
}
