using Microsoft.EntityFrameworkCore;

// this creates the context file to accessing the DB using the Entity framework

namespace CRUDelicious.Models
{
    public class DishContext : DbContext
    {
        public DishContext(DbContextOptions<DishContext> options) : base(options) { }
        public DbSet<Dish> Dishes{ get; set; }
    }
}