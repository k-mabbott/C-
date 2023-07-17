using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TheWall.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace TheWall.Controllers;

[SessionCheck]
public class MessageController : Controller
{
    private readonly ILogger<MessageController> _logger;

    private MyContext DB;


    public MessageController(ILogger<MessageController> logger, MyContext context)
    {
        _logger = logger;
        DB = context;
    }


    // -----------------------------INDEX PAGE
    [HttpGet("messages")]
    public IActionResult Index()
    {

        MessageViewModel MessagesModel = new MessageViewModel();

        MessagesModel.Messages = DB.Messages.Include(a => a.Creator).Include(m => m.Comments).ThenInclude(c => c.Commentor).ToList();

        return View(MessagesModel);
    }

    [HttpPost("messages/create")]
    public IActionResult CreateMessage(Message newMessage)
    {
        if (!ModelState.IsValid)
        {
            MessageViewModel MessagesModel = new MessageViewModel();
            MessagesModel.Messages = DB.Messages.Include(a => a.Creator).Include(m => m.Comments).ThenInclude(c => c.Commentor).ToList();
            return View("Index", MessagesModel);
        };
        int? UID = HttpContext.Session.GetInt32("UserId");
        if(UID != null)
        {
            newMessage.UserId = (int)UID;
            DB.Messages.Add(newMessage);
            DB.SaveChanges();
        }
        return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}


public class SessionCheckAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        int? userId = context.HttpContext.Session.GetInt32("UserId");
        if (userId == null)
        {
            context.Result = new RedirectToActionResult("Index", "User", null);
        }
    }
}