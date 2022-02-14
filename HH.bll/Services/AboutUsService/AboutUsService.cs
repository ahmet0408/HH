using AutoMapper;
using HH.bll.DTOs.AboutUsDTO;
using HH.dal.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.Services.AboutUsService
{
    public class AboutUsService: IAboutUsService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        public AboutUsService(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task CreateAbout(CreateAboutUsDTO modelDTO)
        {
            dal.Models.AboutUs.AboutUs aboutUs = _mapper.Map<dal.Models.AboutUs.AboutUs>(modelDTO);
            await _dbContext.AddAsync(aboutUs);
            await _dbContext.SaveChangesAsync();
        }
        public async Task EditAbout(EditAboutUsDTO modelDTO)
        {
            dal.Models.AboutUs.AboutUs aboutUs = _mapper.Map<dal.Models.AboutUs.AboutUs>(modelDTO);
            _dbContext.Update(aboutUs);
            await _dbContext.SaveChangesAsync();
        }
        public async Task RemoveAbout(int id)
        {
            dal.Models.AboutUs.AboutUs aboutUs = await _dbContext.AboutUs.FindAsync(id);
            _dbContext.AboutUs.Remove(aboutUs);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<AboutUsDTO> GetAboutUs()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var aboutUs =await _dbContext.AboutUs.Where(p => p.IsPublish == true).Include(p => p.AboutUsTranslates.Where(p => p.LanguageCulture == culture)).FirstOrDefaultAsync();
            AboutUsDTO result = _mapper.Map<AboutUsDTO>(aboutUs);
            return result;
        }
    }
}
