using Microsoft.AspNetCore.Mvc;
using portfolioCore.Context;

namespace portfolioCore.ViewComponents
{
    public class _DefaultServiceComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Services.Take(6).ToList(); // take 6 ile veri tabanından 6 tanesini çekiyorum
            return View(values);
        }
    }
}
