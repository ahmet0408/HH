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
