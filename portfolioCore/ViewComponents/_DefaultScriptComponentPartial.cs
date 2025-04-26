using Microsoft.AspNetCore.Mvc;

namespace portfolioCore.ViewComponents
{
    public class _DefaultScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
