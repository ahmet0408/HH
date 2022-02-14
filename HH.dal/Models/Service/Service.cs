using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.dal.Models.Service
{
    public class Service
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public bool IsPublish { get; set; }
        public ICollection<ServiceTranslate> ServiceTranslates { get; set; }
    }
}
