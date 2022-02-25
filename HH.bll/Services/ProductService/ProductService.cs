using AutoMapper;
using HH.bll.DTOs.ProductDTO;
using HH.bll.Services.ImageService;
using HH.dal.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.Services.ProductService
{
    public class ProductService: IProductService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IImageService _imageService;
        public ProductService(ApplicationDbContext dbContext, IMapper mapper, IImageService imageService)
        {
            _dbContext = dbContext;
            _imageService = imageService;
            _mapper = mapper;
        }
        public async Task CreateProduct(CreateProductDTO modelDTO)
        {
            if (modelDTO != null)
            {
                dal.Models.Product.Product product = _mapper.Map<dal.Models.Product.Product>(modelDTO);
                if (modelDTO.FormImage != null)
                {
                    product.Image = await _imageService.UploadImage(modelDTO.FormImage, "product");
                }
                if (modelDTO.FormRequestFile != null)
                {
                    product.RequestFile = await _imageService.UploadImage(modelDTO.FormRequestFile, "product");
                }
                if (modelDTO.FormDownloadFile != null)
                {
                    product.DownloadFile = await _imageService.UploadImage(modelDTO.FormDownloadFile, "product");
                }
                await _dbContext.Product.AddAsync(product);
                await _dbContext.SaveChangesAsync();
            }
        }
        public async Task CreateOption(CreateOptionDTO modelDTO)
        {
            dal.Models.Product.Option option = _mapper.Map<dal.Models.Product.Option>(modelDTO);

            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var product = _dbContext.ProductTranslates.Where(p => p.Name == modelDTO.Productt).FirstOrDefault();
            option.ProductId = product.ProductId;
            await _dbContext.Option.AddAsync(option);
            await _dbContext.SaveChangesAsync();
            
        }
        public async Task CreateOptionContent(CreateOptionContentDTO modelDTO)
        {
            if (modelDTO != null)
            {
                var option = await _dbContext.Option.Where(p => p.OptionCode == modelDTO.Optionn).FirstOrDefaultAsync();
                modelDTO.OptionId = option.Id;
                dal.Models.Product.OptionContent optionContent = _mapper.Map<dal.Models.Product.OptionContent>(modelDTO);
                await _dbContext.OptionContent.AddAsync(optionContent);
                await _dbContext.SaveChangesAsync();
            }
        }
        public async Task EditProduct(EditProductDTO modelDTO)
        {
            dal.Models.Product.Product product = _mapper.Map<dal.Models.Product.Product>(modelDTO);
            await _dbContext.Product.AddAsync(product);
            await _dbContext.SaveChangesAsync();
        }
        public async Task RemoveProduct(int id)
        {
            dal.Models.Product.Product product = await _dbContext.Product.FindAsync(id);
            _dbContext.Product.Remove(product);
            await _dbContext.SaveChangesAsync();
        }
        public string Product(int id)
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var name = _dbContext.ProductTranslates.Where(p => p.LanguageCulture == culture && p.ProductId == id).Select(p => p.Name).ToString();
            return name;    
        }
        public IEnumerable<dal.Models.Product.Option> GetAll()
        {
            var option = _dbContext.Option.ToList();
            return option;
        }
        public IEnumerable<dal.Models.Product.ProductTranslate> GetAllProduct()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var product = _dbContext.ProductTranslates.Where(p => p.LanguageCulture == culture).Where(p => p.ProductId == p.Product.Id && p.Product.IsPublish == true);
            return product;
        }
        public IEnumerable<ProductDTO> GetAllPublishProductDTO()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var products = _dbContext.Product.Where(p => p.IsPublish == true).Include(p => p.ProductTranslates.Where(p => p.LanguageCulture == culture));
            var result = _mapper.Map<IEnumerable<ProductDTO>>(products);
            return result;
        }
        public async Task<ProductDetailDTO> GetProductPage(int id)
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var product = await _dbContext.Product.Include(p => p.ProductTranslates.Where(p => p.LanguageCulture == culture)).Include(p => p.Option).FirstOrDefaultAsync(p => p.Id == id);
            return _mapper.Map<ProductDetailDTO>(product);   
        }
        public IEnumerable<OptionDetailDTO> GetAllOptionDetailByOptionId(int id)
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var optiondetail = _dbContext.OptionContent.Where(p => p.OptionId == id).Include(p => p.OptionContentTranslates.Where(p => p.LanguageCulture == culture)).OrderBy(p => p.SortOrder);
            var result = _mapper.Map<IEnumerable<OptionDetailDTO>>(optiondetail);
            return result;
        }
    }
}
