using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.ProductDTO
{
    public class EditProductDTO
    {
        public int Id { get; set; }
        public ICollection<ProductTranslateDTO> ProductTranslates { get; set; }
        public bool IsPublish { get; set; }
        public IFormFile FormImage { get; set; }
        public string Image { get; set; }
        public int SortOrder { get; set; }
        public string RequestFile { get; set; }
        public IFormFile FormRequestFile { get; set; }
        public string DownloadFile { get; set; }
        public IFormFile FormDownloadFile { get; set; }
    }
}
