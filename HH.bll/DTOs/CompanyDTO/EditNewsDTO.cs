using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.CompanyDTO
{
    public class EditNewsDTO
    {
        public int Id { get; set; }
        public ICollection<NewsTranslateDTO> NewsTranslates { get; set; }
        public IFormFile FormImage { get; set; }
        public string Image { get; set; }
        public bool IsPublish { get; set; }
        public DateTime Date { get; set; }
    }
}
