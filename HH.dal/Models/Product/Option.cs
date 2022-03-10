using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.dal.Models.Product
{
    public class Option
    {
        public int OptionId { get; set; }
        public string OptionCode { get; set; }
        public ICollection<OptionContent> OptionContent { get; set; }
        public ICollection<ProductOption> ProductOption { get; set; }
    }
}
