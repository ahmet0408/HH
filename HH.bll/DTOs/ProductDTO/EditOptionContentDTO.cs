using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.ProductDTO
{
    public class EditOptionContentDTO
    {
        public int Id { get; set; }
        public string PreviousUrl { get; set; }
        [Required]
        public int SortOrder { get; set; }
        public ICollection<OptionContentTranslateDTO> OptionContentTranslates { get; set; }
        [Required]
        public int OptionId { get; set; }
    }
}
