using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.ContactDTO
{
    public class CreateUserDTO
    {
        [Required]
        public string Test { get; set; }
        [Required]
        public string NatureOfBusiness { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public string PostCode { get; set; }
        [Required]
        public string ContactName { get; set; }
        [Required]
        public int ContactPhone { get; set; }
        [Required]
        public string EmailAdress { get; set; }
        [Required]
        public string Idea { get; set; }
        [Required]
        public string File { get; set; }
    }
}
