using Microsoft.EntityFrameworkCore;
using PapelariaAPI.Models;

namespace PapelariaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<PapelariaAPI.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<PapelariaAPI.Models.Fornecedor> Fornecedor { get; set; } = default!;
        public DbSet<PapelariaAPI.Models.Produto> Produto { get; set; } = default!;
        public DbSet<PapelariaAPI.Models.Venda> Venda { get; set; } = default!;
    }
}
