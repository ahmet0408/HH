using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.AboutUsDTO
{
    public class About
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDesc { get; set; }
        public string Description { get; set; }
        public string MainImage { get; set; }
        public string LocationAdress { get; set; }
        public string Image { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Mail { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public bool IsPublish { get; set; }
    }
}
