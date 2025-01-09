using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProductAPI.Models;

namespace ProductAPI.Data
{
    public class ProductApiDbContext : IdentityDbContext
    {
        public ProductApiDbContext(DbContextOptions<ProductApiDbContext> options) : base(options)
        {
        }
        
        public DbSet<Product> Products { get; set; }
    }
}
