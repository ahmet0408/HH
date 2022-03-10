using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.ProductDTO
{
    public class CreateOptionDTO
    {
        [Required]
        public string OptionCode { get; set; }
    }
}
