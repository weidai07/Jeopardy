using Microsoft.AspNetCore.Mvc;
using Jeopardy.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Jeopardy.Controllers
{
  public class JeopardyTableController : Controller
  {

    [HttpGet("/JeopardyTable")]  
    public ActionResult Index()
    {
      return View();
    }
  }

}