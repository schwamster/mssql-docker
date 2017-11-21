using System;
using Microsoft.EntityFrameworkCore;

namespace Intro
{
    public class BloggingContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=db;Database=PeopleDatabase;Trusted_Connection=True;");
        }
    }

    public class Person
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}