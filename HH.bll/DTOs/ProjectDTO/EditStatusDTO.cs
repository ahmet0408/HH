﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.ProjectDTO
{
    public class EditStatusDTO
    {
        public int Id { get; set; }
        public ICollection<StatusTranslateDTO> Translates { get; set; }
    }
}
