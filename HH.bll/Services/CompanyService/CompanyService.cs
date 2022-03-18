using AutoMapper;
using HH.bll.DTOs.CompanyDTO;
using HH.bll.Services.ImageService;
using HH.web.Data;
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
                    _imageService.DeleteImage(modelDTO.Image, "news");
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
        public async Task CreateLicense(CreateLicenseDTO modelDTO)
        {
            if (modelDTO != null)
            {
                dal.Models.Company.License license= _mapper.Map<dal.Models.Company.License>(modelDTO);
                if (modelDTO.FormFile != null)
                {
                    license.File = await _imageService.UploadImage(modelDTO.FormFile, "license");
                }
                await _dbContext.License.AddAsync(license);
                await _dbContext.SaveChangesAsync();
            }
        }
        public async Task EditLicense(EditLicenseDTO modelDTO)
        {
            if (modelDTO != null)
            {
                dal.Models.Company.License license = _mapper.Map<dal.Models.Company.License>(modelDTO);
                if (modelDTO.FormFile != null)
                {
                    _imageService.DeleteImage(modelDTO.File, "license");
                    license.File = await _imageService.UploadImage(modelDTO.FormFile, "license");

                }
                _dbContext.License.Update(license);
                await _dbContext.SaveChangesAsync();
            }

        }
        public async Task RemoveLicense(int id)
        {
            dal.Models.Company.License license = await _dbContext.License.FindAsync(id);
            if (!string.IsNullOrEmpty(license.File))
            {
                _imageService.DeleteImage(license.File, "license");
            }
            _dbContext.License.Remove(license);
            await _dbContext.SaveChangesAsync();
        }
        public IEnumerable<News> GetAllNews()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var news = _dbContext.News.Include(p => p.NewsTranslates.Where(p => p.LanguageCulture == culture));
            var result = _mapper.Map<IEnumerable<News>>(news);
            return result;
        }
        public IEnumerable<License> GetAllLicense()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var license = _dbContext.License.Include(p => p.LicenseTranslates.Where(p => p.LanguageCulture == culture));
            var result = _mapper.Map<IEnumerable<License>>(license);
            return result;
        }
        public async Task<EditNewsDTO> GetNewsForEditById(int id)
        {
            var news = await _dbContext.News.Include(p => p.NewsTranslates).SingleOrDefaultAsync(p => p.Id == id);
            EditNewsDTO editNewsDTO = _mapper.Map<EditNewsDTO>(news);
            return editNewsDTO;
        }
        public async Task<EditLicenseDTO> GetLicenseForEditById(int id)
        {
            var license = await _dbContext.License.Include(p => p.LicenseTranslates).SingleOrDefaultAsync(p => p.Id == id);
            EditLicenseDTO editLicenseDTO = _mapper.Map<EditLicenseDTO>(license);
            return editLicenseDTO;
        }
        public IEnumerable<NewsDTO> GetAllPublishNews()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var news = _dbContext.News.Include(p => p.NewsTranslates.Where(p=>p.LanguageCulture == culture))
                                                    .Where(p =>( p.IsPublish == true) && 
                                                    (p.NewsTranslates.Any(p=>p.LanguageCulture == culture)));
            var result = _mapper.Map<IEnumerable<NewsDTO>>(news);
            return result;
        }
        public IEnumerable<License> GetAllPublishLicense()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var license = _dbContext.License.Where(p => p.IsPublish == true).Include(p => p.LicenseTranslates.Where(p => p.LanguageCulture == culture));                                
            var result = _mapper.Map<IEnumerable<License>>(license);
            return result;
        }
        public async Task<NewsDetailDTO> GetNewsPage(int id)
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var news = await _dbContext.News.Where(p => p.IsPublish == true).Include(p => p.NewsTranslates.Where(p => p.LanguageCulture == culture)).SingleOrDefaultAsync(p => p.Id == id);
            NewsDetailDTO result = _mapper.Map<NewsDetailDTO>(news);
            return result;
        }
    }
}
