using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Boggle_CSCE_361.Models;
using Boggle_CSCE_361.Controllers;
using System.Net;
using System.Net.Sockets;

namespace Boggle_CSCE_361.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
	    return View();
    }

    [HttpPost]
    public IActionResult Connect(string ipAddress, string connectionType)
    {
	    // Connect to the IP address here

	    return View("Connected");
    }

	public IActionResult Game()
    {

        return View(BoardGenerationController.GenerateBoard());
    }

    [HttpPost]
    public JsonResult CheckWord(string wordInput)
    {
        // Process the user's word guess here
        bool isCorrect = WordCheck.CheckIfWordIsCorrect(wordInput);
        return Json(new { IsCorrect = isCorrect });
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