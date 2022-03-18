using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.CompanyDTO
{
    public class EditLicenseDTO
    {
        public int Id { get; set; }
        public ICollection<LicenseTranslateDTO> LicenseTranslates { get; set; }
        public IFormFile FormFile { get; set; }
        public string File { get; set; }
        public bool IsPublish { get; set; }
    }
}
