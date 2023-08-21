using Microsoft.AspNetCore.Mvc;

namespace AspNet.MVC.DoZero.Controlllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
