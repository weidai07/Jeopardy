using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Jeopardy.Models
{
  public class Category
  {
    public string Id { get; set; }
    public string Title { get; set; }
    public string clues_count { get; set; }
    public List<Question> Questions { get; set; }

    public Category()
    {
        this.Questions = new List<Question>();
    }

    public void GetQuestions(string id)
    {
      string searchTerm = "/clues?category=" + id;
      var apiCallTask = ApiHelper.ApiCall(searchTerm);
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);

      for (int i = 0; i < jsonResponse.Count; i++)
      {
        Question myQuestion = new Question();
        myQuestion.Id = jsonResponse[i]["id"].ToString();
        myQuestion.Answer = jsonResponse[i]["answer"].ToString();
        myQuestion.Body = jsonResponse[i]["question"].ToString();
        myQuestion.Value = jsonResponse[i]["value"].ToString();
        this.Questions.Add(myQuestion);
      }
    }
  }
}