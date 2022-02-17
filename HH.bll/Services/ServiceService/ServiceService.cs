using AutoMapper;
using HH.bll.DTOs.ServicesDTO;
using HH.bll.Services.ImageService;
using HH.dal.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.Services.ServiceService
{
    public class ServiceService: IServiceService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IImageService _imageService;

        public ServiceService(ApplicationDbContext dbContext, IMapper mapper, IImageService imageService)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _imageService = imageService;
        } 
        public async Task CreateService(CreateServiceDTO modelDTO)
        {
            if (modelDTO != null)
            {
                dal.Models.Service.Service service = _mapper.Map<dal.Models.Service.Service>(modelDTO);
                if (modelDTO.FormImage != null) 
                {
                    service.Image = await _imageService.UploadImage(modelDTO.FormImage, "service"); 
                } 
                await _dbContext.Services.AddAsync(service);
                await _dbContext.SaveChangesAsync();
            }
        }
        public async Task EditService(EditServiceDTO modelDTO)
        {
            if (modelDTO != null)
            {
                dal.Models.Service.Service service = _mapper.Map<dal.Models.Service.Service>(modelDTO);
                if (modelDTO.FormImage != null)
                {
                    _imageService.DeleteImage(service.Image, "service");
                    service.Image = await _imageService.UploadImage(modelDTO.FormImage, "service");
                } else
                {
                    service.Image = modelDTO.Image;
                }
                _dbContext.Services.Update(service);
                await _dbContext.SaveChangesAsync();
            }
        }
        public async Task RemoveService(int id)
        {
            dal.Models.Service.Service service = await _dbContext.Services.FindAsync(id);
            if (!string.IsNullOrEmpty(service.Image))
            {
                _imageService.DeleteImage(service.Image, "service");
            }
            _dbContext.Services.Remove(service);
            await _dbContext.SaveChangesAsync();
        }
        public IEnumerable<ServiceDTO> GetAllPublishServiceDTO()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var service = _dbContext.Services.Include(p => p.ServiceTranslates.Where(p => p.LanguageCulture == culture)).Where(p => p.IsPublish == true);
            var result = _mapper.Map<IEnumerable<ServiceDTO>>(service);
            return result;
        }
        public async Task<ServiceDetailDTO> GetByIdServiceDetailDTO(int id)
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var service = _dbContext.Services.Find(id);
            var translate = await _dbContext.ServiceTranslates
                .Where(p => p.LanguageCulture == culture).SingleOrDefaultAsync(p => p.ServiceId == service.Id);
            ServiceDetailDTO result = new ServiceDetailDTO()
            {
                Id = service.Id,
                Name = translate.Name,
                Description = translate.Description,
                Image = service.Image
            };
            return result;
        }
    }
}
