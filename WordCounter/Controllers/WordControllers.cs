using System;
using System.Collections.Generic;
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
  RepeatCounter newWord = new RepeatCounter(Request.Form["new-word"], Request.Form["new-_sentence"]);

//split the words
  string[] wordArray = RepeatCounter.SplitTheText(newWord.GetSentence());

//count the matching/loop
  int wordCount = RepeatCounter.CountTheWords(newWord.GetWord(), wordArray);

    newWord.SetCountWords(wordCount);
    return View("Index", newWord);
  }
 }
}
