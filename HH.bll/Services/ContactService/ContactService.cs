using AutoMapper;
using HH.bll.DTOs.ContactDTO;
using HH.web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.Services.ContactService
{
    public class ContactService: IContactService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        public ContactService(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task CreateUser(CreateUserDTO modelDTO)
        {
            dal.Models.Contact.User user = _mapper.Map<dal.Models.Contact.User>(modelDTO);
            await _dbContext.User.AddAsync(user);
            await _dbContext.SaveChangesAsync();
        }
        public IEnumerable<UserDTO> GetAllUser()
        {
            var user = _dbContext.User;
            var result = _mapper.Map<IEnumerable<UserDTO>>(user);
            return result;
        }
    }
}
