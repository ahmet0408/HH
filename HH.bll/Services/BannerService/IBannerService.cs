using HH.bll.DTOs.BannerDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.Services.BannerService
{
    public interface IBannerService
    {
        Task<EditBannerDTO> GetBannerForEditById(int id);
        Task CreateBanner(CreateBannerDTO modelDTO);
        Task EditBanner(EditBannerDTO modelDTO);
        Task RemoveBanner(int id);
        Task<BannerDTO> GetBanner();
        IEnumerable<Banner> GetAllBanner();
    }
}
