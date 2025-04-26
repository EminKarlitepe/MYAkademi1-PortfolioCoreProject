using Microsoft.AspNetCore.Mvc;
using portfolioCore.Entities;
using portfolioCore.Context;

namespace portfolioCore.ViewComponents
{
    public class _DefaultMessageComponentPartial : ViewComponent
    {

        public IViewComponentResult Invoke()
        {

            return View(new Message());
        }
    }
}
