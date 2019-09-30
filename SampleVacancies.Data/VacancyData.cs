using SampleVacancies.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SampleVacancies.Data
{
    public class VacancyData : IVacancyData
    {
        private readonly SampleVacanciesDbContext dbContext;

        public VacancyData(SampleVacanciesDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Vacancy Add(Vacancy newVacancy)
        {
            dbContext.Add(newVacancy);
            return newVacancy;
        }

        public Vacancy Delete(Vacancy vacancy)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vacancy> GetAllVacancies()
        {
            return dbContext.Vacancies.OrderByDescending(x => x.Id);
        }

        public IEnumerable<Vacancy> GetVacanciesByName(string name)
        {
            return dbContext.Vacancies.Where(x => String.IsNullOrWhiteSpace(name) 
                                                || x.JobTitle.ToUpperInvariant().Contains(name.ToUpperInvariant()))
                                      .OrderByDescending(x => x.JobTitle);
                                      
        }

        public Vacancy GetVacancyById(int id)
        {
            return dbContext.Vacancies.Find(id);
        }

        public Vacancy Update(Vacancy vacancy)
        {
            throw new NotImplementedException();
        }

        public int Commit()
        {
            return dbContext.SaveChanges();
        }
    }
}
