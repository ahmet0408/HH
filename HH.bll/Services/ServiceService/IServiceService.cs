using HH.bll.DTOs.ProductDTO;
using HH.bll.DTOs.ServicesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.Services.ServiceService
{
    public interface IServiceService
    {
        IEnumerable<Service> GetAlllService();
        Task CreateService(CreateServiceDTO modelDTO);
        Task EditService(EditServiceDTO modelDTO);
        Task RemoveService(int id);
        IEnumerable<ServiceDTO> GetAllPublishService();
        Task<ServiceDetailDTO> GetServiceDetailById(int id);
        IEnumerable<ProductDTO> GetAllService();
    }
}
