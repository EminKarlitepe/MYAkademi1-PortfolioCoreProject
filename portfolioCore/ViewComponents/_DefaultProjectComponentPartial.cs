using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using portfolioCore.Context;
using portfolioCore.Context;
using portfolioCore.Entities;

namespace portfolioCore.ViewComponents
{

    public class _DefaultProjectComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Portfolios.ToList();

            return View(values);
        }
        public IViewComponentResult GetProjectWithCategory(int id)
        {
            var values = context.Portfolios.Include(p => p.Category).Where(p => p.CategoryId == id).ToList();

            return View(values);
        }
    }
}