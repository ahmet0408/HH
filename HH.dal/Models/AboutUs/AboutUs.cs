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
        public string Phone { get; set; }
        public string Fax { get; set; }
        public bool IsPublish { get; set; }
        public string Mail { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public ICollection<AboutUsTranslate> AboutUsTranslates { get; set; }
    }
}
