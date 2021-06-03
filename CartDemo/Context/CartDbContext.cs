using CartDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace CartDemo.Context
{
    public class CartDbContext : DbContext
    {
        public CartDbContext(DbContextOptions<CartDbContext> contextOptions):base(contextOptions)
        {

        }
        public DbSet<Category> Categories { get; set; }
    }
}
