using Microsoft.EntityFrameworkCore;
using SampleVacancies.Core.Models;
using System;

namespace SampleVacancies.Data
{
    public class SampleVacanciesDbContext : DbContext
    {
        public DbSet<Vacancy> Vacancies { get; set; }

        public SampleVacanciesDbContext(DbContextOptions<SampleVacanciesDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed the database with test data
            modelBuilder.Entity<Vacancy>().HasData(
                new Vacancy
                {
                    Id = 1,
                    JobTitle = "Manager",
                    Department = "Sales",
                    Description = "This is a wonderful opportunity for an up-and-coming manager.",
                    Location = "Manchester",
                    Salary = "£50,000"
                },
                new Vacancy
                {
                    Id = 3,
                    JobTitle = "Accountant",
                    Department = "Human Resources",
                    Description = "Calling all skilled accountants to this exciting opportunity.",
                    Location = "Salford",
                    Salary = "£45,000"
                }
                );
        }
    }
}
