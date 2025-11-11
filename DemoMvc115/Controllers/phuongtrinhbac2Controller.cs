using System;
using Microsoft.AspNetCore.Mvc;

namespace DemoMvc115.Controllers
{
    public class phuongtrinhbac2Controller : Controller
    {
        [HttpGet]
        public IActionResult GiaiPTB2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GiaiPTB2(double a, double b, double c)
        {
            string ketQua;

            if (a == 0)
            {
                if (b == 0)
                    ketQua = (c == 0) ? "Phương trình vô số nghiệm" : "Phương trình vô nghiệm";
                else
                    ketQua = $"Phương trình có nghiệm: x = {-c / b}";
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                    ketQua = "Phương trình vô nghiệm";
                else if (delta == 0)
                    ketQua = $"Phương trình có nghiệm kép x1 = x2 = {-b / (2 * a)}";
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    ketQua = $"Phương trình có 2 nghiệm phân biệt: x1 = {x1}, x2 = {x2}";
                }
            }

            ViewBag.KetQua = ketQua;
            return View();
        }
    }
}
