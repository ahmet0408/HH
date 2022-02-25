using HH.bll.DTOs.ProductDTO;
using HH.dal.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.Services.ProductService
{
    public interface IProductService
    {
        string Product(int id);
        IEnumerable<Option> GetAll();
        IEnumerable<ProductTranslate> GetAllProduct();
        Task CreateProduct(CreateProductDTO modelDTO);
        Task CreateOptionContent(CreateOptionContentDTO modelDTO);
        Task CreateOption(CreateOptionDTO modelDTO);
        Task EditProduct(EditProductDTO modelDTO);
        Task RemoveProduct(int id);
        IEnumerable<ProductDTO> GetAllPublishProductDTO();
        Task<ProductDetailDTO> GetProductPage(int id);
        IEnumerable<OptionDetailDTO> GetAllOptionDetailByOptionId(int id);
    }
}
