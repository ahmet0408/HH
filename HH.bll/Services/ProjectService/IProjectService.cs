using HH.bll.DTOs.ProjectDTO;
using HH.dal.Models.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.Services.ProjectService
{
    public interface IProjectService
    {
        IEnumerable<bll.DTOs.ProjectDTO.Project> GetAllProjectButThis(int id);
        Task<EditProjectDTO> GetProjectForEditById(int id);
        Task<EditLocationDTO> GetLocationForEditById(int id);
        IEnumerable<LocationDTO> GetAllLocationButThis(int id);
        IEnumerable<StatusDTO> GetAllStatusButThis(int id);
        Task<EditStatusDTO> GetStatusForEditById(int id);
        IEnumerable<DTOs.ProjectDTO.Project> GetAlllProject();
        IEnumerable<LocationDTO> GetAlllLocation();
        IEnumerable<StatusDTO> GetAlllStatus();
        Task CreateStatus(CreateStatusDTO modelDTO);
        Task EditStatus(EditStatusDTO modelDTO);
        Task RemoveStatus(int id);
        Task CreateLocation(CreateLocationDTO modelDTO);
        Task EditLocation(EditLocationDTO modelDTO);
        Task RemoveLocation(int id);
        Task CreateProject(CreateProjectDTO modelDTO);
        Task RemoveProject(int id);
        IEnumerable<StatusTranslate> GetAll();
        IEnumerable<LocationTranslate> GetAllLocation();
        IEnumerable<ProjectDTO> GetAllPublishProject();
        Task<ProjectDetailDTO> GetProjectPageById(int id);
    }
}
