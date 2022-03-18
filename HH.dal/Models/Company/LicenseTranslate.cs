using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.dal.Models.Company
{
    public class LicenseTranslate
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string LanguageCulture { get; set; }
        public int LicenseId { get; set; }
        public License License { get; set; }
    }
}
