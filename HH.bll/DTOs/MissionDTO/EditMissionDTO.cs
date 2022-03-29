using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.MissionDTO
{
    public class EditMissionDTO
    {
        public int Id { get; set; }
        public ICollection<MissionTranslateDTO> MissionTranslates { get; set; }
        public string Icon { get; set; }
        public IFormFile FormIcon { get; set; }
        [Required] 
        public string iconCode { get; set; }
        [Required]
        public bool IsPublish { get; set; }
    }
}
