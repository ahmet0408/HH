using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.AboutUsDTO
{
    public class AboutUsDTO
    {
        public string Image { get; set; }
        public string ShortDesc { get; set; }
    }
}
