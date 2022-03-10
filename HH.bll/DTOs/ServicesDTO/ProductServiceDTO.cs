using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.ServicesDTO
{
    public class ProductServiceDTO
    {
        public int ServiceId { get; set; } = -1;
        public int ProductId { get; set; } = -1;
        public string Name { get; set; }
        public string ShortDesc { get; set; }
        public string Image { get; set; }
    }
}
