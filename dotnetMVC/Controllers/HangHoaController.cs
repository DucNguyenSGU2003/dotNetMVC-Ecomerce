using Microsoft.AspNetCore.Mvc;

namespace dotnetMVC.Controllers
{
    public class HangHoaController : Controller
    {
        public IActionResult Index(int? loai)
        {
            return View();
        }
    }
}
