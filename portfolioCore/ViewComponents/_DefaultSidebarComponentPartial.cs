using Microsoft.AspNetCore.Mvc;

namespace portfolioCore.ViewComponents
{
    public class _DefaultSidebarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
