using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using portfolioCore.Context;
using portfolioCore.Entities;

namespace portfolioCore.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        public IActionResult PortfolioList()
        {
            var values = context.Portfolios.Include(x => x.Category).ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreatePortfolio()
        {
            var categoryList = new SelectList(context.Categories.ToList(), "CategoryId", "CategoryName");
            ViewBag.CategoryList = categoryList;
            return View();
        }

        [HttpPost]
        public IActionResult CreatePortfolio(Portfolio portfolio)
        {
            if (ModelState.IsValid)
            {
                context.Portfolios.Add(portfolio);
                context.SaveChanges();
                return RedirectToAction("PortfolioList");
            }

            var categoryList = new SelectList(context.Categories.ToList(), "CategoryId", "CategoryName");
            ViewBag.CategoryList = categoryList;
            return View(portfolio);
        }

        public IActionResult DeletePortfolio(int id)
        {
            var values = context.Portfolios.Find(id);
            context.Portfolios.Remove(values);
            context.SaveChanges();
            return RedirectToAction("PortfolioList");
        }

        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            var portfolio = context.Portfolios.Find(id);
            if (portfolio == null)
            {
                return NotFound();
            }

            var categoryList = new SelectList(context.Categories.ToList(), "CategoryId", "CategoryName", portfolio.CategoryId);
            ViewBag.CategoryList = categoryList;
            return View(portfolio);
        }

        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio portfolio)
        {
            if (ModelState.IsValid)
            {
                var existingPortfolio = context.Portfolios.Find(portfolio.PortfolioId);
                if (existingPortfolio != null)
                {
                    existingPortfolio.Title = portfolio.Title;
                    existingPortfolio.Description = portfolio.Description;
                    existingPortfolio.ImageUrl = portfolio.ImageUrl;
                    existingPortfolio.CategoryId = portfolio.CategoryId;

                    context.SaveChanges();
                    return RedirectToAction("PortfolioList");
                }

                return NotFound();
            }

            var categoryList = new SelectList(context.Categories.ToList(), "CategoryId", "CategoryName", portfolio.CategoryId);
            ViewBag.CategoryList = categoryList;
            return View(portfolio);
        }
    }
}
