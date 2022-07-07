using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace DbOutOfNames.Models
{
    public class PersonContext : DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options)
           : base(options)
        { }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Country> Countrys { get; set; }

        protected override void OnModelCreating(
        ModelBuilder modelBuilder) {
           base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Country>().HasData(
                new Country { CountryId = "C", Name = "Canada"},
                new Country { CountryId = "D", Name = "Dominican Republic" },
                new Country { CountryId = "E", Name = "Ecaudor" },
                new Country { CountryId = "M", Name = "Mexico" },
                new Country { CountryId = "U", Name = "United States" }
                );

            modelBuilder.Entity<Person>().HasData(   // modelBuilder has some functions to help create Database. 
                new Person
                {
                    Email = "CoffeeNotCode@yahoo.com",
                    First = "Sam",
                    Last = "Relational",
                    CountryId = "C",
                    Password = "R0CKYOu99999999"
                },
                new Person
                {
                    Email = "3MonsterEnergy@MoreRedbull.com",
                    First = "Jackie",
                    Last = "Nonrelational",
                    CountryId = "D",
                    Password = "PlainText4ThatWin"
                },
                new Person
                {
                    Email = "Java>SQL@truestatement.net",
                    First = "Selma",
                    Last = "Crowsfoot",
                    CountryId = "E",
                    Password = "S3lmaCrowsf00t"
                },
                new Person
                {
                    Email = "NoMoDb@ThatNastyDB.com",
                    First = "Senor",
                    Last = "Casablanca",
                    CountryId = "M",
                    Password = "Cyber1Major"
                },
                new Person
                {
                    Email = "ItsBrokenAgain@Shocker.com",
                    First = "Trevor",
                    Last = "Lastelick",
                    CountryId = "U",
                    Password = "C4ntH4ckM3"
                }
            );
        }
    }
}
