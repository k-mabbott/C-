using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormSubmission.Models;

namespace FormSubmission.Controllers;

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

    public IActionResult Success()
    {
        DateTime dob = (DateTime)SuccessInfo.DateOfBirth;
        ViewBag.Date = dob.ToString("dddd, dd MMMM yyyy");
        // DateTime dob = DateTime.TryParse(SuccessInfo?.DateOfBirth);
        return View("Success", SuccessInfo);
    }

    static FormInfo? SuccessInfo;

    [HttpPost("process")]
    public IActionResult Process(FormInfo info)
    {
        Console.WriteLine(info.Name);
        Console.WriteLine(info.Email);
        Console.WriteLine(info.DateOfBirth);
        Console.WriteLine(info.Password);
        Console.WriteLine(info.FavOddNum);
        
        if(ModelState.IsValid)
        {
            SuccessInfo = info;
            return RedirectToAction("success");
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
