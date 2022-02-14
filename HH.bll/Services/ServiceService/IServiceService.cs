﻿using HH.bll.DTOs.ServicesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.Services.ServiceService
{
    public interface IServiceService
    {
        Task CreateService(CreateServiceDTO modelDTO);
        Task EditService(EditServiceDTO modelDTO);
        Task RemoveService(int id);
        IEnumerable<ServiceDTO> GetAllPublishServiceDTO();
        Task<ServiceDetailDTO> GetByIdServiceDetailDTO(int id);
    }
}
