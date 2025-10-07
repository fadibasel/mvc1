using Microsoft.Identity.Client.Extensibility;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Models.Category> categories { get; set; }
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=MVC12;Trusted_Connection=True;TrustServerCertificate=True");    

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Models.Category>().HasData(
                new Models.Category { Id = 1, Name = "Electronics" },
                new Models.Category { Id = 2, Name = "Books" },
                new Models.Category { Id = 3, Name = "Clothing" }


                    );
            ;
        }
    } 
}
