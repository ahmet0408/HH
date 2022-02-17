﻿using AutoMapper;
using HH.bll.DTOs.BannerDTO;
using HH.bll.Services.ImageService;
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
    public class BannerService : IBannerService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IImageService _imageService;
        public static string  Filepath { get; } = "banner";
        public BannerService(ApplicationDbContext dbContext, IMapper mapper, IImageService imageService)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _imageService = imageService;
        }
        public async Task CreateBanner(CreateBannerDTO modelDTO)
        {
            if (modelDTO != null && modelDTO.FormImage != null)
            {
                dal.Models.Banner.Banner banner = _mapper.Map<dal.Models.Banner.Banner>(modelDTO);

                banner.Image = await _imageService.UploadImage(modelDTO.FormImage,Filepath);
                await _dbContext.Banner.AddAsync(banner);
                await _dbContext.SaveChangesAsync();
            }
        }
        public async Task EditBanner(EditBannerDTO modelDTO)
        {
            if (modelDTO != null)
            { 
                dal.Models.Banner.Banner banner = _mapper.Map<dal.Models.Banner.Banner>(modelDTO);
                if (modelDTO.FormImage != null)
                {
                    
                    _imageService.DeleteImage(modelDTO.Image, Filepath);
                  
                    banner.Image = await _imageService.UploadImage(modelDTO.FormImage, Filepath);
                   
                    // inkini pos 
                    // upload new
                    //set image to new image
                }
                else
                {
                    banner.Image = modelDTO.Image;
                }
                _dbContext.Banner.Update(banner);
                await _dbContext.SaveChangesAsync();
            }
        }
        public async Task RemoveBanner(int id)
        {
            dal.Models.Banner.Banner banner =await _dbContext.Banner.FindAsync(id);
            if (!string.IsNullOrEmpty(banner.Image))
            {
                _imageService.DeleteImage(banner.Image, Filepath);
            }
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
