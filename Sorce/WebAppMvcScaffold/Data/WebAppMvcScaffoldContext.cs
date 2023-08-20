using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppMvcScaffold.Models;

namespace WebAppMvcScaffold.Data
{
    public class WebAppMvcScaffoldContext : DbContext
    {
        public WebAppMvcScaffoldContext (DbContextOptions<WebAppMvcScaffoldContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppMvcScaffold.Models.Filme> Filme { get; set; } = default!;
    }
}
