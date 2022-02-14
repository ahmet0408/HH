using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.ServicesDTO
{
    public class CreateServiceDTO
    {
        public ICollection<ServiceTranslateDTO> ServiceTranslates { get; set; }
        [Required]
        public bool IsPublish { get; set; }
        [Required]
        public string Image { get; set; }
    }
}
