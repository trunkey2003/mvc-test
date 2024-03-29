﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvc_test.Models;

namespace mvc_test.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Hello()
    {
        return View();
    }

    public IActionResult JSON()
    {
       return Json(new {foo="bar", baz="Blech"});
    }

[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
public IActionResult Error()
{
    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
}
}
