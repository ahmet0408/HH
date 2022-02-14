using AutoMapper;
using HH.bll.DTOs.MissionDTO;
using HH.dal.Data;
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
        private readonly IMapper _mapper;

        public MissionService(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task CreateMission(CreateMissionDTO modelDTO)
        {
            dal.Models.Mission.Mission mission = _mapper.Map<dal.Models.Mission.Mission>(modelDTO);
            await _dbContext.Mission.AddAsync(mission);
            await _dbContext.SaveChangesAsync();
        }
        public async Task EditMission(EditMissionDTO modelDTO)
        {
            dal.Models.Mission.Mission mission = _mapper.Map<dal.Models.Mission.Mission>(modelDTO);
            _dbContext.Mission.Update(mission);
            await _dbContext.SaveChangesAsync();
        }
        public async Task RemoveMission(int id)
        {
            dal.Models.Mission.Mission mission = await _dbContext.Mission.FindAsync(id);
            _dbContext.Mission.Remove(mission);
            await _dbContext.SaveChangesAsync();
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
