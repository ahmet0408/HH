using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.MissionDTO
{
    public class CreateMissionDTO
    {
        public ICollection<MissionTranslateDTO> MissionTranslates { get; set; }
        [Required]
        public string Icon { get; set; }
        [Required]
        public bool IsPublish { get; set; }
    }
}
