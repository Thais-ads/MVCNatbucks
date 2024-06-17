using Microsoft.EntityFrameworkCore;
using NathBucks.Models;

namespace NathBucks.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<NathBucks.Models.Avaliacao>? Avaliacao { get; set; }
        public DbSet<NathBucks.Models.Cafeteria>? Cafeteria { get; set; }
        public DbSet<NathBucks.Models.Cardapio>? Cardapio { get; set; }
    }
}
