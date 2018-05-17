using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreMvc.Models;

namespace AspNetCoreMvc.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            var people = new List<Person>
            {
                new Person { Name = "Brandon" },
                new Person { Name = "David" },
                new Person { Name = "Cody" },
                new Person { Name = "Steven" },
                new Person { Name = "Jeff" },
                new Person { Name = "Lisa" },
                new Person { Name = "Chris" },
                new Person { Name = "Skylar" },
                new Person { Name = "Francesca" },
                new Person { Name = "Reid" },
                new Person { Name = "Trey" },
                new Person { Name = "Chip" }
            };

            return View(people);
        }
    }
}