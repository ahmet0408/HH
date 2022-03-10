using AutoMapper;
using AutoMapper.Internal;
using HH.bll.DTOs.ProductDTO;
using HH.bll.DTOs.ServicesDTO;
using HH.bll.Services.ImageService;
using HH.web.Data;
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
                    _imageService.DeleteImage(modelDTO.Image, "service");
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
        public IEnumerable<Service> GetAllService()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var service = _dbContext.Services.Include(p => p.ServiceTranslates.Where(p => p.LanguageCulture == culture));
            var result = _mapper.Map<IEnumerable<Service>>(service);
            return result;
        }
        public async Task<EditServiceDTO> GetServiceForEditById(int id)
        {
            var service = await _dbContext.Services.Include(p => p.ServiceTranslates).SingleOrDefaultAsync(p => p.Id == id);
            EditServiceDTO editServiceDTO = _mapper.Map<EditServiceDTO>(service);
            return editServiceDTO;
        }
        

        public IEnumerable<ServiceDTO> GetAllPublishService()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var service = _dbContext.Services.Include(p => p.ServiceTranslates.Where(p => p.LanguageCulture == culture)).Where(p => p.IsPublish == true);
            var result = _mapper.Map<IEnumerable<ServiceDTO>>(service);
            return result;
        }
        public IEnumerable<ServiceDetailDTO> GetServiceDetailById(int? id)
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var service = _dbContext.Services.Where(p => p.IsPublish == true).Include(p => p.ServiceTranslates.Where(p => p.LanguageCulture == culture)).ToList();
                var item = service.FirstOrDefault(p => p.Id == id);
                var ser = service.Remove(item);
                var serr = service.Prepend(item);
                var result = _mapper.Map<IEnumerable<ServiceDetailDTO>>(serr);
                return result;
        }
        
        public IEnumerable<ProductServiceDTO> ProductAndService()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var service = _dbContext.Services.Where(p => p.IsPublish == true).Include(p => p.ServiceTranslates.Where(p => p.LanguageCulture == culture)).ToList();
            var product = _dbContext.Product.Where(p => p.IsPublish == true).Include(p => p.ProductTranslates.Where(p => p.LanguageCulture == culture)).ToList();
            var result = _mapper.Map<IEnumerable<ProductServiceDTO>>(service);
            var result1 = _mapper.Map<IEnumerable<ProductServiceDTO>>(product);
            var mixed = result.Concat(result1);
            var shuffledList = mixed.OrderBy(x => Guid.NewGuid()).ToList();
            return shuffledList;
        }
    }
}
