using Microsoft.AspNetCore.Mvc;
using portfolioCore.Context;
using System;
using System.Linq;

namespace portfolioCore.ViewComponents
{
    public class _DefaultStatsComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            var stats = context.Stats.ToList();

            if (stats.Count >= 4)
            {
                var random = new Random();
                stats[3].StatsValue = random.Next(10, 21);
            }

            return View(stats);
        }
    }
}
