using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.dal.Models.Mission
{
    public class MissionTranslate
    {
        public int Id { get; set; }
        public int MissionId { get; set; }
        public Mission Mission { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LanguageCulture { get; set; }

    }
}
