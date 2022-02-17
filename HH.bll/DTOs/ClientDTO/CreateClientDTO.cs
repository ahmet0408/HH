﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.ClientDTO
{
    public class CreateClientDTO
    {
        [Required]
        public IFormFile FormLogo { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Link { get; set; }
    }
}
