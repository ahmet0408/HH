using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.ProjectDTO
{
    public class EditLocationDTO
    {
        public int Id { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public bool IsPublish { get; set; }
        public ICollection<LocationTranslateDTO> LocationTranslates { get; set; }
    }
}
