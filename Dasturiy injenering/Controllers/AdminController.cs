using Microsoft.AspNetCore.Mvc;

namespace Dasturiy_injenering.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
