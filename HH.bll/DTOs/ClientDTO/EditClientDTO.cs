using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.ClientDTO
{
    public class EditClientDTO
    {
        public int Id { get; set; }
        public IFormFile FormLogo { get; set; }
        public string Logo { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Link { get; set; }
    }
}
