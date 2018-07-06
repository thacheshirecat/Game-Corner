using Microsoft.AspNetCore.Mvc;
using GameCorner.Models;

namespace GameCorner.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      RepeatCounter.ClearAll();
      return View();
    }
  }
}
