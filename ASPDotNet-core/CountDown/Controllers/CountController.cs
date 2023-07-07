using Microsoft.AspNetCore.Mvc;

namespace CountDown.Controllers;

public class CountController : Controller
{
    //------------ HOME ------
    [HttpGet("")] 
    public ViewResult Index()
    {
        DateTime cur = DateTime.Now.ToLocalTime();
        DateTime later = new DateTime(2023, 9, 25, 8, 00, 00);
        TimeSpan diff = later - cur;
        ViewBag.CurrDate = cur.ToString("dddd, dd MMMM yyyy h:mm:tt");
        ViewBag.LaterDate = later.ToString("dddd, dd MMMM yyyy h:mm:tt");
        ViewBag.Diff = diff.ToString("d' Day(s) 'hh' Hour(s) 'mm' Minute(s) 'ss' Second(s)'");

        return View();
    }

}