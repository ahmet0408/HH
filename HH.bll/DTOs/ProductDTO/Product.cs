using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.ProductDTO
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ShortDesc { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int SortOrder { get; set; }
        public string RequestFile { get; set; }
        public string DownloadFile { get; set; }
        public bool IsPublish { get; set; }

    }
}
