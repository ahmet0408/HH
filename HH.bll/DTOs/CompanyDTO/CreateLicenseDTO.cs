using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.CompanyDTO
{
    public class CreateLicenseDTO
    {
        public ICollection<LicenseTranslateDTO> LicenseTranslates { get; set; }
        [Required]
        public IFormFile FormFile { get; set; }
        [Required]
        public bool IsPublish { get; set; }
    }
}
