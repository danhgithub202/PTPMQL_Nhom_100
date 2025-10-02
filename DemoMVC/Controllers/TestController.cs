using DemoMVC.Models.Process;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class TestController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string inputId)
        {
            GenCode gen = new GenCode();
            string newCode = gen.AutoGenCode(inputId);

            ViewBag.InputId = inputId;
            ViewBag.NewCode = newCode;

            return View();
        }
    }
}
