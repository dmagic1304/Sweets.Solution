using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Sweets.Models
{
  public class SweetsContext : IdentityDbContext<ApplicationUser>
  // public class RecipeBoxContext : DbContext
  {
    public DbSet<Treat> Treats { get; set; }

    public DbSet<Flavor> Flavors { get; set; }    

    public SweetsContext(DbContextOptions options) : base(options) { }
  }
}