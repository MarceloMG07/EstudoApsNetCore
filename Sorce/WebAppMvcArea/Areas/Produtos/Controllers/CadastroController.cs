using Microsoft.AspNetCore.Mvc;

namespace WebAppMvcArea.Areas.Produtos.Controllers
{
    [Area("Produtos")]
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Buscar()
        {
            return View();
        }
    }
}
