using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.CompanyDTO
{
    public class License
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string File { get; set; }
        public bool IsPublish { get; set; }
    }
}
