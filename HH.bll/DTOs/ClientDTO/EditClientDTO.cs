using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
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
        public string Name { get; set; }
        public string Link { get; set; }
    }
}
