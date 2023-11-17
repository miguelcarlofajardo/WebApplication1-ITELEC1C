using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Services;


namespace WebApplication1.Controllers
{
    public class InstructorController : Controller
    {
        private readonly AppDbContext _dbContext;
        public InstructorController(AppDbContext dbContext)
        {
            _dbContext = dbContext;

        }
        public IActionResult Index()
        {

            return View(_dbContext.Instructors);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the instructor whose id matches the given id
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(st => st.Id == id);

            if (instructor != null)//was an instructor found?
                return View(instructor);

            return NotFound();
        }

        [HttpGet]
        public IActionResult AddInstructor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddInstructor(Instructor newInstructor)
        {
            if (!ModelState.IsValid)
                return View();
       
            _dbContext.Add(newInstructor);
            //_dbContext.SaveChanges(); project wont save the new information
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(st => st.Id == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }
        [HttpPost]
        public IActionResult Edit(Instructor instructorChange)
        {
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(st => st.Id == instructorChange.Id);

            if (instructor != null)
            {
                instructor.Id = instructorChange.Id;
                instructor.FirstName = instructorChange.FirstName;
                instructor.LastName = instructorChange.LastName;
                instructor.IsTenured = instructorChange.IsTenured;
                instructor.Rank = instructorChange.Rank;
                instructor.HiringDate = instructorChange.HiringDate;
                _dbContext.SaveChanges();

            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(st => st.Id == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }

        [HttpPost]
        public IActionResult Delete(Instructor instructorRemove)
        {
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(st => st.Id == instructorRemove.Id);
            if (instructor != null)
            {
                _dbContext.Instructors.Remove(instructor);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("Index");
        }

    }

   
}