using Microsoft.AspNetCore.Mvc;

namespace portfolioCore.ViewComponents
{
    public class _DefaultFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
