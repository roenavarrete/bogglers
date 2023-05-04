using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Boggle_CSCE_361.Models;
using Boggle_CSCE_361.Controllers;
using System.Net;
using System.Net.Sockets;
using Newtonsoft.Json;

namespace Boggle_CSCE_361.Controllers;

public class HomeController : Controller
{
    private static string[,] board = BoardGenerationController.GenerateBoard();

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

        return View(board);
    }

    [HttpPost]
    public IActionResult GameOver(string inputWords)
    {
        string[] inputWordsArray = inputWords.Split(',');

        IWordPossibilityController wordVerifier = new WordPossibilityController();
        IWordScorerController scorer = new WordScorerController();
        List<string> validWords = new List<string>();
        int score = 0;

        for (int i = 0; i < board.GetLength(0); i++)
        {
	        for (int j = 0; j < board.GetLength(1); j++)
	        {
		        Console.Write(board[i, j]);
			}
	        Console.WriteLine();
        }

        for (int i = 0; i < inputWordsArray.Length; i++)
        {
            string word = inputWordsArray[i];
            if (wordVerifier.isWordPossibleGrid(board, word))
            {
                Console.WriteLine("valid word: " + word);
                validWords.Add(word);
                score += scorer.getScore(word);
            }
        }
        string[] validWordArray = validWords.ToArray();
        var model = (WordScorerController: validWordArray, Score: score);
        return View(model);
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