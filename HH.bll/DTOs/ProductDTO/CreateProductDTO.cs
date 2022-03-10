using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.ProductDTO
{
    public class CreateProductDTO
    {   
        [Required]
        public bool IsPublish { get; set; }
        [Required]
        public IFormFile FormImage { get; set; }
        [Required]
        public int SortOrder { get; set; }
        public IFormFile FormRequestFile { get; set; }
        public IFormFile FormDownloadFile { get; set; }
        public ICollection<ProductTranslateDTO> ProductTranslates { get; set; }
        public string OptionIds { get; set; }
    }
}
