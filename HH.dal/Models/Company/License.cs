using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.dal.Models.Company
{
    public class License
    {
        public int Id { get; set; }
        public string File { get; set; }
        public bool IsPublish { get; set; }
        public ICollection<LicenseTranslate> LicenseTranslates { get; set; }
    }
}
