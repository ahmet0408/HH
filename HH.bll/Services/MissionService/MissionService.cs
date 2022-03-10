using AutoMapper;
using HH.bll.DTOs.MissionDTO;
using HH.bll.Services.ImageService;
using HH.web.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.Services.MissionService
{
    public class MissionService: IMissionService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IImageService _imageService;
        private readonly IMapper _mapper;

        public MissionService(ApplicationDbContext dbContext, IMapper mapper, IImageService imageService)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _imageService = imageService;
        }
        public async Task CreateMission(CreateMissionDTO modelDTO)
        {
            if (modelDTO != null)
            {
                dal.Models.Mission.Mission mission = _mapper.Map<dal.Models.Mission.Mission>(modelDTO);
                if (modelDTO.FormIcon != null)
                {
                    mission.Icon = await _imageService.UploadImage(modelDTO.FormIcon, "mission");
                }
                await _dbContext.Mission.AddAsync(mission);
                await _dbContext.SaveChangesAsync();
            }
            
        }
        public async Task EditMission(EditMissionDTO modelDTO)
        {
            if (modelDTO != null)
            {
                dal.Models.Mission.Mission mission = _mapper.Map<dal.Models.Mission.Mission>(modelDTO);
                if (modelDTO.FormIcon != null)
                {
                    _imageService.DeleteImage(modelDTO.Icon, "mission");
                    mission.Icon = await _imageService.UploadImage(modelDTO.FormIcon, "mission");
                } else
                {
                    mission.Icon = modelDTO.Icon;
                }
                _dbContext.Mission.Update(mission);
                await _dbContext.SaveChangesAsync();
            }
        }
        public async Task RemoveMission(int id)
        {
            dal.Models.Mission.Mission mission = await _dbContext.Mission.FindAsync(id);
            if (!string.IsNullOrEmpty(mission.Icon))
            {
                _imageService.DeleteImage(mission.Icon, "mission");
            }
            _dbContext.Mission.Remove(mission);
            await _dbContext.SaveChangesAsync();
        }
        public IEnumerable<Mission> GetAllMission()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var mission = _dbContext.Mission.Include(p => p.MissionTranslates.Where(p => p.LanguageCulture == culture));
            var result = _mapper.Map<IEnumerable<Mission>>(mission);
            return result;
        }
        public async Task<EditMissionDTO> GetMissionForEditById(int id)
        {
            var mission = await _dbContext.Mission.Include(p => p.MissionTranslates).SingleOrDefaultAsync(p => p.Id == id);
            EditMissionDTO editMissionDTO = _mapper.Map<EditMissionDTO>(mission);
            return editMissionDTO;
        }
        public IEnumerable<MissionDTO> GetAllPublishMission()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var mission = _dbContext.Mission.Where(p => p.IsPublish == true).Include(p => p.MissionTranslates.Where(p => p.LanguageCulture == culture));
            var result = _mapper.Map<IEnumerable<MissionDTO>>(mission);
            return result;
        }
    }
}
