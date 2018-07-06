using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

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

    [HttpPost("/WordCounter/Result")]
    public ActionResult Result(string singleword, string manywords)
    {
      RepeatCounter newCount = new RepeatCounter(singleword, manywords);
      return View(newCount);
    }
  }
}
