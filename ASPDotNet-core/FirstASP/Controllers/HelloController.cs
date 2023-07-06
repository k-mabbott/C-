using Microsoft.AspNetCore.Mvc;

namespace FirstASP.Controllers;

public class HelloController : Controller
{
    [HttpGet("")] // We will go over this in more detail on the next page    
    public ViewResult Index()
    {
        // return "Hello World from HelloController!";
        // return View("Index"); // Works the same as letting it grab the name.
        ViewBag.Name = "Kyle"; // One way to pass Data to a View.
        return View();
    }

    // Route declaration Option B
    // This will go to "localhost:5XXX/user/more"
    // [HttpGet("user/more")]
    // public string User()
    // {
    //     return "Hello user";
    // }

    // [HttpGet("greet/{name}")]
    // public string Greet(string name)
    // {
    //     return $"Hello {name}!";
    // }

    // [HttpGet("greet/{name}/{time}")]
    // // When testing the time input, use only whole numbers
    // public string GreetTime(string name, int time)
    // {
    //     return $"Hello {name}! It is currently {time} o'clock!";
    // }

    // // Post request example
    // // This will go to "localhost:5XXX/submission"
    // [HttpPost]
    // [Route("submission")]
    // // Don't worry about what the form is doing for now. We'll get to those soon!
    // // Note: You will not be able to navigate to this route! This is for demonstration only!
    // public string FormSubmission(string formInput)
    // {
    //     // Logic for post request here
    //     return "I handled a request!";
    // }
}

