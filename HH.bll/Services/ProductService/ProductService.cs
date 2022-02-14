using AutoMapper;
using HH.bll.DTOs.ProductDTO;
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
        public ProductService(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task CreateProduct(CreateProductDTO modelDTO)
        {
            dal.Models.Product.Product product = _mapper.Map<dal.Models.Product.Product>(modelDTO);
            await _dbContext.Product.AddAsync(product);
            await _dbContext.SaveChangesAsync();
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
        public IEnumerable<ProductDTO> GetAllPublishProductDTO()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var products = _dbContext.Product.Where(p => p.IsPublish == true).Include(p => p.ProductTranslates.Where(p => p.LanguageCulture == culture));
            var result = _mapper.Map<IEnumerable<ProductDTO>>(products);
            return result;
        }
        public async Task<ProductDetailDTO> GetProductDetailtWithoutOption(int id)
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;

            //var product = await _dbContext.Product.Include(p => p.ProductTranslates
            //                                      .Where(p => p.LanguageCulture == culture))
            //                                       .Include(p => p.Option)
            //                                           .ThenInclude(p => p.OptionContent)
            //                                           .ThenInclude(p => p.OptionContentTranslates
            //                                           .Where(p => p.LanguageCulture == culture))
            //                                       .FirstOrDefaultAsync(p => p.Id == id);
            var product = await _dbContext.Product.Include(p => p.ProductTranslates.Where(p => p.LanguageCulture == culture)).Include(p => p.Option).FirstOrDefaultAsync();
            return _mapper.Map<ProductDetailDTO>(product);   
        }
        public IEnumerable<OptionDetailDTO> GetAllOptionDetailByOptionId(int id)
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var optiondetail = _dbContext.OptionContent.Include(p => p.OptionContentTranslates.Where(p => p.LanguageCulture == culture)).Where(p => p.OptionId == id).OrderBy(p => p.SortOrder);
            var result = _mapper.Map<IEnumerable<OptionDetailDTO>>(optiondetail);
            return result;
        }
    }
}
