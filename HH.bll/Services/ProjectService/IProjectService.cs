using HH.bll.DTOs.ProjectDTO;
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
        Task RemoveStatus(int id);
        Task CreateLocation(CreateLocationDTO modelDTO);
        Task RemoveLocation(int id);
        Task CreateProject(CreateProjectDTO modelDTO);
        Task RemoveProject(int id);
        IEnumerable<ProjectDTO> GetAllPublishProject();
        Task<ProjectDetailDTO> GetProductDetaildById(int id);
    }
}
