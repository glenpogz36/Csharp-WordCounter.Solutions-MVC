using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class WordCounterController : Controller
    {
      [HttpGet("/word")]
      public ActionResult Index()
      {
        return View();
      }

      [HttpGet("/word/new")]
      public ActionResult CreateForm()
      {
        return View();
      }

      [HttpPost("/word")]
      public ActionResult Index(string word, string sentence)
      {
      RepeatCounter newCount = new RepeatCounter(word, sentence);
      return View(newCount);
      }
    }

  }
