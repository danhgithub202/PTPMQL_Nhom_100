using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace DemoMVC.Controllers
{
    public class PersonController : Controller
    { 
        
        public IActionResult Index()
        {
            return View();
        } 
      

        public string Welcome()
        {
            return "XIN CHAO!";
        }
    }
}
