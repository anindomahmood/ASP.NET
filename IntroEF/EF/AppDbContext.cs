using Microsoft.EntityFrameworkCore;
using IntroEF.Models;

namespace IntroEF.EF
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }

    }
    
    }
