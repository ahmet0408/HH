using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.dal.Models.Banner
{
    public class Banner
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public bool IsPublish { get; set; }
        public ICollection<BannerTranslate> BannerTranslates { get; set; }
    }
}
