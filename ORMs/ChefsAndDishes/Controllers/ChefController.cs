using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ChefsAndDishes.Models;
using Microsoft.EntityFrameworkCore;

namespace ChefsAndDishes.Controllers;

public class ChefController : Controller
{
    private readonly ILogger<ChefController> _logger;

    private MyContext DB;

    public ChefController(ILogger<ChefController> logger, MyContext context)
    {
        _logger = logger;
        DB = context;
    }

    // ---------------------------------LANDING PAGE / GET ALL ChefS
    [HttpGet("")]
    public IActionResult Index()
    {
        List<Chef> AllChefs = DB.Chefs.Include(chef => chef.AllDishes).ToList();
        return View(AllChefs);
    }

    // ---------------------------------NEW Chef FORM
    [HttpGet("chefs/new")]
    public IActionResult NewChef()
    {
        return View();
    }
    // ---------------------------------CREATE Chef POST ROUTE
    [HttpPost("chefs/create")]
    public IActionResult CreateChef(Chef newChef)
    {
        if (ModelState.IsValid)
        {
            DB.Add(newChef);
            DB.SaveChanges();
            return RedirectToAction("Index");
        }
        else
        {
            return View("NewChef");
        }
    }
}