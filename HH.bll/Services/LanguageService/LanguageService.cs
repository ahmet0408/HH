using AutoMapper;
using HH.bll.DTOs.LanguageDTO;
using HH.dal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.Services.LanguageService
{
    public class LanguageService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        public LanguageService(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task CreateLanguage(CreateLanguageDTO modelDTO)
        {
            dal.Models.Language.Language lng = _mapper.Map<dal.Models.Language.Language>(modelDTO);
            //if (lng.DisplayOrder == null)
            //{
            //    lng.DisplayOrder = 0;
            //}
            await _dbContext.Languages.AddAsync(lng);
            await _dbContext.SaveChangesAsync();
        }
        public async Task EditLanguage(LanguageDTO modelDTO)
        {
            dal.Models.Language.Language lng = _mapper.Map<dal.Models.Language.Language>(modelDTO);
            _dbContext.Languages.Update(lng);
            await _dbContext.SaveChangesAsync();
        }
        public IEnumerable<LanguageDTO> GetAllLanguage()
        {
            var languageDTOs = _mapper.Map<IEnumerable<dal.Models.Language.Language>, IEnumerable<LanguageDTO>>(GetList());
            return languageDTOs;
        }

        public IEnumerable<LanguageDTO> GetAllPublishLanguage()
        {
            var languageDTOs = _mapper.Map<IEnumerable<dal.Models.Language.Language>, IEnumerable<LanguageDTO>>(GetList().Where(p => p.IsPublish == true));
            return languageDTOs;
        }

        public IEnumerable<dal.Models.Language.Language> GetList()
        {
            var languages = _dbContext.Languages.ToList();
            return languages;
        }
        public async Task RemoveLanguage(int id)
        {
            dal.Models.Language.Language lng = await _dbContext.Languages.FindAsync(id);
            _dbContext.Languages.Remove(lng);
            await _dbContext.SaveChangesAsync();
        }
    }
}
