using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.ProductDTO
{
    public class EditProductDTO
    {
        public int ProductId { get; set; }
        [Required]
        public bool IsPublish { get; set; }
        public IFormFile FormImage { get; set; }
        public string Image { get; set; }
        [Required]
        public int SortOrder { get; set; }
        public IFormFile FormRequestFile { get; set; }
        public string RequestFile { get; set; }
        public string DownloadFile { get; set; }
        public IFormFile FormDownloadFile { get; set; }
        public ICollection<ProductTranslateDTO> ProductTranslates { get; set; }
        public string OptionIs { get; set; }
        public int[] OptionIds { get; set; } 
    }
}
