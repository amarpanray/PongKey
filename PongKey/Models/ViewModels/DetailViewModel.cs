using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
//using System.Device.Location;

namespace PongKey.Models.Welcome.ViewModels
{
    public class DetailViewModel
    {
        [Required]//possibly the only required field
        public string Name { get; set; }

        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; } 
        
        public string Post { get; set; } 
        public string Reply { get; set; }  
        public string Guest { get; set; }            
    }
}