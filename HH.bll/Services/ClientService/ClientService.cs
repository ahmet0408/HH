using AutoMapper;
using HH.bll.DTOs.ClientDTO;
using HH.bll.Services.ImageService;
using HH.web.Data;
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
        private readonly IImageService _imageService;
        public static string FilePath { get; } = "client";

        public ClientService(ApplicationDbContext dbContext, IMapper mapper, IImageService imageService)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _imageService = imageService;
        }
        public async Task CreatClient(CreateClientDTO modelDTO)
        {
            if (modelDTO != null)
            {
                dal.Models.Client.Client client = _mapper.Map<dal.Models.Client.Client>(modelDTO);
                if (modelDTO.FormLogo != null)
                {
                    client.Logo = await _imageService.UploadImage(modelDTO.FormLogo, FilePath);  
                }
                await _dbContext.Client.AddAsync(client);
                await _dbContext.SaveChangesAsync();
            }
        }
        public async Task EditClient(EditClientDTO modelDTO)
        {
            if (modelDTO != null)
            {
                dal.Models.Client.Client client = _mapper.Map<dal.Models.Client.Client>(modelDTO);
                if (modelDTO.FormLogo != null)
                {
                    _imageService.DeleteImage(modelDTO.Logo, FilePath);
                    client.Logo = await _imageService.UploadImage(modelDTO.FormLogo, FilePath);
                } else
                {
                    client.Logo = modelDTO.Logo;
                }
                _dbContext.Client.Update(client);
                await _dbContext.SaveChangesAsync();

            }
        }
        public async Task RemoveClient(int id)
        {
            dal.Models.Client.Client client =await _dbContext.Client.FindAsync(id);
            if (!string.IsNullOrEmpty(client.Logo))
            {
                _imageService.DeleteImage(client.Logo, FilePath);
            }
            _dbContext.Client.Remove(client);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<EditClientDTO> GetClientForEditById(int id)
        {
            var client = await _dbContext.Client.FindAsync(id);
            EditClientDTO editClientDTO = _mapper.Map<EditClientDTO>(client);
            return editClientDTO;
        }
        public IEnumerable<ClientDTO> GetAllClientButThis(int id)
        {
            var client = _dbContext.Client.Where(p => p.Id != id);
            var result = _mapper.Map<IEnumerable<ClientDTO>>(client);
            return result;
        }
        public IEnumerable<ClientDTO> GetAllClient()
        {
            var client = _dbContext.Client.ToList();
            var result = _mapper.Map<IEnumerable<ClientDTO>>(client);
            return result;
        }
    }
}
