using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Calculator model)
        {
            try
            {
                double result = model.Operation switch
                {
                    "Add" => model.Number1 + model.Number2,
                    "Subtract" => model.Number1 - model.Number2,
                    "Multiply" => model.Number1 * model.Number2,
                    "Divide" => model.Number2 != 0 ? model.Number1 / model.Number2 : throw new DivideByZeroException("Không thể chia cho 0"),
                    _ => throw new ArgumentException("Vui lòng chọn phép tính")
                };

                ViewBag.Result = result;
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
            }

            return View(model);
        }
    }
}
