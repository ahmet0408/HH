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
        Task<EditOptionContentDTO> GetOptionContentForEditById(int id);
        Task EditOption(EditOptionDTO modelDTO);
        Task EditOptionContent(EditOptionContentDTO modelDTO);
        IEnumerable<DTOs.ProductDTO.OptionContent> GetAllOptionContentForOption(int id);
        Task<EditOptionDTO> GetOptionForEditById(int id);
        Task<EditProductDTO> GetProductForEditById(int id);
        Task CreateProductOption(int id, List<int> optionId);
        IEnumerable<bll.DTOs.ProductDTO.Product> GetAllProduct();
        IEnumerable<Option> GetOptions();
        Task CreateProduct(CreateProductDTO modelDTO);
        Task CreateOptionContent(CreateOptionContentDTO modelDTO);
        Task CreateOption(CreateOptionDTO modelDTO);
        Task EditProduct(EditProductDTO modelDTO);
        Task RemoveProduct(int id);
        Task RemoveOption(int id);
        Task RemoveOptionContent(int id);
        IEnumerable<ProductDTO> GetAllPublishProductDTO();
        Task<ProductDetailDTO> GetProductPage(int id);
    }
}
