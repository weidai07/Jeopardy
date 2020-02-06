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
            var CategoryHolder = Category.GetCategories(6);

            foreach(Category cat in CategoryHolder)
            {
                var firstCategory = _db.Categories.FirstOrDefault();
                if(firstCategory != null)
                _db.Categories.Remove(firstCategory);
                _db.Categories.Add(cat);
                var QuestionHolder = Question.GetQuestions(cat.CategoryId, 5);
                foreach(Question q in QuestionHolder)
                {
                    var firstQuestion = _db.Questions.FirstOrDefault();
                    if(firstQuestion != null)
                    _db.Questions.Remove(firstQuestion);
                    _db.Questions.Add(q);
                }
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
