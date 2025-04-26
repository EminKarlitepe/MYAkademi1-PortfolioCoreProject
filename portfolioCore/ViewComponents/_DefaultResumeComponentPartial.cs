using Microsoft.AspNetCore.Mvc;
using portfolioCore.Context;

namespace portfolioCore.ViewComponents
{
    public class _DefaultResumeComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var value = context.Resumes.ToList();
            return View(value);
        }
    }
}
