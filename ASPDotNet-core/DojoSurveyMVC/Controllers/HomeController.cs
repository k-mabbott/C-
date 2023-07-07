using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyMVC.Models;

namespace DojoSurveyMVC.Controllers;

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

    [HttpGet("After")]
    public IActionResult After(Survey info)
    {
        return View("After", info);
    }

    [HttpPost("submitted")]
    public IActionResult Submitted(Survey info)
    {   
        if(ModelState.IsValid)
        {
            return RedirectToAction("after", info);
        } else {
            return View("Index");
        }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
