using AutoMapper;
using HH.bll.DTOs.ClientDTO;
using HH.dal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.Services.ClientService
{
    public class ClientService: IClientService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public ClientService(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task CreatClient(CreateClientDTO modelDTO)
        {
            dal.Models.Client.Client client = _mapper.Map<dal.Models.Client.Client>(modelDTO);
            await _dbContext.Client.AddAsync(client);
            await _dbContext.SaveChangesAsync();
        }
        public async Task EditClient(EditClientDTO modelDTO)
        {
            dal.Models.Client.Client client = _mapper.Map<dal.Models.Client.Client>(modelDTO);
            _dbContext.Client.Update(client);
            await _dbContext.SaveChangesAsync();
        }
        public async Task RemoveClient(int id)
        {
            dal.Models.Client.Client client =await _dbContext.Client.FindAsync(id);
            _dbContext.Client.Remove(client);
            await _dbContext.SaveChangesAsync();
        }
        public IEnumerable<ClientDTO> GetAllClient()
        {
            var client = _dbContext.Client.ToList();
            var result = _mapper.Map<IEnumerable<ClientDTO>>(client);
            return result;
        }
    }
}
