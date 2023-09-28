using Microsoft.AspNetCore.Mvc;

namespace WebAppMvcIdentityConfigure.Controllers
{
    public class TesteController : Controller
    {
        private readonly ILogger _logger;

        public TesteController(ILogger<TesteController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogError("Este erro aconteceu!");

            return View();
        }
    }
}
