using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcApp.Models;
using System.Web;

namespace MvcApp.Controllers
{
    public class HomeController : Controller
    {
      static List<Person> people = new List<Person>()
                        {
                            new Person("Bill Gates"),
                            new Person("Albert Einstein")
                        };
      public IActionResult Index()
      {
        return View();
      }

      public IActionResult About()
      {
        ViewData["Message"] = "Your application description page.";

        return View();
      }

      public IActionResult Contact()
      {
        ViewData["Message"] = "Your contact page.";

        return View();
      }

      public IActionResult Privacy()
      {
        return View();
      }

      [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
      public IActionResult Error()
      {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
      }

      public IActionResult People()
      {
        return View(people);
      }

      public IActionResult Person(Guid id)
      {
        var person = people.SingleOrDefault(p => p.Id == id);
        return View(person);
      }
      
    }
}
