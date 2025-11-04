using Microsoft.AspNetCore.Mvc;


namespace DemoMvc115.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            ViewData ["Message"] = "Buổi 3";
            return View();
        }
    }
}