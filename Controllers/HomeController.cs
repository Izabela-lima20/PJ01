using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PJ01.Models;

namespace PJ01.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        try{

            throw new Exception("Erro especifico");
        TempData["Sucesso"]= "Erro na execuçao do sistema";
        }

        catch (Exception ex)
        {
        TempData["Erro"]= ex.Message;

        }
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
