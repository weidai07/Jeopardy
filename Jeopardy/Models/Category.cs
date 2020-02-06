using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Jeopardy.Models
{
  public class Category
  {

    public Category()
    {
      this.Questions = new HashSet<Question>();
    }
    [Key]
    public int Id { get; set; }
    public string CategoryId { get; set; }
    public string Title { get; set; }
    public string clues_count { get; set; }
    public virtual ICollection<Question> Questions { get; set; }


    public static List<Category> GetCategories(int num)
    {
      List<Category> OutList = new List<Category>();
      for(int i = 0; i < num; i++)
      {
        var apiCallTask = ApiHelper.ApiCallCategories();
        var result = apiCallTask.Result;
        JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);

        Category myCategory = new Category();
        myCategory.CategoryId = jsonResponse[0]["id"].ToString();
        myCategory.Title = jsonResponse[0]["title"].ToString();
        myCategory.clues_count = jsonResponse[0]["clues_count"].ToString();
        OutList.Add(myCategory);
      }
      return OutList;
    }
  }
}