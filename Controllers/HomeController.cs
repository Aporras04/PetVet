using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PetVet.Models;

namespace PetVet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult LogIn()
    {
        return View();
    }

    public IActionResult MisMascotas()
    {
        return View();
    }

    public IActionResult NuevaMascota()
    {
        return View();
    }

    public IActionResult Perfil()
    {
        return View();
    }

    public IActionResult PerfilMascota()
    {
        return View();
    }

    public IActionResult Veterinarias()
    {
        return View();
    }

    public IActionResult Mascotas()
    {
        return View();
    }

    public IActionResult Usuarios()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

