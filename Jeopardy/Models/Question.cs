using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Jeopardy.Models
{
  public class Question
  {
    public int Id { get; set; }
    public string QuestionId { get; set; }
    public string Answer { get; set; }
    public string Body { get; set; }
    public string Value { get; set; }
    public string CatId { get; set; }
    public virtual Category Category { get; set; }

    public static List<Question> GetQuestions(string id, int num)
    {
      string searchTerm = "/clues?category=" + id;
      List<Question> OutList = new List<Question>();
      var apiCallTask = ApiHelper.ApiCall(searchTerm);
      var result = apiCallTask.Result;
      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      for (int i = 0; i < num; i++)
      { 
        // this returns five results not one V
        Question myQuestion = new Question();
        myQuestion.QuestionId = jsonResponse[i]["id"].ToString();
        myQuestion.Answer = jsonResponse[i]["answer"].ToString();
        myQuestion.Body = jsonResponse[i]["question"].ToString();
        myQuestion.Value = jsonResponse[i]["value"].ToString();
        myQuestion.CatId = jsonResponse[i]["category_id"].ToString();
        OutList.Add(myQuestion);
      }
      return OutList;
    }
  }
}