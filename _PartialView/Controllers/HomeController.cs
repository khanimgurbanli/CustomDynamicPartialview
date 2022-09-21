using DynamicPartialView.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DynamicPartialView.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Intro> list = new List<Intro>
            {
                new Intro
            {
                Enterence = "Welcome Home",
                Description = "Here is for dynamic partial view page"
            },
                new Intro
            {
                Enterence = "Welcome Home list",
                Description = "Here is for dynamic partial view page list"
            }
           };

            return View(list);
        }
    }
}