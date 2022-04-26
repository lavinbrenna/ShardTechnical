using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace HelloWorld.Models
{
  public class Item
  {
    //Item Properties
    public int ItemId {get;set;}
    public string Name{get;set;}
  }

  //public List GetAPIInfo Method (if getting list of items)
  //public static List<Item> GetItems(string apiKey)
  // {
  //   var apiCallTask = apiHelper.ListApiCall(apiKey);
  //   var result = apiCallTask.Result;
  //   JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
  //   List<Item> itemList = JsonConvert.DeserializeObject<List<Item>>(jsonResponse["results"].ToString());
  //   return itemList;
  // }

  //public Item GetAPIInfoMethod (if getting single item)
  // public static Item GetItem(string apiKey, int id)
  // {
  //   var apiCallTask = ApiHelper.ApiCall(apiKey, id);
  //   var result = apiCallTask.Result;
  //   JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
  //   Item thisItem = JsonConvert.DeserializeObject<Item>(jsonResponse.ToString());
  //   return thisItem;
  // }
}