using Microsoft.AspNetCore.Mvc;

namespace AnyarT.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }

    }
}
