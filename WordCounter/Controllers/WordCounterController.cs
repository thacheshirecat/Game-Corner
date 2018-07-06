using Microsoft.AspNetCore.Mvc;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
    [HttpGet("/WordCounter")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/WordCounter/CreateForm")]
    public ActionResult CreateForm()
    {
      return View();
    }
  }
}
