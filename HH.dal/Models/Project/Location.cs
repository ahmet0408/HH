using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.dal.Models.Project
{
    public class Location
    {
        public int Id { get; set; }
        //public ICollection<Project> Projects { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public bool IsPublish { get; set; }
        public ICollection<LocationTranslate> LocationTranslates { get; set; }
    }
}
