using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppMvcIdentityConfigure.Helpers;
using WebAppMvcIdentityConfigure.Models;

namespace WebAppMvcIdentityConfigure.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            throw new Exception("Teste Erro!");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Secreto()
        {
            return View("Privacy");
        }

        [Authorize(Policy = "PodeExcluir")]
        public IActionResult SecretoClaim()
        {
            return View("Privacy");
        }

        [ClaimsAuthorize("Produto","Ler")]
        public IActionResult ClaimCustom()
        {
            return View("Privacy");
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [Route("erro/{id:length(3,3)}")]
        public IActionResult Error(int id)
        {
            var modelError = new ErrorViewModel();

            switch (id)
            {
                case 500:
                    modelError.Message = "Ocorreu um erro! Tente novamente mais tarde ou contate nosso suporte.";
                    modelError.Title = "Ocirreu um erro!";
                    modelError.ErrorCode = id;
                    break;
                case 403:
                    modelError.Message = "Você não tem permissão para fazer isso.";
                    modelError.Title = "Acesso Negado!";
                    modelError.ErrorCode = id;
                    break;
                default:
                    modelError.Message = "A página que você esta procurando não existe! <br />Em caso de dúvidas entre em contato com nosso suporte.";
                    modelError.Title = "Ocirreu um erro!";
                    modelError.ErrorCode = id;
                    break;
            }

            return View("Error", modelError);
            //return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}