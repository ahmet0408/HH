using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.dal.Models.Mission
{
    public class Mission
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        public bool IsPublish { get; set; }
        public string iconCode { get; set; }
        public ICollection<MissionTranslate> MissionTranslates { get; set; }
    }
}
