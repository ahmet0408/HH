using AutoMapper;
using HH.bll.DTOs.BannerDTO;
using HH.dal.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.Services.BannerService
{
    public class BannerService: IBannerService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        public BannerService(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task CreateBanner(CreateBannerDTO modelDTO)
        {
            dal.Models.Banner.Banner banner = _mapper.Map<dal.Models.Banner.Banner>(modelDTO);
            await _dbContext.Banner.AddAsync(banner);
            await _dbContext.SaveChangesAsync();
        }
        public async Task RemoveBanner(int id)
        {
            dal.Models.Banner.Banner banner =await _dbContext.Banner.FindAsync(id);
            _dbContext.Banner.Remove(banner);
            await _dbContext.SaveChangesAsync();
        }
        public BannerDTO GetBanner()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var banner = _dbContext.Banner.Include(p => p.BannerTranslates.Where(p => p.LanguageCulture == culture)).FirstOrDefault(p => p.IsPublish == true)   ;
            BannerDTO result = _mapper.Map<BannerDTO>(banner);
            return result;
        }
    }
}
