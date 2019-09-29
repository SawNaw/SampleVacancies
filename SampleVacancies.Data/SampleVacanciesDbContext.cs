using Microsoft.EntityFrameworkCore;
using SampleVacancies.Core.Models;
using System;

namespace SampleVacancies.Data
{
    public class SampleVacanciesDbContext : DbContext
    {
        public DbSet<Vacancy> Vacancies { get; set; }
    }
}
