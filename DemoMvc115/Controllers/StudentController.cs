using Microsoft.AspNetCore.Mvc;
using DemoMvc115.Models;

namespace DemoMvc115.Controllers
{
    public class StudentController : Controller
    {
        // Hiển thị form nhập thông tin sinh viên
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // Nhận dữ liệu từ form (POST)
        [HttpPost]
        public IActionResult Create(Student sv)
        {
            if (ModelState.IsValid)
            {
                // Trả lại View và hiển thị thông tin sinh viên
                return View("Detail", sv);
            }
            return View();
        }
    }
}
