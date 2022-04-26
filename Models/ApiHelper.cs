using System.Threading.Tasks;
using RestSharp;
using System;

namespace HelloWorld.Models
{
  public class ApiHelper
  {
    public static async Task<string> ListApiCall(string apiKey)
    {
      RestClient client = new RestClient("apiUrl");
      RestRequest request = new RestRequest("api query string with api_key={apiKey}");
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> SingleApiCall(string apiKey, int id)
    {
      RestClient client = new RestClient("apiUrl");
      RestRequest request = new RestRequest("api query string with {id} & api_key={apiKey}");
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}