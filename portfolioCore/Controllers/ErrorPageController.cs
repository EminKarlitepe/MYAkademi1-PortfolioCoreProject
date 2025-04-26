using Microsoft.AspNetCore.Mvc;

namespace portfolioCore.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error404()
        {
            return View();
        }
    }
}
