using Microsoft.AspNetCore.Mvc;

namespace portfolioCore.ViewComponents
{
    public class _DefaultPortfolioComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
