using System;
using WebApplication1.Services;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class MyFakeDataService : IMyFakeDataService
    {
        public List<Instructor> InstructorList { get; }
        public List<Student> StudentList { get; }
        public MyFakeDataService()
        {
            StudentList = new List<Student>
            {
                new Student()
                {
                    Id= 1,FirstName = "Gabriel",LastName = "Montano", Course = Course.BSIT, AdmissionDate = DateTime.Parse("2022-08-26"), GPA = 1.5, Email = "ghaby021@gmail.com"
                },
                new Student()
                {
                    Id= 2,FirstName = "Zyx",LastName = "Montano", Course = Course.BSIS, AdmissionDate = DateTime.Parse("2022-08-07"), GPA = 1, Email = "zyx@gmail.com"
                },
                new Student()
                {
                    Id= 3,FirstName = "Aerdriel",LastName = "Montano", Course = Course.BSCS, AdmissionDate = DateTime.Parse("2020-01-25"), GPA = 1.5, Email = "aerdriel@gmail.com"
                }
            };

            InstructorList = new List<Instructor>
            {
                new Instructor()
                {
                    Id= 1,FirstName = "Gabriel",LastName = "Montano", Rank = Rank.Instructor, HiringDate = DateTime.Parse("2022-08-26"), IsTenured = true
                },
                new Instructor()
                {
                    Id= 2,FirstName = "Zyx",LastName = "Montano",  Rank = Rank.AssistantProfessor, HiringDate = DateTime.Parse("2022-08-07"), IsTenured = false
                }
      
            };
        }
    }
}
