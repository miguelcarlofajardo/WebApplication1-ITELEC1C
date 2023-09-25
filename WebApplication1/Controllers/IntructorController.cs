using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;


namespace WebApplication1.Controllers
{
    public class InstructorController : Controller
    {
        private readonly IMyFakeDataService _fakeData;
        public InstructorController(IMyFakeDataService fakeData)
        {
            _fakeData = fakeData;

        }
        public IActionResult Index()
        {

            return View(_fakeData.InstructorList);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the instructor whose id matches the given id
            Instructor? instructor = _fakeData.InstructorList.FirstOrDefault(st => st.Id == id);

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
            _fakeData.InstructorList.Add(newInstructor);
            return View("Index", _fakeData.InstructorList);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Instructor? instructor = _fakeData.InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }
        [HttpPost]
        public IActionResult Edit(Instructor instructorChange)
        {
            Instructor? instructor = _fakeData.InstructorList.FirstOrDefault(st => st.Id == instructorChange.Id);

            if (instructor != null)
            {
                instructor.Id = instructorChange.Id;
                instructor.FirstName = instructorChange.FirstName;
                instructor.LastName = instructorChange.LastName;
                instructor.IsTenured = instructorChange.IsTenured;
                instructor.Rank = instructorChange.Rank;
                instructor.HiringDate = instructorChange.HiringDate;
            }
            return View("Index", _fakeData.InstructorList);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Instructor? instructor = _fakeData.InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }

        [HttpPost]
        public IActionResult Delete(Instructor instructorRemove)
        {
            Instructor? instructor = _fakeData.InstructorList.FirstOrDefault(st => st.Id == instructorRemove.Id);
            if (instructor != null)
            {
                _fakeData.InstructorList.Remove(instructor);
                return View("Index", _fakeData.InstructorList);
            }

            return View("Index");
        }

    }

   
}