using AutoMapper;
using HH.bll.DTOs.ProductDTO;
using HH.bll.Services.ImageService;
using HH.web.Data;
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
                    product.Image = await _imageService.UploadImage(modelDTO.FormImage, "service");
                }
                if (modelDTO.FormRequestFile != null)
                {
                    product.RequestFile = await _imageService.UploadImage(modelDTO.FormRequestFile, "service");
                }
                if (modelDTO.FormDownloadFile != null)
                {
                    product.DownloadFile = await _imageService.UploadImage(modelDTO.FormDownloadFile, "service");
                }
                List<int> optionIds = new List<int>();
                if(!string.IsNullOrEmpty(modelDTO.OptionIds))
                {
                   var arIds =  modelDTO.OptionIds.Split(",");
                    foreach (var arId in arIds)
                    {
                        try
                        {
                            optionIds.Add(int.Parse(arId));
                        }catch(Exception e)
                        {

                        }
                    }
                }
                product =  _dbContext.Product.Add(product).Entity;
                _dbContext.SaveChanges();
                await CreateProductOption(product.ProductId, optionIds);             
            }
        } 
        public async Task EditProduct(EditProductDTO modelDTO)
        {
            if (modelDTO != null)
            {
                dal.Models.Product.Product product = _mapper.Map<dal.Models.Product.Product>(modelDTO);
                if (modelDTO.FormImage != null)
                {
                    _imageService.DeleteImage(modelDTO.Image, "service");
                    product.Image = await _imageService.UploadImage(modelDTO.FormImage, "service");
                }
                else
                {
                    product.Image = modelDTO.Image;
                }
                if (modelDTO.FormRequestFile != null)
                {
                    _imageService.DeleteImage(modelDTO.RequestFile, "service");
                    product.RequestFile = await _imageService.UploadImage(modelDTO.FormRequestFile, "service");
                }
                else
                {
                    product.RequestFile = modelDTO.RequestFile;
                }
                if (modelDTO.FormDownloadFile != null)
                {
                    _imageService.DeleteImage(modelDTO.DownloadFile, "service");
                    product.DownloadFile = await _imageService.UploadImage(modelDTO.FormDownloadFile, "service");
                }
                else
                {
                    product.DownloadFile = modelDTO.DownloadFile;
                }
                var remOp = _dbContext.ProductOption.Where(p => p.ProductId == product.ProductId).ToList();
                _dbContext.ProductOption.RemoveRange(remOp);
                List<int> optionIs = new List<int>();
                if (!string.IsNullOrEmpty(modelDTO.OptionIs))
                {
                    var arIds = modelDTO.OptionIs.Split(",");
                    foreach (var arId in arIds)
                    {
                        try
                        {
                            optionIs.Add(int.Parse(arId));
                        }
                        catch (Exception e)
                        {

                        }
                    }
                }
                product = _dbContext.Product.Update(product).Entity;
                _dbContext.SaveChanges();
                await CreateProductOption(product.ProductId, optionIs);
            }   
        }
        public async Task RemoveProduct(int id)
        {
            dal.Models.Product.Product product = await _dbContext.Product.FindAsync(id);
            if (!string.IsNullOrEmpty(product.Image))
            {
                _imageService.DeleteImage(product.Image, "service");
            }
            if (!string.IsNullOrEmpty(product.RequestFile))
            {
                _imageService.DeleteImage(product.RequestFile, "service");
            }
            if (!string.IsNullOrEmpty(product.DownloadFile))
            {
                _imageService.DeleteImage(product.DownloadFile, "service");
            }
            _dbContext.Product.Remove(product);
            await _dbContext.SaveChangesAsync();
        }
        public async Task CreateProductOption(int id, List<int> optionId)
        {

            foreach (var oId in optionId)
            {
                dal.Models.Product.ProductOption productOption = new dal.Models.Product.ProductOption();
                productOption.ProductId = id;
                productOption.OptionId = oId;
                await _dbContext.ProductOption.AddAsync(productOption);
            }
            await _dbContext.SaveChangesAsync();
        }
        public async Task CreateOption(CreateOptionDTO modelDTO)
        {
            dal.Models.Product.Option option = _mapper.Map<dal.Models.Product.Option>(modelDTO);
            await _dbContext.Option.AddAsync(option);
            await _dbContext.SaveChangesAsync();

        }
        public async Task EditOption(EditOptionDTO modelDTO)
        {
            dal.Models.Product.Option option = _mapper.Map<dal.Models.Product.Option>(modelDTO);
            _dbContext.Option.Update(option);
            await _dbContext.SaveChangesAsync();
        }
        public async Task RemoveOption(int id)
        {
            dal.Models.Product.Option option = await _dbContext.Option.FindAsync(id);
            _dbContext.Option.Remove(option);
            await _dbContext.SaveChangesAsync();
        }

        public async Task CreateOptionContent(CreateOptionContentDTO modelDTO)
        {
            dal.Models.Product.OptionContent optionContent = _mapper.Map<dal.Models.Product.OptionContent>(modelDTO);
            await _dbContext.OptionContent.AddAsync(optionContent);
            await _dbContext.SaveChangesAsync();
        }
        public async Task EditOptionContent(EditOptionContentDTO modelDTO)
        {
            dal.Models.Product.OptionContent optionContent = _mapper.Map<dal.Models.Product.OptionContent>(modelDTO);
            _dbContext.OptionContent.Update(optionContent);
            await _dbContext.SaveChangesAsync();
        }
        public async Task RemoveOptionContent(int id)
        {
            dal.Models.Product.OptionContent optionContent = await _dbContext.OptionContent.FindAsync(id);
            _dbContext.OptionContent.Remove(optionContent);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<EditOptionDTO> GetOptionForEditById(int id)
        {
            var option = await _dbContext.Option.Include(p => p.OptionContent).SingleOrDefaultAsync(p => p.OptionId == id);
            EditOptionDTO editOptionDTO = _mapper.Map<EditOptionDTO>(option);
            return editOptionDTO;
        }
        public async Task<EditOptionContentDTO> GetOptionContentForEditById(int id)
        {
            var optionContent = await _dbContext.OptionContent.Include(p => p.OptionContentTranslates).SingleOrDefaultAsync(p => p.Id == id);
            EditOptionContentDTO editOptionContentDTO = _mapper.Map<EditOptionContentDTO>(optionContent);
            return editOptionContentDTO;
        }
        public IEnumerable<OptionContent> GetAllOptionContentForOption(int id)
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var optionContent = _dbContext.OptionContent.Where(p => p.OptionId == id).Include(p => p.OptionContentTranslates.Where(p => p.LanguageCulture == culture)).ToList();
            var result = _mapper.Map<IEnumerable<OptionContent>>(optionContent);
            return result;
        }
        public async Task<EditProductDTO> GetProductForEditById(int id)
        {
            var product = await _dbContext.Product.Include(p => p.ProductTranslates).Include(p => p.ProductOption).SingleOrDefaultAsync(p => p.ProductId == id);
            EditProductDTO editProductDTO = _mapper.Map<EditProductDTO>(product);
            return editProductDTO;
        }

        public IEnumerable<Product> GetAllProduct()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var product = _dbContext.Product.Include(p => p.ProductTranslates.Where(p => p.LanguageCulture == culture));
            var result = _mapper.Map<IEnumerable<Product>>(product);
            return result;
        }
        public IEnumerable<dal.Models.Product.Option> GetOptions()
        {
            var option = _dbContext.Option.ToList();
            return option;
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
            var product = await _dbContext.Product
                .Include(p => p.ProductTranslates.Where(p => p.LanguageCulture == culture))
                .Include(p => p.ProductOption.Where(p => p.ProductId == id))
                    .ThenInclude(p => p.Option)
                        .ThenInclude(p => p.OptionContent.OrderBy(p => p.SortOrder))
                            .ThenInclude(p => p.OptionContentTranslates.Where(p => p.LanguageCulture == culture))
                .SingleOrDefaultAsync(p => p.ProductId == id);
            return _mapper.Map<ProductDetailDTO>(product);   
        }
    }
}
