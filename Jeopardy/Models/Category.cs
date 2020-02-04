using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Jeopardy.Models
{
  public class Category
  {
    public string Id { get; set; }
    public string Title { get; set; }
    public List<Question> Questions { get; set; }

    public Category()
    {
        this.Questions = new List<Question>();
    }

    public void GetQuestions(string apiSearch)
    {
      var apiCallTask = ApiHelper.ApiCall(apiSearch);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      this.Questions = JsonConvert.DeserializeObject<List<Question>>(jsonResponse["results"].ToString());
    }
  }
}