using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.dal.Models.Project
{
    public class Status
    {
        public int Id { get; set; }
        //public ICollection<Project> Projects { get; set; }
        public ICollection<StatusTranslate> StatusTranslates { get; set; }
    }
}