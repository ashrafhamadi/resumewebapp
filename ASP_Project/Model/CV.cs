using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASP_Project.Model
{
    public class CV
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Confirm Email")]
        
        public string ConfirmEmail { get; set; }

        [Required]
        public int ValidationX { get; set; }

        [Required]
        public int ValidationY { get; set; }

        [Required]
        public int ValidationZ { get; set; }


       

    }
}
