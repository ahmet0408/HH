﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.AboutUsDTO
{
    public class CreateAboutUsDTO
    {
        public ICollection<AboutUsTranslateDTO> AboutUsTranslates { get; set; }
        [Required]
        public IFormFile FormImage { get; set; }
        [Required]
        public bool IsPublish { get; set; }
        [Required]
        public string Mail { get; set; }
    }
}
