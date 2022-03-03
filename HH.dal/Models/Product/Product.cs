using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.dal.Models.Product
{
    public class Product
    {
        public int Id { get; set; }
        public bool IsPublish { get; set; }
        public string Image { get; set; }
        public int SortOrder { get; set; }
        public string RequestFile { get; set; }
        public string DownloadFile { get; set; }
        public ICollection<ProductOption> ProductOption { get; set; } 
        public ICollection<ProductTranslate> ProductTranslates { get; set;}
    }
}
