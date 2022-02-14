using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.ProjectDTO
{
    public class CreateStatusDTO
    {
        public ICollection<StatusTranslateDTO> StatusTranslates { get; set; }
    }
}
