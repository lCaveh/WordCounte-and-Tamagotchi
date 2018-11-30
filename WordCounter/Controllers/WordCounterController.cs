using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCounterSpace.Models;
using System;

namespace WordCounterSpace.Controllers
{
  public class WordCounterController : Controller
  {

    [HttpGet("/WordCounter/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/WordCounter")]
    public ActionResult Create(string word, string sentence)
    {
      WordCounter wordCounter = new WordCounter(word, sentence);
      if (wordCounter.IsValid())
      {
        wordCounter.ChangeToLowerCase();
        wordCounter.ChangeSentenceToWords();
        return View("Index",wordCounter);
      }
      else
      {
        return View("New");
      }
    }
  }
}
