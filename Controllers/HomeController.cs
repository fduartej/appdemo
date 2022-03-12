using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using appdemo.Models;

namespace appdemo.Controllers;

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

   public IActionResult Opcion1(Persona p)
    {
        Opciones(p,"Op1");
        ViewData["Message"] = "Hola estos son mis datos ";
        return View("Index", p);
    }

   public IActionResult Opcion2(Persona p)
    {
        Opciones(p,"Op2");
        ViewData["Message"] = "Hola estos son mis datos ";
        return View("Index", p);
    }

    private void Opciones(Persona p, String opcion){
        if(opcion=="Op1"){
            p.Nombre = "Juan";
            p.Apellido = "Perez";
            p.Genero = "Masculino";
            p.FechaVencimiento = new DateTime();
        }else{
            p.Nombre = "Juana";
            p.Apellido = "Perea";
            p.Genero = "Femenino";
            p.FechaVencimiento = new DateTime();
        }
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
