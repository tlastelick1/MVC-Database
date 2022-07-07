using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using DbOutOfNames.Models;

namespace DbOutOfNames.Controllers
{
    public class PersonController : Controller
    {
        private PersonContext context { get; set; }
        public PersonController(PersonContext ctx)
        {
            context = ctx;
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Countrys
                = context.Countrys.OrderBy(g => g.Name).ToList();     // Changing from "Add" disable ability to add user once in the Registration Page. 
            return View("Edit", new Person());                       // Redirects to the Edit view 
        }
        [HttpGet]
        public IActionResult Edit(String id)
        {
            ViewBag.Action = "Edit";             // Changing from "Edit" breaks the Edit -> Edit on the edit user page. 
            ViewBag.Countrys
            = context.Countrys.OrderBy(g => g.Name).ToList();
            var people = context.Persons.Find(id);
            return View(people);
        }
        [HttpPost]
        public IActionResult Edit(Person person)
        {
            if (ModelState.IsValid)
            {
                if (!string.IsNullOrEmpty(person.Email))      // If the user does not exist then register the user 
                {
                    context.Persons.Add(person);
                    context.SaveChanges();
                    return View("RegisterSuccess");
                }
                else
                    return View("RegisterFail");   // Changed from "Index", "Home" to "Edit"
            }
            else
            {
                ViewBag.Action = (!string.IsNullOrEmpty(person.Email)) ? "Add" : "Edit";
                ViewBag.Countrys
                    = context.Countrys.OrderBy(g => g.Name).ToList();
                return View(person);
            }
        }
        [HttpGet]
        public IActionResult Delete(string id)
        {
            var people = context.Persons.Find(id);
            return View(people);
        }
        [HttpPost]
        public IActionResult Delete(Person person)
        {
            context.Persons.Remove(person);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Login(string id)
        {
            var peep = context.Persons.Find(id);
            return View(peep);
        }

        [HttpPost]
        public IActionResult Login(Person person)
        {
            //var peeps = context.Persons.OrderBy(m => m.Email).ToList();
            // if (person.Email ==  peeps)
                if (true)
                {
                    ViewBag.Action = person.First + " " + person.Last;
                    return View("LoginSuccess");
                }

            }

        }
    }