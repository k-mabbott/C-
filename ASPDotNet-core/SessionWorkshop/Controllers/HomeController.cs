using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SessionWorkshop.Models;

namespace SessionWorkshop.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

// ------------------------------LANDING PAGE / INDEX

    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

// ------------------------------LOGIN

    [HttpPost("success")]
    public IActionResult Success(string SesName)
    {
        HttpContext.Session.SetString("UserName", SesName);
        HttpContext.Session.SetInt32("UserNum", 5);
        return RedirectToAction("Dashboard");
    }

// ------------------------------LOGOUT

    [HttpPost("logout")]
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }

// ------------------------------DASHBOARD / SUCCESS

    [HttpGet("dashboard")]
    public IActionResult Dashboard()
    {
        if(HttpContext.Session.GetString("UserName") == null)
        {
            return RedirectToAction("Index");
        }

        return View("Dashboard");
    }

// ------------------------------MATH ROUTES

    [HttpPost("math")]
    public IActionResult Math(string amount)
    {
        int? TheNum = HttpContext.Session.GetInt32("UserNum");
        if(amount == "add")
        {
            TheNum += 1;
        } else if(amount == "sub") {
            TheNum -= 1;
        } else if(amount == "mult") {
            TheNum = TheNum + TheNum;
        } else if(amount == "rand") {
            Random rand = new Random();
            TheNum += rand.Next(1,11);
        }
        HttpContext.Session.SetInt32("UserNum", (int)TheNum);
        
        return RedirectToAction("Dashboard");
    }





    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
