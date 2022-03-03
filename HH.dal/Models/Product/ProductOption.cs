using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.dal.Models.Product
{
    public class ProductOption
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int OptionId { get; set; }
        public Option Option { get; set; }
    }
}
