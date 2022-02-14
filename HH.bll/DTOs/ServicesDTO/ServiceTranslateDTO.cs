﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.ServicesDTO
{
    public class ServiceTranslateDTO
    {
        public string Name { get; set; }
        public string ShortDesc { get; set; }
        public string Description { get; set; }
        public string LanguageCulture { get; set; }
        public int ServiceId { get; set; }
    }
}
