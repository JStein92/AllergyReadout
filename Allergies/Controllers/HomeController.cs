using Microsoft.AspNetCore.Mvc;
using Allergies.Models;
using System.Collections.Generic;
using System;

namespace Allergies.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/AllergiesResult")]
    public ActionResult AllergiesResult()
    {
      AllergiesScore myScore = new AllergiesScore(int.Parse(Request.Form["score"]));
      List<string> myAllergies = myScore.ReadBinary();
      return View(myAllergies);
    }
  }
}
