using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.ProductDTO
{
    public class EditProductDTO
    {
        public ICollection<ProductTranslateDTO> ProductTranslates { get; set; }
        public ICollection<CreateOptionDTO> Option { get; set; }
        public bool IsPublish { get; set; }
        public string Image { get; set; }
        public int SortOrder { get; set; }
    }
}
