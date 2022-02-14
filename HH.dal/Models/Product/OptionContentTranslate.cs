using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.dal.Models.Product
{
    public class OptionContentTranslate
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string LanguageCulture { get; set; }
        public int OptionContentId { get; set; }
        public OptionContent OptionContent { get; set; }
    }
}
