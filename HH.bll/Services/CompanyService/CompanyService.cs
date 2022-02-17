using AutoMapper;
using HH.bll.DTOs.CompanyDTO;
using HH.bll.Services.ImageService;
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
        private readonly IImageService _imageService;
        public CompanyService(ApplicationDbContext dbContext, IMapper mapper, IImageService imageService)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _imageService = imageService;
        }
        public async Task CreateNews(CreateNewsDTO modelDTO)
        {
            if (modelDTO != null)
            {
                dal.Models.Company.News news = _mapper.Map<dal.Models.Company.News>(modelDTO);
                if (modelDTO.FormImage != null)
                {
                    news.Image = await _imageService.UploadImage(modelDTO.FormImage, "news");
                }
                await _dbContext.News.AddAsync(news);
                await _dbContext.SaveChangesAsync();
            }
            
        }
        public async Task EditNews(EditNewsDTO modelDTO)
        {
            if (modelDTO != null)
            {
                dal.Models.Company.News news = _mapper.Map<dal.Models.Company.News>(modelDTO);
                if (modelDTO.FormImage != null)
                {
                    _imageService.DeleteImage(news.Image, "news");
                    news.Image = await _imageService.UploadImage(modelDTO.FormImage, "news");
                  
                }
                _dbContext.News.Update(news);
                await _dbContext.SaveChangesAsync();
            }
            
        }
        public async Task RemoveNews(int id)
        {
            dal.Models.Company.News news = await _dbContext.News.FindAsync(id);
            if (!string.IsNullOrEmpty(news.Image))
            {
                _imageService.DeleteImage(news.Image, "news");
            }
            _dbContext.News.Remove(news);
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
