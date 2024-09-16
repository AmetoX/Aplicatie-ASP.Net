using AplicatieASP.Components.DataBase.Models;
using Microsoft.EntityFrameworkCore;

namespace AplicatieASP.Components.DataBase
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
        {
        }

        // DbSet for Users table
        public DbSet<User> Users { get; set; }
    }
}
