
using Microsoft.AspNetCore.Mvc;


namespace HelloWorld.Controllers
{
  public class HomeController : Controller
  {
    // private readonly HelloWorldContext _db;

    // public HomeController(HelloWorldContext db)
    // {
    //   _db = db;
    // }

    [HttpGet("/")]
    public ActionResult Index()
    {
      //var model = _db;
      return View();
    }
  }
}
