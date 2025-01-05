using Microsoft.EntityFrameworkCore;

namespace ProductAPI.Data
{
    public class ProductApiDbContext : DbContext
    {
        public ProductApiDbContext(DbContextOptions<ProductApiDbContext> options) : base(options)
        {
        }
    }
}
