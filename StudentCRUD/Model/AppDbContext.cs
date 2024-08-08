using Microsoft.EntityFrameworkCore;

namespace StudentCRUD.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options):  base(options) 
        
        {


        }

        public DbSet<Student> Students { get; set; }
    }
}
