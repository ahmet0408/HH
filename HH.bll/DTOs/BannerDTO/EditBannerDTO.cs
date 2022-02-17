using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.BannerDTO
{
    public class EditBannerDTO
    {
        public int Id { get; set; }
        public ICollection<BannerTranslateDTO> BannerTranslates { get; set; }
        public string Image { get; set; }
        public IFormFile FormImage { get; set; }
        public bool IsPublish { get; set; }
    }
}
