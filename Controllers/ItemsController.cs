using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HelloWorld.Models;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace HelloWorld.Controllers
{
  public class ItemsController: Controller
  {
    private readonly HelloWorldContext _db;
    public ItemsController(HelloWorldContext db)
    {
      _db = db;
    }

    //controller methods for if using pre-existing api with apiKey
    public ActionResult Index()
    {
      // List<Item> model = _db.Items.ToList();
      //var allItems = Item.GetItems(EnvironmentVariables.apiKey);
      return View();
    }
    // public async Task <ActionResult> Details(int id)
    // {
    //   var thisItem = Item.GetItem(EnvironmentVariables.apiKey, id);
    //   return View(thisItem);
    // }

    //api controller methods - if creating own api rather than using one with apiKey
    //[HttpGet]
    //public async Task<ActionResult<IEnumerable<Item>>> Get(args)
    // {
    //   var query = _db.Items.AsQueryable();
    //   if(arg != null){
    //     query.query.Where(entry => entry.Arg == arg);
    //   }
    //   return await query.ToList.Async();
    // }

    // [HttpGet("{id}")]
    // public async Task<IActionResult> GetItem(int id)
    // {
    //   var item = await _db.Items.FindAsync(id);
    //   if(item == null)
    //   {
    //     return NotFound();
    //   }
    //   return Ok(item);
    // }
  }
}