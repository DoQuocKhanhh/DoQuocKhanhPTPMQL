using Microsoft.AspNetCore.Mvc;

namespace DemoMvc115.Controllers
{
    public class DataDemoController : Controller
    {
        public IActionResult Index()
        {
            // Gửi dữ liệu sang View bằng 3 cách
            ViewBag.Message = "Xin chào từ ViewBag 👋";
            ViewData["Note"] = "Dữ liệu này gửi qua ViewData 📦";
            TempData["Temp"] = "Đây là TempData – tồn tại 1 request 🔁";

            return View();
        }

        public IActionResult ShowTemp()
        {
            // TempData tồn tại sang request tiếp theo
            var temp = TempData["Temp"];
            return Content($"TempData nhận được: {temp}");
        }
    }
}
