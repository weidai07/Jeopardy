using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Jeopardy.Models;
using System.Threading.Tasks;
using Jeopardy.ViewModels;
using Newtonsoft.Json;
using RestSharp;

namespace Jeopardy.Controllers
{
    public class JeopardyTableController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}