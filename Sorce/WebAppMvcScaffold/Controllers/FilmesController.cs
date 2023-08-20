using Microsoft.AspNetCore.Mvc;
using WebAppMvcScaffold.Models;

namespace WebAppMvcScaffold.Controllers
{
    //[Route("")]
    //[Route("Filmes")]
    public class FilmesController : Controller
    {
        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Adicionar(Filme filme)
        {
            if (ModelState.IsValid)
            {

            }
            return View(filme);
        }
    }
}
