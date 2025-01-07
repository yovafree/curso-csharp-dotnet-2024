using Microsoft.EntityFrameworkCore;

namespace Ejemplo1.Models;
public class AppDBContext : DbContext
{
    public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
    {
    }

    protected override void OnConfiguring
       (DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase(databaseName: "AppDBContext");
    }

    public DbSet<Client> Clients { get; set; }
}