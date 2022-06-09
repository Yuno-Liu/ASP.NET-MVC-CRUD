using FoodWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodWeb.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Product { get; set; }
}