using System.Collections.Generic;
using System;
using TamagotchiLifeCycle.Models;
using Microsoft.AspNetCore.Mvc;

namespace TamagatchiLifeCycle.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/tamagotchi")]
    public ActionResult New()
    { 
      return View();
    }

    [HttpPost("/tamagotchi/new")]
    public ActionResult Create(string name)
    {
      TAMAGO
    }
  }
}