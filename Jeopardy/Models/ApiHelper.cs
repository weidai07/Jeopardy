using System.Threading.Tasks;
using RestSharp;

namespace MvcApiCall.Models
{
  class ApiHelper
  {
    public static async Task<string> ApiCallCategories()
    {
        RestClient client = new RestClient("https://jservice.io/api/");
        RestRequest request = new RestRequest($"categories?count=6", Method.GET);
        var response = await client.ExecuteTaskAsync(request);
        return response.Content;
    }

    public static async Task<string> ApiCall(string apiSearch)
    {
      RestClient client = new RestClient("https://jservice.io/api/");
      RestRequest request = new RestRequest($"{apiSearch}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}