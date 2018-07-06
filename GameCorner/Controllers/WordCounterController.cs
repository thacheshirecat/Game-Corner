using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using GameCorner.Models;

namespace GameCorner.Controllers
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

    [HttpPost("/WordCounter/Results")]
    public ActionResult Results()
    {
      List<RepeatCounter> allCounts = RepeatCounter.GetAll();
      return View(allCounts);
    }
  }
}
