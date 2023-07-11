using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstConnection.Models;

namespace FirstConnection.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private MyContext _context;   // ADDED HERE

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {        
        _logger = logger; 
        _context = context;    // ADDED HERE
    }

    public IActionResult Index()
    {
        return View();
    }


// --------------------------------CREATE NEW USER

    [HttpPost("users/create")]
    public IActionResult CreateUser(User newUser)
    {
        if(ModelState.IsValid)
        {
            _context.Add(newUser);
            _context.SaveChanges();
            return RedirectToAction("Privacy");
        } else {
            return View("Index");
        }
    }

    [HttpGet("privacy")]
    public IActionResult Privacy()
    {
        List<User> AllUsers = _context.Users.ToList();
        User? OneUser = _context.Users.FirstOrDefault(u => u.FirstName == "Kyle");
        ViewBag.user = OneUser;
        ViewBag.AllUsers = AllUsers;
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
