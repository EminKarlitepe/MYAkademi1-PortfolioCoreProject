using Microsoft.AspNetCore.Mvc;

namespace portfolioCore.ViewComponents
{
    public class _DefaultHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}