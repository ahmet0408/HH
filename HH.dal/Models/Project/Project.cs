using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.dal.Models.Project
{
    public class Project
    {
        public int Id { get; set; }
        public bool IsPublish { get; set; }
        public string Image { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int ClientId { get; set; }
        public int LocationId { get; set; }
        //public Location Location { get; set; }
        public int StatusId { get; set; }
        //public Status Status { get; set; }
        public ICollection<ProjectTranslate> ProjectTranslates { get; set; }    
    }
}
