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
        public ICollection<ProductTranslateDTO> ProductTranslates { get; set; }
        public ICollection<CreateOptionDTO> Option { get; set; }
        [Required]
        public bool IsPublish { get; set; }
        [Required]
        public string Image { get; set; }
        public int SortOrder { get; set; }
        public IFormFile RequestFile { get; set; }
        public IFormFile DownloadFile { get; set; }
    }
}
