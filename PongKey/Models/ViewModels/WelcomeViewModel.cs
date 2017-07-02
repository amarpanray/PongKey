using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PongKey.Models.Welcome.ViewModels
{
    public class WelcomeViewModel
    {
        [Required]
        public string Name { get; set; }
    }
}