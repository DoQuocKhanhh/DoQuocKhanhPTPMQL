using Microsoft.AspNetCore.Mvc;

namespace DemoMvc115.Controllers
{
    public class FormDemoController : Controller
    {
        // Hiển thị form
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // Nhận dữ liệu từ form
        [HttpPost]
        public IActionResult Index(string name, int age)
        {
            ViewBag.Result = $"Xin chào {name}, bạn {age} tuổi!";
            return View();
        }
    }
}
