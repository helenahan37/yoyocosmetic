using Microsoft.EntityFrameworkCore;
using yoyocosmetic.Models;

namespace yoyocosmetic.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

    }





   




}

