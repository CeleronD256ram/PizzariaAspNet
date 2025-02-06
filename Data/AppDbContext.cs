using Microsoft.EntityFrameworkCore;
using PizzariaAspNet.Models;

namespace PizzariaAspNet.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<PizzaModel> Pizzas { get; set; }





    }
}
