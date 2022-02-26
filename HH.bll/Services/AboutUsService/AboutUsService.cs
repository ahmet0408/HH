using AutoMapper;
using HH.bll.DTOs.AboutUsDTO;
using HH.bll.Services.ImageService;
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
        private readonly IImageService _imageService;
        public static string FilePath { get; } = "aboutUs";
        public AboutUsService(ApplicationDbContext dbContext, IMapper mapper, IImageService imageService)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _imageService = imageService;
        }
        public IEnumerable<About> GetAllAbout()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var about = _dbContext.AboutUs.Include(p => p.AboutUsTranslates.Where(p => p.LanguageCulture == culture));
            var result = _mapper.Map<IEnumerable<About>>(about);
            return result;
        }
        public async Task CreateAbout(CreateAboutUsDTO modelDTO)
        {
            if (modelDTO != null)
            {
                dal.Models.AboutUs.AboutUs aboutUs = _mapper.Map<dal.Models.AboutUs.AboutUs>(modelDTO);
                if (modelDTO.FormMainImage != null) 
                {
                    aboutUs.MainImage = await _imageService.UploadImage(modelDTO.FormMainImage, FilePath);
                }
                if (modelDTO.FormImage != null)
                {
                    aboutUs.Image = await _imageService.UploadImage(modelDTO.FormImage, FilePath);
                }
                await _dbContext.AboutUs.AddAsync(aboutUs);
                await _dbContext.SaveChangesAsync();
            }
        }
        public async Task EditAbout(EditAboutUsDTO modelDTO)
        {
            dal.Models.AboutUs.AboutUs aboutUs = _mapper.Map<dal.Models.AboutUs.AboutUs>(modelDTO);
            if (modelDTO != null)
            {
                if (modelDTO.FormImage != null)
                {
                    _imageService.DeleteImage(modelDTO.Image, FilePath);
                    await _imageService.UploadImage(modelDTO.FormImage, FilePath);
                }
                else
                {
                    aboutUs.Image = modelDTO.Image;
                }
                _dbContext.AboutUs.Update(aboutUs);
                await _dbContext.SaveChangesAsync();
            }
        }
        public async Task RemoveAbout(int id)
        {
            dal.Models.AboutUs.AboutUs aboutUs = await _dbContext.AboutUs.FindAsync(id);
            if (!string.IsNullOrEmpty(aboutUs.Image))
            {
                _imageService.DeleteImage(aboutUs.Image, FilePath);
            }
            _dbContext.AboutUs.Remove(aboutUs);
            await _dbContext.SaveChangesAsync();
        }
        public AboutUsDTO GetAboutUs()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var aboutUs =_dbContext.AboutUs.Where(p => p.IsPublish == true).Include(p => p.AboutUsTranslates.Where(p => p.LanguageCulture == culture)).FirstOrDefault();
            var result = _mapper.Map<AboutUsDTO>(aboutUs);
            return result;
        }
        public async Task<AboutUsDetailDTO> GetAboutUsDetail()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var aboutUs = await _dbContext.AboutUs.Where(p => p.IsPublish == true).Include(p => p.AboutUsTranslates.Where(p => p.LanguageCulture == culture)).SingleOrDefaultAsync();
            AboutUsDetailDTO result = _mapper.Map<AboutUsDetailDTO>(aboutUs);
            return result;
        }
        public async Task<FooterDTO> GetFooter()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var footer = await _dbContext.AboutUs.Where(p => p.IsPublish == true).Include(p => p.AboutUsTranslates.Where(p => p.LanguageCulture == culture)).SingleOrDefaultAsync();
            FooterDTO result = _mapper.Map<FooterDTO>(footer);
            return result;
        }
    }
}
