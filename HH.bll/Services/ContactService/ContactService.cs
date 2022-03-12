using AutoMapper;
using HH.bll.DTOs.ContactDTO;
using HH.bll.Services.ImageService;
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
        private readonly IImageService _imageService;
        public ContactService(ApplicationDbContext dbContext, IMapper mapper, IImageService imageService)
        {
            _imageService = imageService;
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task CreateUser(CreateUserDTO modelDTO)
        {
            if (modelDTO != null)
            {
                dal.Models.Contact.User user = _mapper.Map<dal.Models.Contact.User>(modelDTO);
                if (modelDTO.FormFile != null)
                {
                    user.File = await _imageService.UploadImage(modelDTO.FormFile, "user");
                }
                await _dbContext.User.AddAsync(user);
                await _dbContext.SaveChangesAsync();    
            }
        }
        public async Task RemoveUser(int id)
        {
            dal.Models.Contact.User user = await _dbContext.User.FindAsync(id);
            if (!string.IsNullOrEmpty(user.File))
            {
                _imageService.DeleteImage(user.File, "user");
            }
            _dbContext.User.Remove(user);
            await _dbContext.SaveChangesAsync();
        }
        public IEnumerable<UserDTO> GetAllUser()
        {
            var user = _dbContext.User.ToList();
            var result = _mapper.Map<IEnumerable<UserDTO>>(user);
            return result;
        }
    }
}
