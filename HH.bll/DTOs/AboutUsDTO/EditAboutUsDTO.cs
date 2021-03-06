using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.AboutUsDTO
{
    public class EditAboutUsDTO
    {
        public int Id { get; set; }
        public ICollection<AboutUsTranslateDTO> AboutUsTranslates { get; set; }
        public IFormFile FormImage { get; set; }
        public string Image { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Fax { get; set; }
        [Required]
        public string Mail { get; set; }
        [Required]
        public string Longitude { get; set; }
        [Required]
        public string Latitude { get; set; }
        [Required]
        public bool IsPublish { get; set; }
    }
}
