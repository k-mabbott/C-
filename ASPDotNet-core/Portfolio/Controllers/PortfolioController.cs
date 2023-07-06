using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers;

public class PortfolioController : Controller
{
    //------------ HOME ------
    [HttpGet("")] 
    public ViewResult Index()
    {
        // ViewBag.Name = "Kyle"; // One way to pass Data to a View.
        return View();
    }

    //------------ PROJECTS ------
    [HttpGet("projects")] 
    public ViewResult Projects()
    {
        return View();
    }

    //------------ CONTACT ------
    [HttpGet("contact")] 
    public ViewResult Contact()
    {
        return View();
    }
}