using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.MissionDTO
{
    public class EditMissionDTO
    {
        public ICollection<MissionTranslateDTO> MissionTranslates { get; set; }
        public string Icon { get; set; }
        public bool IsPublish { get; set; }
    }
}
