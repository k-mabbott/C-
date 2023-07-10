using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FollowAlong.Models;

namespace FollowAlong.Controllers;

public class HomeController : Controller
{
    public static Game[] AllGames = new Game[]
    {
        new Game {Title="Red Dead Redemption 2", Price=59.00, Genre="Western", Rating="M", Platform="PS4"},
        new Game {Title="Spiderman", Price=59.00, Genre="Superhero", Rating="T", Platform="Xbox"},
        new Game {Title="FFXIV", Price=15.00,Genre="MMO RPG",Rating="T",Platform="PC and PS4/PS5"},
        new Game {Title="Zelda Tears of the Kingdom", Price=59.00, Genre="Role-Playing-Game", Rating="E", Platform="Switch"},
        new Game {Title="Phasmophobia", Price=16.00, Genre="Survival Game", Rating="T", Platform="PC"},
        new Game {Title="Dragon Age: Inquistion", Price=10.99, Genre="RPG", Rating="E", Platform="PC"},
        new Game {Title="The Last of Us", Price=59.00, Genre="Horror", Rating="M", Platform="PlayStation"},
        new Game {Title="Elden Ring", Price=59.99, Genre="Action RPG", Rating="M", Platform="PC"},
        new Game {Title="League of Legends", Price=0.00, Genre="MOBA", Rating="T", Platform="PC"},
        new Game {Title="World of Warcraft", Price=39.99, Genre="MMORPG", Rating="T", Platform="PC"},
        new Game {Title="Elder Scrolls Online", Price=14.99, Genre="Action RPG", Rating="M", Platform="PC"},
        new Game {Title="Smite", Price=0.00, Genre="MOBA", Rating="T", Platform="All"},
        new Game {Title="Overwatch", Price=39.00, Genre="First-person Shooter", Rating="T", Platform="PC"},
        new Game {Title="Scarlet Nexus", Price=59.99, Genre="Action JRPG", Rating="T", Platform="All"},
        new Game {Title="Wonderlands", Price=59.99, Genre="RPG FPS", Rating="M", Platform="All"},
        new Game {Title="Rocket League", Price=0.00, Genre="Sports", Rating="E", Platform="All"},
        new Game {Title="StarCraft", Price=0.00, Genre="RTS", Rating="T", Platform="PC"},
        new Game {Title="God of War", Price=29.99, Genre="Action-adventure ", Rating="M", Platform="PC"},
        new Game {Title="Doki Doki Literature Club Plus!", Price=10.00, Genre="Casual", Rating="E", Platform="PC"},
        new Game {Title="Red Dead Redemption", Price=40.00, Genre="Action adventure", Rating="M", Platform="All"},
        new Game {Title="My Little Pony A Maretime Bay Adventure", Price=39.99, Genre="Adventure", Rating="E",Platform="All"},
        new Game {Title="Fallout New Vegas", Price=10.00, Genre="Open World RPG", Rating="M", Platform="PC"}
    };
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Game> allGamesFromData = AllGames.OrderBy(g => g.Price ).ThenBy(p => p.Title).ToList();
        ViewBag.AllTheGames = allGamesFromData;
        List<Game> allPlatforms = AllGames.Where(p => p.Platform == "All" || p.Rating == "T" ).ToList();
        ViewBag.AllPlatforms = allPlatforms;
        List<Game> allMGames = AllGames.Where( f => f.Rating == "M").OrderBy( a => a.Price ).ToList();
        ViewBag.AllMGames = allMGames;
        Game thisOne = AllGames.Where(g => g.Rating == "M").OrderBy(f => f.Price).First();
        ViewBag.ThisOne = thisOne;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
