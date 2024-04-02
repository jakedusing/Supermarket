using Microsoft.AspNetCore.Mvc;

namespace MVCRefresh.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
