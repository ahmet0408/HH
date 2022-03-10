using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.AboutUsDTO
{
    public class AboutUsTranslateDTO
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string ShortDesc { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string LocationAdress { get; set; }
        [Required]
        public string LanguageCulture { get; set; }
    }
}
