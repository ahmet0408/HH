using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.AboutUsDTO
{
    public class EditAboutUsDTO
    {
        public ICollection<AboutUsTranslateDTO> AboutUsTranslates { get; set; }
        public string Image { get; set; }
        public bool IsPublish { get; set; }
        public string Mail { get; set; }
    }
}
