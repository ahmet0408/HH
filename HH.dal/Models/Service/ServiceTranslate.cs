using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.dal.Models.Service
{
    public class ServiceTranslate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDesc { get; set; }
        public string Description { get; set; }
        public string LanguageCulture { get; set; }
        public int ServiceId { get; set;}
        public Service Service { get; set; }
    }
}
