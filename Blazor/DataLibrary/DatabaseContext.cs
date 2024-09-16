using DataLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
	public class DatabaseContext : DbContext
	{
		//variabile private se denumesc cu _ in fata
		public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) // io parametrul options de la DbContex
		{}

		protected override void OnModelCreating(ModelBuilder modelBuilder) // metoda care se apeleaza atunci cand se creaza baza de date
		{
			modelBuilder.Entity<People>()
				.HasKey(people => people.Id);

			modelBuilder.Entity<People>().HasData(
				new People { Id = 1, FirstName = "John" },
				new People { Id = 2, FirstName = "Jane" },
				new People { Id = 3, FirstName = "Doe" },
				new People { Id = 4, FirstName = "Smith" }
				);
		}
	}
}