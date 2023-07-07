using Microsoft.AspNetCore.Mvc;

namespace Dojo.Controllers;

public class DojoController : Controller
{

    List<string> FormInfo = new List<string>();


    //------------ HOME ------
    [HttpGet("")] 
    public ViewResult Index()
    {

        return View();
    }

    // [HttpGet("info")] 
    // public ViewResult Info()
    // {

    //     return View();
    // }

    [HttpPost("process")] 
    public IActionResult Process(string Name, string Location, string Language, string Comment)
    {
        ViewBag.name = Name;
        ViewBag.location = Location;
        ViewBag.lang = Language;
        ViewBag.comment = Comment;
        return View("Info");
    }

}