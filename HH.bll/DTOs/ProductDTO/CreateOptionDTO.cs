using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.ProductDTO
{
    public class CreateOptionDTO
    {
        public ICollection<CreateOptionContentDTO> OptionContent { get; set; }
        public string OptionCode { get; set; }
    }
}
