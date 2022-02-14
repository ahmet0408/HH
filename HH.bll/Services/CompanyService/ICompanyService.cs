using HH.bll.DTOs.CompanyDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.Services.CompanyService
{
    public interface ICompanyService
    {
        Task CreateNews(CreateNewsDTO modelDTO);
        Task RemoveNews(int id);
        Task EditNews(EditNewsDTO modelDTO);
        IEnumerable<NewsDTO> GetAllPublishListNews();
        Task<NewsDetailDTO> GetPublishNewsDetail(int id);
    }
}
