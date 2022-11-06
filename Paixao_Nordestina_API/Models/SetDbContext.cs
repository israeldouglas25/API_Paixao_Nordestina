using Microsoft.EntityFrameworkCore;

namespace Paixao_Nordestina_API.Models
{
    public class SetDbContext : DbContext
    {
        public SetDbContext(DbContextOptions<SetDbContext> options)
            : base(options) { }

        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
    }
}
