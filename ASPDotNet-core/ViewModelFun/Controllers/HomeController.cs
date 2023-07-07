using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        string words = "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Magnam et corporis, sit earum ratione inventore laudantium dignissimos, dolores neque deleniti voluptatem ipsum exercitationem enim provident, sapiente eum tenetur voluptatibus! Consequatur.";
        return View("index", words);
    }

    public IActionResult Numbers()
    {
        int[] nums = new int[] {1,2,10,21,8,7,3};
        return View("numbers", nums);
    }
    public IActionResult user()
    {
        User John = new User("John", "Doe");
        return View("User", John);
    }
    public IActionResult Users()
    {
        User John = new User("John", "Doe");
        User Jane = new User("Jane", "Doe");
        User Jimmy = new User("Jimmy", "Doe");
        User Jared = new User("Jared", "Doe");
        User Jayme = new User("Jayme", "Doe");
        List<User> UserList = new List<User>() {John, Jane, Jimmy, Jared, Jayme};
        return View("Users", UserList);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
