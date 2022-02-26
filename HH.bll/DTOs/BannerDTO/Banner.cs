using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.BannerDTO
{
    public class Banner
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public bool IsPublish { get; set; }
    }
}
