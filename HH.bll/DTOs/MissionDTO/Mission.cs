using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.MissionDTO
{
    public class Mission
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 
        public string Icon { get; set; }
        public bool IsPublish { get; set; }
    }
}
