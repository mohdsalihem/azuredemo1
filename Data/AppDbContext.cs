using Microsoft.EntityFrameworkCore;

namespace azuredemo1.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    public DbSet<Person> Persons { get; set; }
}
