using Microsoft.EntityFrameworkCore;
using WebAppEntityFramework.Models;

namespace WebAppEntityFramework.Data
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions<MeuDbContext> options) : base(options)
        {
            
        }

        public DbSet<Aluno> Alunos { get; set; }
    }
}
