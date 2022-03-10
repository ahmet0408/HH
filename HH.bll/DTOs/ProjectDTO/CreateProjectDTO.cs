using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.ProjectDTO
{
    public class CreateProjectDTO
    {
        [Required]
        public bool IsPublish { get; set; }
        [Required]
        public IFormFile FormImage { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public ICollection<ProjectTranslateDTO> ProjectTranslates { get; set; }
        [Required]
        public int ClientId { get; set; }
        [Required]
        public int StatusId { get; set; }
        [Required]
        public int LocationId { get; set; }
    }
}
