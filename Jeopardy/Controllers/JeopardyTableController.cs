using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Jeopardy.Models;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace Jeopardy.Controllers
{
    public class JeopardyTableController : Controller
    {
        public ActionResult Index()
        {
            Board MyBoard = new Board();
            MyBoard.GetCategories();
            return View();
        }
    }
}