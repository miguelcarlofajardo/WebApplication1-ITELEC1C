using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> InstructorList = new List<Instructor>
            {
                new Instructor()
                {
                    Id= 1,FirstName = "Gabriel",LastName = "Montano", Rank = Rank.Instructor, HiringDate = DateTime.Parse("2022-08-26"), IsTenured = true
                },
                new Instructor()
                {
                    Id= 2,FirstName = "Zyx",LastName = "Montano",  Rank = Rank.AssistantProfessor, HiringDate = DateTime.Parse("2022-08-07"), IsTenured = false
                },
                new Instructor()
                {
                    Id= 3,FirstName = "Aerdriel",LastName = "Montano",  Rank = Rank.AssociateProfessor, HiringDate = DateTime.Parse("2020-01-25"), IsTenured = false
                },
                 new Instructor()
                {
                    Id= 4,FirstName = "Juan",LastName = "Dela Cruz",  Rank = Rank.Professor, HiringDate = DateTime.Parse("2020-07-25"), IsTenured = true
                }
            };
        public IActionResult Index()
        {

            return View(InstructorList);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the instructor whose id matches the given id
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)//was an instructor found?
                return View(instructor);

            return NotFound();
        }

    }
}