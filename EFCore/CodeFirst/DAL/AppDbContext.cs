using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CodeFirst.DAL
{
    public class AppDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; } // Products is the name of the table in the database
        public DbSet<Category> Categories { get; set; } // Categories is the name of the table in the database
        public DbSet<Teacher> Teachers { get; set; } // Teachers is the name of the table in the database
        public DbSet<Student> Students { get; set; } // Students is the name of the table in the database

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Initializer.Initialize(); // Ensure the Initializer is called to set up configuration
            optionsBuilder.UseSqlServer(Initializer.Configuration.GetConnectionString("SqlCon"));
        }
    }
}
