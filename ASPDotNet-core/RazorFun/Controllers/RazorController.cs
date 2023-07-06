using Microsoft.AspNetCore.Mvc;

namespace RazorFun.Controllers;

public class RazorController : Controller
{
    [HttpGet("")] 
    public ViewResult Index()
    {
        // ViewBag.Name = "Kyle"; // One way to pass Data to a View.
        return View();
    }
}