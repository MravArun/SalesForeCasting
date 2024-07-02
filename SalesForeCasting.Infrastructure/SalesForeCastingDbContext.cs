using Microsoft.EntityFrameworkCore;
using SalesForeCasting.Infrastructure.Entities;

namespace SalesForeCasting.Infrastructure;

public class SalesForeCastingDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("");
    }

    public List<Order> Orders { get; set; }
    
    

}