using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.ServicesDTO
{
    public class EditServiceDTO
    {
        public int Id { get; set; }
        public ICollection<ServiceTranslateDTO> ServiceTranslates { get; set;}
        public string Image { get; set; }
        public IFormFile FormImage { get; set; }
        public bool IsPublish { get; set; }
    }
}
