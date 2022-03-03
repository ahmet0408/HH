using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.CompanyDTO
{
    public class CreateNewsDTO
    {
        public ICollection<NewsTranslateDTO> NewsTranslates { get; set; }
        [Required]
        public IFormFile FormImage { get; set; }
        [Required]
        public bool IsPublish { get; set; }
    }
}
