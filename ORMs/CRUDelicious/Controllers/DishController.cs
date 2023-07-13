using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers;

public class DishController : Controller
{
    private readonly ILogger<DishController> _logger;

    private MyContext DB;

    public DishController(ILogger<DishController> logger, MyContext context)
    {
        _logger = logger;
        DB = context;
    }

    // ---------------------------------LANDING PAGE / GET ALL DISHES
    [HttpGet("")]
    public IActionResult Index()
    {
        List<Dish> AllDishes = DB.Dishes.ToList();
        return View("Index", AllDishes);
    }

    // ---------------------------------NEW DISH FORM
    [HttpGet("dishes/new")]
    public IActionResult NewDish()
    {
        return View();
    }
    // ---------------------------------CREATE DISH POST ROUTE
    [HttpPost("dishes/create")]
    public IActionResult CreateDish(Dish newDish)
    {
        if (ModelState.IsValid)
        {
            DB.Add(newDish);
            DB.SaveChanges();
            return RedirectToAction("Index");
        }
        else
        {
            return View("NewDish");
        }
    }

    // ---------------------------------VIEW ONE DISH 
    [HttpGet("dishes/{dishId}")]
    public IActionResult OneDish(int  dishId)
    {
        Dish? oneDish = DB.Dishes.FirstOrDefault(d => d.DishId == dishId);
        if (oneDish == null)
        {
            return RedirectToAction("Index");
        }
        return View("OneDish", oneDish);
    }
    // ---------------------------------EDIT ONE DISH 
    [HttpGet("dishes/{dishId}/edit")]
    public IActionResult EditDish(int dishId)
    {
        Dish? oneDish = DB.Dishes.FirstOrDefault(d => d.DishId == dishId);
        if (oneDish == null)
        {
            return RedirectToAction("Index");
        }
        return View("EditDish", oneDish);
    }
    // ---------------------------------Update ONE DISH 
    [HttpPost("dishes/{dishId}/update")]
    public IActionResult UpdateDish(Dish editDish, int dishId)
    {
        Dish? dish = DB.Dishes.FirstOrDefault(d => d.DishId == dishId);

        if (dish == null)
        {
            return RedirectToAction("Index");
        }

        if (!ModelState.IsValid)
        {
            // return EditDish(dishId);
            return View("EditDish", dish);
        }

        dish.Name = editDish.Name;
        dish.Chef = editDish.Chef;
        dish.Tastiness = editDish.Tastiness;
        dish.Calories = editDish.Calories;
        dish.Description = editDish.Description;

        DB.Dishes.Update(dish);
        DB.SaveChanges();

        return RedirectToAction("OneDish", new {dishId = dishId});
    }
    // ---------------------------------------DELETE ONE DISH 
    [HttpPost("dishes/{dishId}/destroy")]
    public IActionResult DeleteDish(int dishId)
    {
        Dish? dish =  DB.Dishes.FirstOrDefault(d => d.DishId == dishId);
        if(dish != null)
        {
        DB.Dishes.Remove(dish);
        DB.SaveChanges();
        }
        return RedirectToAction("Index");
    }


    // public IActionResult Privacy()
    // {
    //     return View();
    // }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
