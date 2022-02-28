using HH.bll.DTOs.ClientDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.Services.ClientService
{
    public interface IClientService
    {
        Task<EditClientDTO> GetClientForEditById(int id);
        IEnumerable<ClientDTO> GetAllClientButThis(int id);
        Task CreatClient(CreateClientDTO modelDTO);
        Task EditClient(EditClientDTO modelDTO);
        Task RemoveClient(int id);
        IEnumerable<ClientDTO> GetAllClient();
    }
}
