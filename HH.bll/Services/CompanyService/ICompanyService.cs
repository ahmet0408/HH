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
        Task<EditNewsDTO> GetNewsForEditById(int id);
        Task CreateNews(CreateNewsDTO modelDTO);
        Task RemoveNews(int id);
        Task EditNews(EditNewsDTO modelDTO);
        IEnumerable<News> GetAllNews();
        IEnumerable<NewsDTO> GetAllPublishNews();
        Task<NewsDetailDTO> GetNewsPage(int id);
    }
}
