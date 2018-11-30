using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCounterSpace.Models;

namespace WordCounterSpace.Controllers
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
