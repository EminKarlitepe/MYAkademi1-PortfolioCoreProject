using Microsoft.AspNetCore.Mvc;
using portfolioCore.Context;
using portfolioCore.Entities;

namespace portfolioCore.Controllers
{
    public class ResumeController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult EducationList()
        {
            var values = context.Resumes.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateResume()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateResume(Entities.Resume resume)
        {
            context.Resumes.Add(resume);
            context.SaveChanges();
            return RedirectToAction("EducationList");
        }
        public IActionResult DeleteResume(int id)
        {
            var value = context.Resumes.Find(id);
            context.Resumes.Remove(value);
            context.SaveChanges();
            return RedirectToAction("EducationList");
        }
        [HttpGet]
        public IActionResult UpdateResume(int id)
        {
            var value = context.Resumes.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateResume(Resume resume)
        {
            context.Resumes.Update(resume);
            context.SaveChanges();
            return RedirectToAction("EducationList");
        }
    }
}
