using CadastroDePessoas.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroDePessoas.Contexto
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
