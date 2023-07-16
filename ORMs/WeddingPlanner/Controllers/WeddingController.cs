using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WeddingPlanner.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WeddingPlanner.Controllers;

[SessionCheck]
public class WeddingController : Controller
{
    private readonly ILogger<WeddingController> _logger;

private MyContext DB;


    public WeddingController(ILogger<WeddingController> logger, MyContext context)
    {
        _logger = logger;
        DB = context;
    }
//  --------------------------Home Page
    [HttpGet("weddings")]
    public IActionResult Index()
    {
        List<Wedding> allWeddings = DB.Weddings.Include(w => w.Guests).ThenInclude( g => g.User).ToList();

        return View(allWeddings);
    }

//  --------------------------New Wedding
    [HttpGet("weddings/new")]
    public IActionResult NewWedding()
    {

        return View();
    }


//  --------------------------Create Wedding POST
    [HttpPost("weddings/create")]
    public IActionResult CreateWedding(Wedding newWedding)
    {
        if(!ModelState.IsValid)
        {
            return View("NewWedding");
        }
        int? userId = HttpContext.Session.GetInt32("UserId");
        if(userId != null)
        {
            newWedding.UserId = (int)userId;
        }
        DB.Weddings.Add(newWedding);
        DB.SaveChanges();
        return RedirectToAction("Index");
    }

//  --------------------------One Wedding
    [HttpGet("weddings/{weddingId}")]
    public IActionResult OneWedding(int weddingId)
    {
        Wedding? OneWedding = DB.Weddings.Include( e => e.Guests ).ThenInclude( g => g.User ).FirstOrDefault( w => w.WeddingId == weddingId);
        return View(OneWedding);
    }


//  --------------------------Create Wedding RSVP POST
    [HttpPost("weddingrsvp/create")]
    public IActionResult HandleRsvp(int weddingId)
    {
        int? UID = HttpContext.Session.GetInt32("UserId");
        
        if(UID == null ) return RedirectToAction("Index", "User");
        
        WeddingRsvp? existingRsvp = DB.WeddingRsvps.FirstOrDefault( r => r.UserId == UID && r.WeddingId == weddingId);
        
        if (existingRsvp != null)
        {
            DB.WeddingRsvps.Remove(existingRsvp);
        }
        else
        {
            WeddingRsvp newRsvp = new WeddingRsvp()
            {
                WeddingId = weddingId,
                UserId = UID.Value
            };
            DB.WeddingRsvps.Add(newRsvp);
        }
        DB.SaveChanges();
        return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

//  --------------------------Delete Wedding POST
    [HttpPost("weddings/delete/{weddingId}")]
    public IActionResult DeleteWedding(int weddingId)
    {
        Wedding? exists = DB.Weddings.FirstOrDefault( w => w.WeddingId == weddingId);
        if(exists != null)
        {
            DB.Weddings.Remove(exists);
            DB.SaveChanges();
        }
        return RedirectToAction("Index");
    }


}





public class SessionCheckAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        int? userId = context.HttpContext.Session.GetInt32("UserId");
        if(userId == null)
        {
            context.Result = new RedirectToActionResult("Index", "User", null);
        }
    }
}