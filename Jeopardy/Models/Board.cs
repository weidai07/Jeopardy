// using System.Collections.Generic;
// using Newtonsoft.Json;
// using Newtonsoft.Json.Linq;
// using System;

// namespace Jeopardy.Models
// {
//   public class Board
//   {
//     public List<Category> Category_Instances = new List<Category>();

//     public Board()
//     {

//         _instances.Add(this);
//     }

//     public void GetCategories()
//     {
//       var apiCallTask = ApiHelper.ApiCallCategories();
//       var result = apiCallTask.Result;
//       JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      
//     for (int i = 0; i < jsonResponse.Count; i++)
//     {
//         Category myCategory = new Category();
//         myCategory.Id = jsonResponse[i]["id"].ToString();
//         myCategory.Title = jsonResponse[i]["title"].ToString();
//         myCategory.clues_count = jsonResponse[i]["clues_count"].ToString();
//         this.Categories.Add(myCategory);
//     }
        
//       foreach(Category category in Categories)
//       {
//             category.GetQuestions(category.Id);
//       }
//     }
//   }
// }