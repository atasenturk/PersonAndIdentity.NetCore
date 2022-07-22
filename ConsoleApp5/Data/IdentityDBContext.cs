using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Data
{
    public class IdentityDBContext : DbContext
    {
        public DbSet<PersonIdentity> Identities { get; set; }
        public DbSet<Person> People { get; set; }

        public IdentityDBContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDb;Database=TCAuthDB;Trusted_Connection=True;MultipleActiveResultSets=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    Id = 1,
                    Name = "Ata",
                    Surname = "Senturk",
                    Address = "Eskisehir"
                }
            );

            modelBuilder.Entity<PersonIdentity>().HasData(
                new PersonIdentity
                {
                    Id = 1,
                    PersonId = 1,
                    TCNo = "11036786912",
                    VolNum = "2125",
                    MaritalStat = "Single",
                }
            );
        }
    }
}
