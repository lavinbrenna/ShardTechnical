using Microsoft.EntityFrameworkCore;

namespace HelloWorld.Models
{
  public class HelloWorldContext : DbContext

  {
    // public DbSet<Item> Items {get;set;}
    public HelloWorldContext(DbContextOptions<HelloWorldContext> options):base(options)
    {
    }
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}