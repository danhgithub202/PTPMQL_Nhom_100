using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class HienthituoiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Person model)
        {
            int age = DateTime.Now.Year - model.BirthYear;
            ViewBag.Age = age;
            return View(model);
        }
    }
}
