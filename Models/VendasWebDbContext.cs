using Microsoft.EntityFrameworkCore;

namespace vendas_web.Models
{
    public class VendasWebDbContext : DbContext
    {
        public VendasWebDbContext(DbContextOptions<VendasWebDbContext> options) 
            : base(options)
        {
        }

         public DbSet<Department> Department { get; set; }                                      
    }
}