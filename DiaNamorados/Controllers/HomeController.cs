using DiaNamorados.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DiaNamorados.Controllers
{
    public class HomeController : Controller
    {
        public string motivo = "";
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Motivos(int I)
        {
            Random randNum = new Random();
            var numero = randNum.Next(10);

            NumeroMotivo(numero);
            ViewData["Motivos"] = motivo;
            return View("Index");
        }

        public string NumeroMotivo(int numero)
        {
            switch (numero)
            {
                case 0:
                    motivo = "000";
                    return motivo;

                case 1:
                    motivo = "AAA";
                    return motivo;

                case 2:
                    motivo = "BBB";
                    return motivo;
                    
                case 3:
                   motivo = "CCCC";
                    return motivo;
                    
                case 4:
                    motivo = "D";
                    return motivo;
                    
                case 5:
                    motivo = "E";
                    return motivo;
                    
                case 6:
                    motivo = "F";
                    return motivo;
                    
                case 7:
                    motivo = "G";
                    return motivo;
                    
                case 8:
                    motivo = "H";
                    return motivo;
                    
                case 9:
                    motivo = "I";
                    return motivo;
                    
                case 10:
                    motivo = "J";
                    return motivo;
                    
            }
            return motivo;
        }
    }
}