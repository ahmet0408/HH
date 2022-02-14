using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.bll.DTOs.AboutUsDTO
{
    public class AboutUsDTO
    {

        public string Title { get; set; }
  
        public string Description {get; set;}
 
        public string Phone { get; set; }
  
        public string LocationAdress { get; set; }
     
        public string Image { get; set; }
    
        public string Mail { get; set; }
    }
}
