using Microsoft.AspNetCore.Mvc;
using GameCorner.Models;

namespace GameCorner.Controllers
{
  public class ScrabbleScoreController : Controller
  {
    [HttpGet("/ScrabbleScore")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/ScrabbleScore/CreateForm")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/ScrabbleScore/Result")]
    public ActionResult Result(string theword)
    {
      Word newScore = new Word(theword);
      return View(theword);
    }
  }
}
