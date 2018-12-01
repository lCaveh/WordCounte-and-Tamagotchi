using Microsoft.AspNetCore.Mvc;
using WordCounterSpace.Models;
using System.Collections.Generic;
using System;

namespace WordCounterSpace.Controllers
{
  public class TamagotchiController : Controller
  {

    [HttpGet("/tamagotchi")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/tamagotchi/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/tamagotchi")]
    public ActionResult Create(string name)
    {
      Tamagotchi mytamagotchi = new Tamagotchi(name);
      return View("Index", mytamagotchi);
    }

    [HttpPost("/tamagotchi/addattention")]
    public ActionResult addattention(string amount)
    {
      Tamagotchi.currentTamagotchi.Play(Int32.Parse(amount));
      Tamagotchi.currentTamagotchi.ChangeImage();
      if (Tamagotchi.currentTamagotchi.EndGame())
      {
        return View("EndGame");
      }
      else
      {
        return View("Index", Tamagotchi.currentTamagotchi);
      }
    }
    [HttpPost("/tamagotchi/addfood")]
    public ActionResult addfood(string amount)
    {
      Tamagotchi.currentTamagotchi.Feed(Int32.Parse(amount));
      Tamagotchi.currentTamagotchi.ChangeImage();
      if (Tamagotchi.currentTamagotchi.EndGame())
      {
        return View("EndGame");
      }
      else
      {
      return View("Index", Tamagotchi.currentTamagotchi);
      }
    }
    [HttpPost("/tamagotchi/addrest")]
    public ActionResult addrest(string amount)
    {
      Tamagotchi.currentTamagotchi.Rest(Int32.Parse(amount));
      Tamagotchi.currentTamagotchi.ChangeImage();
      if (Tamagotchi.currentTamagotchi.EndGame())
      {
        return View("EndGame");
      }
      else
      {
      return View("Index", Tamagotchi.currentTamagotchi);
      }
    }
    [HttpPost("/tamagotchi/passtime")]
    public ActionResult passtime()
    {
      Tamagotchi.currentTamagotchi.PassingTime();
      Tamagotchi.currentTamagotchi.ChangeImage();
      if (Tamagotchi.currentTamagotchi.EndGame())
      {
        return View("EndGame");
      }
      else
      {
      return View("Index", Tamagotchi.currentTamagotchi);
      }
    }
  }
}
