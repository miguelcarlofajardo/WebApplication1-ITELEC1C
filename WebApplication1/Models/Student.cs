using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public enum Course
    {
        BSIT, BSCS, BSIS, OTHER
    }

    public class Student
    {

        [Required]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string? FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        [Required]
        public double GPA { get; set; }

        [Display(Name = "Course")]
        public Course Course { get; set; }

        [Display(Name = "Admission Date")]
        public DateTime AdmissionDate { get; set; }

        [Display(Name = "Email")]
        public string? Email { get; set; }

    }
}