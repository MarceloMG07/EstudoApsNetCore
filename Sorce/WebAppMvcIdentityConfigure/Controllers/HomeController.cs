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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}