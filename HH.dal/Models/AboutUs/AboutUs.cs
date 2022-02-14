using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.dal.Models.AboutUs
{
    public class AboutUs
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public bool IsPublish { get; set; }
        public string Mail { get; set; }
        public ICollection<AboutUsTranslate> AboutUsTranslates { get; set; }
    }
}
