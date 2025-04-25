using Microsoft.EntityFrameworkCore;
using Portfolio.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<TesteTable> TesteTable { get; set; } // Nome da propriedade deve corresponder à tabela
}