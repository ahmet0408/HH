using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.ProjectDTO
{
    public class EditLocationDTO
    {
        public int Id { get; set; }
        [Required]
        public bool IsPublish { get; set; }
        public ICollection<LocationTranslateDTO> LocationTranslates { get; set; }
    }
}
