using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public enum Rank
    {
        Instructor, AssistantProfessor, AssociateProfessor, Professor
    }

    public class Instructor
   
    {
        [Required]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string? FirstName { get; set; }

        [Display(Name = "First Name")]
        public string? LastName { get; set; }

        [Display(Name = "Is tenured")]
        public bool IsTenured {  get; set; }

        [Display(Name = "Academic rank")]
        public Rank Rank { get; set; }

        [Display(Name = "Hiring date")]
        public DateTime HiringDate { get; set; }


    }

}