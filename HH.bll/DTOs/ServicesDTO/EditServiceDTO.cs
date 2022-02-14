using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.ServicesDTO
{
    public class EditServiceDTO
    {
        public ICollection<ServiceTranslateDTO> Translate { get; set;}
        public string Image { get; set; }
        public bool IsPublish { get; set; }
    }
}
