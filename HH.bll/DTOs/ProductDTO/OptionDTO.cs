using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.ProductDTO
{
    public class OptionDTO
    {
        public int Id { get; set; }
        public string OptionCode { get; set; }
        public ICollection<OptionDetailDTO> optionDetailDTOs { get; set; }
    }
}
