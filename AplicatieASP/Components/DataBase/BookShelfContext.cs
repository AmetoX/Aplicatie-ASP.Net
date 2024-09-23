using Microsoft.EntityFrameworkCore;
using AplicatieASP.Components.DataBase.Models;

namespace AplicatieASP.Components.DataBase
{
    public class BookShelfContext : DbContext
    {
        public BookShelfContext(DbContextOptions<BookShelfContext> options) : base(options)
        {
        }

        public DbSet<FisaDeLucru> FiseDeLucru { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Optionally specify schema if needed (MySQL usually defaults to the specified DB)
            modelBuilder.HasDefaultSchema("webasp");

            // Additional configuration for tables, keys, and relationships can go here
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<FisaDeLucru>().ToTable("FiseDeLucru");

            modelBuilder.Entity<User>().HasData(    
                new User
                {
                    Id = 1,
                    Name = "John",
                    Password = "1234"
                },
                new User
                {
                    Id = 2,
                    Name = "Jane",
                    Password = "5678"
                }
            );

            modelBuilder.Entity<FisaDeLucru>().HasData(
                new FisaDeLucru
                {
                    Id = 1,
                    Number = "1",
                    Date = "2021-01-01"
                },
                new FisaDeLucru
                {
                    Id = 2,
                    Number = "2",
                    Date = "2021-01-02"
                }
            );
        }

    }

}
