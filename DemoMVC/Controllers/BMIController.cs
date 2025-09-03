using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class BMIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(BMIModel model)
        {
            if (model.ChieuCao <= 0)
            {
                ModelState.AddModelError("", "Chiều cao phải lớn hơn 0!");
                return View(model);
            }

            double bmi = model.TinhBMI();
            string ketQua;

            if (bmi < 18.5)
                ketQua = "Gầy";
            else if (bmi < 24.9)
                ketQua = "Bình thường";
            else if (bmi < 29.9)
                ketQua = "Thừa cân";
            else
                ketQua = "Béo phì";

            ViewBag.BMI = bmi;
            ViewBag.KetQua = ketQua;

            return View(model);
        }
    }
}
