using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Jeopardy.Models
{
  public class Board
  {
    public List<Category> Categories { get; set; }

    public Board()
    {
        this.Categories = new List<Category>();
    }

    public void GetCategories()
    {
      var apiCallTask = ApiHelper.ApiCallCategories();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
    //   this.Categories = JsonConvert.DeserializeObject<List<Category>>(jsonResponse["results"].ToString());
      
    foreach (var item in jsonResponse)
    {
        this.Categories = JsonConvert.DeserializeObject<List<Category>>(item.ToString());
    }

      foreach(Category category in Categories)
      {
            category.GetQuestions(category.Id);
      }
    }
  }
}