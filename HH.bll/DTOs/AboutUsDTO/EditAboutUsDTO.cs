using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.AboutUsDTO
{
    public class EditAboutUsDTO
    {
        public int Id { get; set; }
        public ICollection<AboutUsTranslateDTO> AboutUsTranslates { get; set; }
        public IFormFile FormMainImage { get; set; }
        public string MainImage { get; set; }
        public IFormFile FormImage { get; set; }
        public string Image { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Mail { get; set; }
        public int Longitude { get; set; }
        public int Latitude { get; set; }
        public bool IsPublish { get; set; }
    }
}
