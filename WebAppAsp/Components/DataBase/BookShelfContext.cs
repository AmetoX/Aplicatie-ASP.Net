using Microsoft.EntityFrameworkCore;
using WebAppAsp.Components.DataBase.Models;

namespace WebAppAsp.Components.DataBase
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

            //modelBuilder.Entity<User>().ToTable("Users");
            //modelBuilder.Entity<FisaDeLucru>().ToTable("FiseDeLucru");

            //modelBuilder.Entity<User>().HasData(
            //    new User
            //    {
            //        Id = 1,
            //        Name = "John",
            //        Password = "1234"
            //    },
            //    new User
            //    {
            //        Id = 2,
            //        Name = "Jane",
            //        Password = "5678"
            //    },
            //    new User
            //    {
            //        Id = 3,
            //        Name = "Admin",
            //        Password = "admin"
            //    }
            //);

            //modelBuilder.Entity<FisaDeLucru>().HasData(
            //    new FisaDeLucru
            //    {
            //        Id = 1,
            //        Number = "1",
            //        Date = DateTime.Now, // Add the current date here
            //        GPS = "124.456.789"
            //    },
            //    new FisaDeLucru
            //    {
            //        Id = 2,
            //        Number = "2",
            //        Date = DateTime.Now, // Add the current date here
            //        GPS = "987.653.321"
            //    },
            //    new FisaDeLucru
            //    {
            //        Id = 3,
            //        Number = "3",
            //        Date = DateTime.Now, // Add the current date here
            //        GPS = "987.624.321"
            //    }
            //);
        }

    }
}
