using Microsoft.EntityFrameworkCore;

namespace yoyocosmetic.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }

   
    }

