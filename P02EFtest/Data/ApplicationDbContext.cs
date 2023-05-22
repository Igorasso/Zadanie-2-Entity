using Microsoft.EntityFrameworkCore;
using P02EFtest.Models;

namespace P02EFtest.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "jan Kowalski",
                    Email = "korwin@mikke.pl",
                    Address = "Krańcowa 2"

                },
                 new Employee
                 {
                     Id = 2,
                     Name = "janita Marianka",
                     Email = "korwin@kowalski.pl",
                     Address = "Kuperowa 5"

                 }
                );
        }

    }
}
