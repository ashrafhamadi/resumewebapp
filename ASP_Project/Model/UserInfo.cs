using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASP_Project.Model
{
    public class UserInfo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Date Of Birth")]
        public string DateOfBirth { get; set; }
        [Required]
        public string Nationality { get; set; }
        [Required]
        public string Gender { get; set; }
        public string Grade { get; set; }
        [Required]
        [Display(Name = "Programming Skills")]
        public ICollection<ProgrammingSkills> ProgrammingSkills { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
    }
}
