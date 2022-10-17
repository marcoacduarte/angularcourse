using Microsoft.EntityFrameworkCore;
using Core.Entities;

namespace Infrastructure.Data
{
  public class APIDbContext : DbContext
  {
    public APIDbContext(DbContextOptions<APIDbContext> options) : base(options)
    {
    }
    public DbSet<Product> Products { get; set; }
  }
}