using HH.bll.DTOs.ProductDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.Services.ProductService
{
    public interface IProductService
    {
        Task CreateProduct(CreateProductDTO modelDTO);
        Task EditProduct(EditProductDTO modelDTO);
        Task RemoveProduct(int id);
        IEnumerable<ProductDTO> GetAllPublishProductDTO();
        Task<ProductDetailDTO> GetProductDetailtWithoutOption(int id);
        IEnumerable<OptionDetailDTO> GetAllOptionDetailByOptionId(int id);
    }
}
