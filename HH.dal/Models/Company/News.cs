using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.dal.Models.Company
{
    public class News
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public bool IsPublish { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public ICollection<NewsTranslate> NewsTranslates { get; set; }
    }
}
