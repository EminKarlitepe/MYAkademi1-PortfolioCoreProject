using Microsoft.AspNetCore.Mvc;
using portfolioCore.Context;
using portfolioCore.Entities;

namespace portfolioCore.Controllers
{
    public class SendMessage : Controller
    {
        PortfolioContext context = new PortfolioContext();
        [HttpPost]
        public IActionResult SendMessages(Message message)
        {

            context.Messages.Add(message);
            context.SaveChanges();
            ViewBag.Success = "Gönderim işlemi başarılı!";
            return View("~/Views/Default/Index.cshtml");
        }
    }
}
