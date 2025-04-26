using Microsoft.AspNetCore.Mvc;

namespace portfolioCore.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
