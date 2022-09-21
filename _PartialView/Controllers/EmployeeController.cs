using DynamicPartialView.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DynamicPartialView.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View(new Employee()
            {
                Age = 23,
                FirstName = "Khanim",
                LastName = "Gurbanli",
                Address = "Baku,Azerbaijan",
            });
        }
    }
}
