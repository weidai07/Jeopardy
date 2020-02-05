using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Jeopardy.Models;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using System;

namespace Jeopardy.Controllers
{
    public class JeopardyTableController : Controller
    {
        private readonly JeopardyContext _db;

        public JeopardyTableController(JeopardyContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            var holder = Category.GetCategories(6);
            foreach(Category cat in holder)
            {
                var thisCategory = _db.Categories.FirstOrDefault();
                _db.Categories.Remove(thisCategory);
                _db.Categories.Add(cat);
                _db.SaveChanges();
            }
            return View();
        }

        public ActionResult Redirect()
        {
            return RedirectToAction("Index", "JeopardyTable");
        }
    }
}
