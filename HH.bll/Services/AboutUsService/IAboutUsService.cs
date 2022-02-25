using HH.bll.DTOs.AboutUsDTO;
using HH.dal.Models.AboutUs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.Services.AboutUsService
{
    public interface IAboutUsService
    {
        Task CreateAbout(CreateAboutUsDTO modelDTO);
        Task EditAbout(EditAboutUsDTO modelDTO);
        Task RemoveAbout(int id);
        AboutUsDTO GetAboutUs();
        IEnumerable<AboutUs> GetAllAboutUs();
        Task<AboutUsDetailDTO> GetAboutUsDetail();
        Task<FooterDTO> GetFooter();
    }
}
