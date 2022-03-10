using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.ProjectDTO
{
    public class EditProjectDTO
    {
        public int Id { get; set; }
        [Required]
        public bool IsPublish { get; set; }
        public IFormFile FormImage { get; set; }
        public string Image { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public ICollection<ProjectTranslateDTO> ProjectTranslates { get; set; }
        public string Client { get; set; }
        [Required]
        public int ClientId { get; set; }
        public string Status { get; set; }
        [Required]
        public int StatusId { get; set; }
        public string Location { get; set; }
        [Required]
        public int LocationId { get; set; }
    }
}
