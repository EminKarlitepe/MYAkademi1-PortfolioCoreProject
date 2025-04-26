using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using portfolioCore.Context;
using portfolioCore.Entities;

namespace portfolioCore.Controllers
{
    public class SocialMediaController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        private List<SelectListItem> GetIconList()
        {
            return new List<SelectListItem>
            {
                new SelectListItem { Text = "Twitter", Value = "bi bi-twitter-x" },
                new SelectListItem { Text = "Facebook", Value = "bi bi-facebook" },
                new SelectListItem { Text = "Instagram", Value = "bi bi-instagram" },
                new SelectListItem { Text = "LinkedIn", Value = "bi bi-linkedin" },
                new SelectListItem { Text = "YouTube", Value = "bi bi-youtube" },
                new SelectListItem { Text = "GitHub", Value = "bi bi-github" }
            };
        }

        public IActionResult SocialMediaList()
        {
            var values = context.SocialMedias.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateSocialMedia()
        {
            ViewBag.IconList = GetIconList();
            return View();
        }

        [HttpPost]
        public IActionResult CreateSocialMedia(SocialMedia socialMedia)
        {
            if (ModelState.IsValid)
            {
                context.SocialMedias.Add(socialMedia);
                context.SaveChanges();
                return RedirectToAction("SocialMediaList");
            }
            ViewBag.IconList = GetIconList();
            return View(socialMedia);
        }

        public IActionResult DeleteSocialMedia(int id)
        {
            var values = context.SocialMedias.Find(id);
            context.SocialMedias.Remove(values);
            context.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }

        [HttpGet]
        public IActionResult UpdateSocialMedia(int id)
        {
            var socialMedia = context.SocialMedias.Find(id);
            if (socialMedia == null)
            {
                return NotFound();
            }

            ViewBag.IconList = GetIconList();
            return View(socialMedia);
        }

        [HttpPost]
        public IActionResult UpdateSocialMedia(SocialMedia socialMedia)
        {
            if (ModelState.IsValid)
            {
                context.SocialMedias.Update(socialMedia);
                context.SaveChanges();
                return RedirectToAction("SocialMediaList");
            }

            ViewBag.IconList = GetIconList();
            return View(socialMedia);
        }
    }
}
