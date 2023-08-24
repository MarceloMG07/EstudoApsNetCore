using Microsoft.AspNetCore.Mvc;
using WebAppEntityFramework.Data;
using WebAppEntityFramework.Models;

namespace WebAppEntityFramework.Controllers
{
    public class TesteController : Controller
    {
        private readonly MeuDbContext _context;

        public TesteController(MeuDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var aluno = new Aluno
            {
                Nome = "Marcelo Gonçalves",
                Email = "marcelo07@shiel.com",
                DataNascimento = DateTime.Now
            };

            _context.Alunos.Add(aluno);
            _context.SaveChanges();

            var aluno2 = _context.Alunos.Find(aluno.Id);

            var aluno3 = _context.Alunos.FirstOrDefault(a => a.Email == "marcelo07@shield.com");

            aluno.Nome = "Astrogildo";
            _context.Alunos.Update(aluno);
            _context.SaveChanges();

            _context.Alunos.Remove(aluno);
            _context.SaveChanges();

            return View();
        }
    }
}
