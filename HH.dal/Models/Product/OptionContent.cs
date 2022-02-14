using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.dal.Models.Product
{
    public class OptionContent
    {
        public int Id { get; set; }
        public int OptionId { get; set; }
        public Option Option { get; set; } 
        public int SortOrder { get; set; }
        public ICollection<OptionContentTranslate> OptionContentTranslates { get; set; }
    }
}
