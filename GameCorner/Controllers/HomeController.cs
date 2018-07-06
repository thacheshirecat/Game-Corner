using Microsoft.AspNetCore.Mvc;

namespace GameCorner.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}
