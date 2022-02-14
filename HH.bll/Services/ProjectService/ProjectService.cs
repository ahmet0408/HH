using AutoMapper;
using HH.bll.DTOs.ProjectDTO;
using HH.dal.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.Services.ProjectService
{
    public class ProjectService: IProjectService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        public ProjectService(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task CreateStatus(CreateStatusDTO modelDTO)
        {
            dal.Models.Project.Status status = _mapper.Map<dal.Models.Project.Status>(modelDTO);
            await _dbContext.Status.AddAsync(status);
            await _dbContext.SaveChangesAsync();
        }
        public async Task RemoveStatus(int id)
        {
            dal.Models.Project.Status status = await _dbContext.Status.FindAsync(id);
            _dbContext.Status.Remove(status);
        }
        public async Task CreateLocation(CreateLocationDTO modelDTO)
        {
            dal.Models.Project.Location location = _mapper.Map<dal.Models.Project.Location>(modelDTO);
            await _dbContext.Location.AddAsync(location);
            await _dbContext.SaveChangesAsync();
        }
        public async Task RemoveLocation(int id)
        {
            dal.Models.Project.Location location = await _dbContext.Location.FindAsync(id);
            _dbContext.Location.Remove(location);
            await _dbContext.SaveChangesAsync();
        }
        public async Task CreateProject(CreateProjectDTO modelDTO)
        {
            var client = _dbContext.Client.Where(p => p.Name == modelDTO.Client).FirstOrDefault();
            var status = _dbContext.StatusTranslates.Where(p => p.Name == modelDTO.Status).FirstOrDefault();
            var location = _dbContext.LocationTranslates.Where(p => p.Name == modelDTO.Location).FirstOrDefault();
            modelDTO.ClientId = client.Id;
            modelDTO.StatusId = status.StatusId;
            modelDTO.LocationId = location.LocationId;


            dal.Models.Project.Project project = _mapper.Map<dal.Models.Project.Project>(modelDTO);
             
            await _dbContext.Project.AddAsync(project);
            await _dbContext.SaveChangesAsync();
        }
        public async Task RemoveProject(int id)
        {
            dal.Models.Project.Project project = await _dbContext.Project.FindAsync(id);
            _dbContext.Project.Remove(project);
            await _dbContext.SaveChangesAsync();
        }
        public IEnumerable<ProjectDTO> GetAllPublishProject()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var project = _dbContext.Project.Where(p => p.IsPublish == true).Include(p => p.ProjectTranslates.Where(p => p.LanguageCulture == culture));
            var result = _mapper.Map<IEnumerable<ProjectDTO>>(project);
            return result;
        }
        public async Task<ProjectDetailDTO> GetProductDetaildById(int id)
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var clientId = await _dbContext.Project.Select(p => p.ClientId).FirstOrDefaultAsync();
            var client = await _dbContext.Client.Where(p => p.Id == clientId).FirstOrDefaultAsync();
            var statusId = await _dbContext.Project.Select(p => p.StatusId).FirstOrDefaultAsync();
            var status = await _dbContext.StatusTranslates.Where(p => p.LanguageCulture == culture).FirstOrDefaultAsync(p => p.StatusId == statusId);
            var locationId = await _dbContext.Project.Select(p => p.LocationId).FirstOrDefaultAsync();
            var location = await _dbContext.LocationTranslates.Where(p => p.LanguageCulture == culture).FirstOrDefaultAsync(p => p.LocationId == locationId);
            var project = await _dbContext.Project.FindAsync(id);
            var translate = await _dbContext.ProjectTranslates.Where(p => p.LanguageCulture == culture).SingleOrDefaultAsync(p => p.ProjectId == id);
            ProjectDetailDTO result = new()
            {
                Title = translate.Title,
                Image = project.Image,
                Description = translate.Description,
                StartDate = project.StartDate,
                EndDate = project.EndDate,
                Client = client.Name,
                Status = status.Name,
                Location = location.Name
            };
            return result;
        }
    }
}
