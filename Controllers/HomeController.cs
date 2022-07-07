using DbOutOfNames.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;


namespace DbOutOfNames.Controllers
{
    public class HomeController : Controller
    {
        private PersonContext context { get; set; }
        public HomeController(PersonContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewDatabase()
        {
            var people = context.Persons.Include(m => m.Country).OrderBy(m => m.Email).ToList();
            return View(people);
        }
    }
}
