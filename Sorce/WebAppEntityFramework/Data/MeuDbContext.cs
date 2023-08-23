using Microsoft.EntityFrameworkCore;

namespace WebAppEntityFramework.Data
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions<MeuDbContext> options) : base(options)
        {
            
        }
    }
}
