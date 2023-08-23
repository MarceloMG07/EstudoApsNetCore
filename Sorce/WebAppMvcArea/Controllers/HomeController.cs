using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppMvcArea.Models;

namespace WebAppMvcArea.Controllers
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

        [Route("FilmeErro")]
        public IActionResult FilmErro()
        {
            var filme = new Filme()
            {
                Titulo = "Oi",
                DataLancamento = DateTime.Now,
                Genero = null,
                Avaliacao = 10,
                Valor = 5000
            };
            return RedirectToAction("ResultFilm", filme);
        }

        [Route("Filme")]
        public IActionResult Film()
        {
            var filme = new Filme()
            {
                Titulo = "Aprendendo a Programar",
                DataLancamento = DateTime.Now,
                Genero = "Realidade",
                Avaliacao = 5,
                Valor = 999
            };
            return RedirectToAction("ResultFilm", filme);
        }

        [Route("CadastrarFilme")]
        public IActionResult AddFilm()
        {
            return Content("Qualquer coisa");
        }

        [Route("RetornaFilme")]
        public IActionResult ResultFilm(Filme filme)
        {
            if (!ModelState.IsValid)
            {
                foreach (var error in ModelState.Values.SelectMany(e => e.Errors))
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }

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