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
        Task<EditProjectDTO> GetProjectForEditById(int id);
        Task<EditLocationDTO> GetLocationForEditById(int id);
        Task<EditStatusDTO> GetStatusForEditById(int id);
        IEnumerable<DTOs.ProjectDTO.Project> GetAllProject();
        Task CreateStatus(CreateStatusDTO modelDTO);
        Task EditStatus(EditStatusDTO modelDTO);
        Task RemoveStatus(int id);
        Task CreateLocation(CreateLocationDTO modelDTO);
        Task EditLocation(EditLocationDTO modelDTO);
        Task RemoveLocation(int id);
        Task CreateProject(CreateProjectDTO modelDTO);
        Task EditProject(EditProjectDTO modelDTO);
        Task RemoveProject(int id);
        public IEnumerable<Status> GetAllStatus();
        IEnumerable<Location> GetAllLocation();
        IEnumerable<ProjectDTO> GetAllPublishProject();
        Task<ProjectDetailDTO> GetProjectPageById(int id);
    }
}
