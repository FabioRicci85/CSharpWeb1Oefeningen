using Microsoft.EntityFrameworkCore;

namespace MVCTestEFCore.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {        
        }
    }
}
