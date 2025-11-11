using System;
using Microsoft.AspNetCore.Mvc; // dùng cho ASP.NET Core MVC

namespace DemoMvc115.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        public IActionResult NhapThongTin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NhapThongTin(string ten, int namSinh)
        {
            int tuoi = DateTime.Now.Year - namSinh;
            ViewBag.Ten = ten;
            ViewBag.Tuoi = tuoi;
            return View("KetQuaThongTin");
        }
    }
}
