using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Kittens.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

}