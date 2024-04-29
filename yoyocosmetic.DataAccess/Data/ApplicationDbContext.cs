using Microsoft.EntityFrameworkCore;
using yoyocosmetic.Models;

namespace yoyocosmetic.DataAccess.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Face", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Eye", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Lip", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Nail", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Hair", DisplayOrder = 5 }
            );
        }

    }





   




}

