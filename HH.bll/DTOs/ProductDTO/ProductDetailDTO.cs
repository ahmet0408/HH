using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.ProductDTO
{
    public class ProductDetailDTO
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ShortDesc { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string RequestFile { get; set; }
        public string DownloadFile { get; set; }
        public ICollection<OptionDTO> OptionDTO { get; set; }
    }
}
