using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Jeopardy.Models;

namespace Jeopardy.Controllers
{
    public class AnswerController : Controller
    {
        [HttpGet("/answer")]
        public ActionResult Index()
        {
            // Console.WriteLine("\n\n\n\n\n\n\n\n\n\n" + MyBoard.Categories.ElementAt(1).Questions.ElementAt(1).Value + "\n\n\n\n\n\n\n\n\n\n");
            return View();
        }

        [HttpPost]
        public ActionResult IndexPost()
        {
            return RedirectToAction("Index", "JeopordyTable");
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
    }
}
