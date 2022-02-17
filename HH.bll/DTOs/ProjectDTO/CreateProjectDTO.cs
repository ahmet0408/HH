using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.ProjectDTO
{
    public class CreateProjectDTO
    {
        public bool IsPublish { get; set; }
        public IFormFile FormImage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<ProjectTranslateDTO> ProjectTranslates { get; set; } 
        public string Client { get; set; }
        public int ClientId { get; set; }
        public string Status { get; set; }
        public int StatusId { get; set; }
        public string Location { get; set; }
        public int LocationId { get; set; }
    }
}
