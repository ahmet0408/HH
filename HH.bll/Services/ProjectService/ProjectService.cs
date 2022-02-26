using AutoMapper;
using HH.bll.DTOs.ProjectDTO;
using HH.bll.Services.ImageService;
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
        private readonly IImageService _imageService;
        public ProjectService(ApplicationDbContext dbContext, IMapper mapper, IImageService imageService)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _imageService = imageService;
        }
        public IEnumerable<Project> GetAlllProject()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var project = _dbContext.Project.Include(p => p.ProjectTranslates.Where(p => p.LanguageCulture == culture))
                .Include(p => p.Client).Where(p => p.ClientId == p.Client.Id)
                .Include(p => p.Location)
                    .ThenInclude(p => p.LocationTranslates.Where(p => p.LanguageCulture == culture))
                .Where(p => p.LocationId == p.Location.Id)
                .Include(p => p.Status)
                    .ThenInclude(p => p.StatusTranslates.Where(p => p.LanguageCulture == culture))
                .Where(p => p.StatusId == p.StatusId);
            var result = _mapper.Map<IEnumerable<Project>>(project);
            return result;
        }
                
        public IEnumerable<LocationDTO> GetAlllLocation()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var location = _dbContext.Location.Include(p => p.LocationTranslates.Where(p => p.LanguageCulture == culture));
            var result = _mapper.Map<IEnumerable<LocationDTO>>(location);
            return result;
        }
        public IEnumerable<StatusDTO> GetAlllStatus()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var status = _dbContext.Status.Include(p => p.StatusTranslates.Where(p => p.LanguageCulture == culture));
            var result = _mapper.Map<IEnumerable<StatusDTO>>(status);
            return result;
        }
        public async Task CreateStatus(CreateStatusDTO modelDTO)
        {
            dal.Models.Project.Status status = _mapper.Map<dal.Models.Project.Status>(modelDTO);
            await _dbContext.Status.AddAsync(status);
            await _dbContext.SaveChangesAsync();
        }
        public async Task EditStatus(EditStatusDTO modelDTO)
        {
            dal.Models.Project.Status status = _mapper.Map<dal.Models.Project.Status>(modelDTO);
            _dbContext.Status.Update(status);
            await _dbContext.SaveChangesAsync();
        }
        public async Task RemoveStatus(int id)
        {
            dal.Models.Project.Status status = await _dbContext.Status.FindAsync(id);
            _dbContext.Status.Remove(status);
            await _dbContext.SaveChangesAsync();
        }
        public async Task CreateLocation(CreateLocationDTO modelDTO)
        {
            dal.Models.Project.Location location = _mapper.Map<dal.Models.Project.Location>(modelDTO);
            await _dbContext.Location.AddAsync(location);
            await _dbContext.SaveChangesAsync();
        }
        public async Task EditLocation(EditLocationDTO modelDTO)
        {
            dal.Models.Project.Location location = _mapper.Map<dal.Models.Project.Location>(modelDTO);
            _dbContext.Location.Update(location);
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
            if (modelDTO != null)
            {
                var client = _dbContext.Client.Where(p => p.Name == modelDTO.Clientt).FirstOrDefault();
                var status = _dbContext.StatusTranslates.Where(p => p.Name == modelDTO.Statuss).FirstOrDefault();
                var location = _dbContext.LocationTranslates.Where(p => p.Name == modelDTO.Locationn).FirstOrDefault();
                modelDTO.ClientId = client.Id;
                modelDTO.StatusId = status.StatusId;
                modelDTO.LocationId = location.LocationId;
                dal.Models.Project.Project project = _mapper.Map<dal.Models.Project.Project>(modelDTO);
                if (modelDTO.FormImage != null)
                {
                    project.Image = await _imageService.UploadImage(modelDTO.FormImage, "project");
                }
                await _dbContext.Project.AddAsync(project);
                await _dbContext.SaveChangesAsync();
            }
        }
        public async Task RemoveProject(int id)
        {
            dal.Models.Project.Project project = await _dbContext.Project.FindAsync(id);
            if (!string.IsNullOrEmpty(project.Image))
            {
                _imageService.DeleteImage(project.Image, "project");
            }
            _dbContext.Project.Remove(project);
            await _dbContext.SaveChangesAsync();
        }
        public IEnumerable<dal.Models.Project.StatusTranslate> GetAll()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var status = _dbContext.StatusTranslates.Where(p => p.LanguageCulture == culture);
            return status;
        }
        public IEnumerable<dal.Models.Project.LocationTranslate> GetAllLocation()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName; 
            var location = _dbContext.LocationTranslates.Where(p => p.LanguageCulture == culture).Where(p => p.LocationId == p.Location.Id && p.Location.IsPublish == true);
            return location;
        }
        public IEnumerable<ProjectDTO> GetAllPublishProject()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var project = _dbContext.Project.Where(p => p.IsPublish == true).Include(p => p.ProjectTranslates.Where(p => p.LanguageCulture == culture));
            var result = _mapper.Map<IEnumerable<ProjectDTO>>(project);
            return result;
        }
        public async Task<ProjectDetailDTO> GetProjectPageById(int id)
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var project = await _dbContext.Project.Where(p => p.IsPublish == true).Include(p => p.ProjectTranslates.Where(p => p.LanguageCulture == culture))
                .Include(p => p.Client)
                .Include(p => p.Status)
                    .ThenInclude(p => p.StatusTranslates.Where(p => p.LanguageCulture == culture))
                .Include(p => p.Location)
                    .ThenInclude(p => p.LocationTranslates.Where(p => p.LanguageCulture == culture))
                .Where(p => p.ClientId == p.Client.Id && p.LocationId == p.Location.Id && p.StatusId == p.Status.Id).SingleOrDefaultAsync(p => p.Id == id);
            ProjectDetailDTO result = _mapper.Map<ProjectDetailDTO>(project);
            return result;
        }
    }
}
