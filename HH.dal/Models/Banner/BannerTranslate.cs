using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.dal.Models.Banner
{
    public class BannerTranslate
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string LanguageCulture { get; set; }
        public int BannerId { get; set; }
        public Banner Banner { get; set; }
    }
}
