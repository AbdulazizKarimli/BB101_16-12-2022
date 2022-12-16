using ConsoleApp.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp.DataAccess;

public class AppDbContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=B3-0\BS101;Database=CodeFirstDb;Trusted_Connection=true;");
    }
    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }
}
