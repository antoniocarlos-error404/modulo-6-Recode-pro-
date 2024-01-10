using Microsoft.EntityFrameworkCore;
using RecodePro2023_Modulo_6.Models;

namespace RecodePro2023_Modulo_6.Context
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        { }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Pacote> Pacote { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
    }
}
