using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class MA1Controller : Controller
    {
        List<MA1> MA1List = new List<MA1>
            {
                new MA1()
                {
                    FirstName = "Juan",LastName = "Dela Cruz",IsTenured = true
                }
            };
        public IActionResult Index()
        {

            return View(MA1List);
        }
    }
}