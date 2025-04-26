using Microsoft.AspNetCore.Mvc;
using portfolioCore.Context;
using portfolioCore.Entities;

namespace portfolioCore.Controllers
{
    public class StatsController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult StatsList()
        {
            var values = context.Stats.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateStats()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateStats(Stats stats)
        {
            context.Stats.Add(stats);
            context.SaveChanges();
            return RedirectToAction("StatsList");
        }
        public IActionResult DeleteStats(int id)
        {
            var value = context.Stats.Find(id);
            context.Stats.Remove(value);
            context.SaveChanges();
            return RedirectToAction("StatsList");
        }
        [HttpGet]
        public IActionResult UpdateStats(int id)
        {
            var value = context.Stats.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateStats(Stats stats)
        {
            context.Stats.Update(stats);
            context.SaveChanges();
            return RedirectToAction("StatsList");
        }
    }
}
