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
      public ActionResult Create()
      {
        RepeatCounter newWord = new RepeatCounter(Request.Form["new-word"],Request.Form["new-sentence"]);
       string[] wordsArray = RepeatCounter.SplitText(newWord.GetSentence());

       int wordCount = RepeatCounter.CountTheWords(newWord.GetWord(),wordsArray);
       newWord.SetCountWords(wordCount);
       return View("Index", newWord);
      }
    }
}
