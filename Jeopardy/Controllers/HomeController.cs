using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Jeopardy.Models;

namespace Jeopardy.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // bool a2 = false;
            // bool a4 = false;
            // bool a6 = false;
            // bool a8 = false;
            // bool a10 = false;
            // bool b2= false;
            // bool b4 = false;
            // bool b6 = false;
            // bool b8 = false;
            // bool b10 = false;
            // bool c2 = false;
            // bool c4 = false;
            // bool c6 = false;
            // bool c8 = false;
            // bool c10 = false;
            // bool d2 = false;
            // bool d4 = false;
            // bool d6 = false;
            // bool d8 = false;
            // bool d10 = false;
            // bool e2 = false;
            // bool e4 = false;
            // bool e6 = false;
            // bool e8 = false;
            // bool e10 = false;
            // bool f2 = false;
            // bool f4 = false;
            // bool f6 = false;
            // bool f8 = false;
            // bool f10 = false;
            
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
    }
}
