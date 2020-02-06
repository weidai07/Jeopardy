using System.Threading.Tasks;
using RestSharp;
using System;

namespace Jeopardy.Models
{
  class ApiHelper
  {
    public static async Task<string> ApiCallCategories()
    {
        RestClient client = new RestClient("http://jservice.io/api/");
        RestRequest request = new RestRequest($"categories?offset={ApiHelper.RandomNumber(1,1000)}count=1", Method.GET);
        var response = await client.ExecuteTaskAsync(request);
        return response.Content;
    }

    public static async Task<string> ApiCall(string apiSearch)
    {
      RestClient client = new RestClient("http://jservice.io/api/");
      RestRequest request = new RestRequest($"{apiSearch}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static int RandomNumber(int min, int max)  
    {  
        Random random = new Random();  
        return random.Next(min, max);  
    }  
  }
}