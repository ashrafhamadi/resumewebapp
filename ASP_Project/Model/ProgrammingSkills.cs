using System.ComponentModel.DataAnnotations;

namespace ASP_Project.Model
{
    public class ProgrammingSkills
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
