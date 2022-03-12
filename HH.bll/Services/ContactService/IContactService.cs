using HH.bll.DTOs.ContactDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.Services.ContactService
{
    public interface IContactService
    {
        Task CreateUser(CreateUserDTO modelDTO);
        Task RemoveUser(int id);
        IEnumerable<UserDTO> GetAllUser();

    }
}
