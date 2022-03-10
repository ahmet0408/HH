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
        Task<EditServiceDTO> GetServiceForEditById(int id);
        IEnumerable<Service> GetAllService();
        Task CreateService(CreateServiceDTO modelDTO);
        Task EditService(EditServiceDTO modelDTO);
        Task RemoveService(int id);
        IEnumerable<ServiceDTO> GetAllPublishService();
        IEnumerable<ServiceDetailDTO> GetServiceDetailById(int? id);
        IEnumerable<ProductServiceDTO> ProductAndService();
    }
}
