using Microsoft.AspNetCore.Mvc;

namespace MVCRefresh.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
