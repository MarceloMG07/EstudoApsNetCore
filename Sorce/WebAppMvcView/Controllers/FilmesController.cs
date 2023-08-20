using Microsoft.AspNetCore.Mvc;

namespace WebAppMvcView.Controllers
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
    }
}
