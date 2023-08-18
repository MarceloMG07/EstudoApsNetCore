using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppMvc1.Models;

namespace WebAppMvc1.Controllers
{
    [Route("")]
    [Route("MinhaRotaPorAtributo")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        [Route("Inicio")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("TesteInicio")]
        [Route("TesteInicio/{id:int}/{categoria?}")]
        //https://localhost:7207/TesteInicio/5/Monitores?fiscal=true
        //https://localhost:7207/TesteInicio/5?fiscal=true
        public IActionResult Teste(int id, string categoria, bool fiscal)
        {
            return View("Index");
        }

        [Route("Privacidade")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [Route("Erro")]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}