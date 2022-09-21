using DynamicPartialView.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DynamicPartialView.Controllers
{
    public class PhoneController : Controller
    {
        public IActionResult Index()
        {
            return View(new Phone()
            {
               PhoneNumber= "5034562923",
               Owner="Khanim Gurbanli"
            });
        }
    }
}
