using AutoMapper;
using HH.bll.DTOs.CompanyDTO;
using HH.dal.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.Services.CompanyService
{
    public class CompanyService : ICompanyService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        public CompanyService(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task CreateNews(CreateNewsDTO modelDTO)
        {
            dal.Models.Company.News News = _mapper.Map<dal.Models.Company.News>(modelDTO);
            await _dbContext.News.AddAsync(News);
            await _dbContext.SaveChangesAsync();
        }
        public async Task EditNews(EditNewsDTO modelDTO)
        {
            dal.Models.Company.News News = _mapper.Map<dal.Models.Company.News>(modelDTO);
            _dbContext.News.Update(News);
            await _dbContext.SaveChangesAsync();
        }
        public async Task RemoveNews(int id)
        {
            dal.Models.Company.News News = await _dbContext.News.FindAsync(id);
            _dbContext.News.Remove(News);
            await _dbContext.SaveChangesAsync();
        } 
        public IEnumerable<NewsDTO> GetAllPublishListNews()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var news = _dbContext.News.Include(p => p.NewsTranslates.Where(p=>p.LanguageCulture == culture))
                                                    .Where(p =>( p.IsPublish == true) && 
                                                    (p.NewsTranslates.Any(p=>p.LanguageCulture == culture)));
            var result = _mapper.Map<IEnumerable<NewsDTO>>(news);
            return result;
        }
        public async Task<NewsDetailDTO> GetPublishNewsDetail(int id)
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var news = await _dbContext.News.FindAsync(id);
            var translate = await _dbContext.NewsTranslates
                .Where(p => p.LanguageCulture == culture).SingleOrDefaultAsync(p => p.NewsId == news.Id);
            NewsDetailDTO result = new()
            {
                Id = news.Id,
                Name = translate.Name,
                ShortDesc = translate.ShortDesc,
                Description = translate.Description,
                Image = news.Image
            };
            return result;
        }
    }
}
