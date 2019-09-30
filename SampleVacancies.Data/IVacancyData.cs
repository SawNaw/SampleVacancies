using SampleVacancies.Core.Models;
using System.Collections.Generic;
using System.Text;

namespace SampleVacancies.Data
{
    public interface IVacancyData
    {
        IEnumerable<Vacancy> GetAllVacancies();
        IEnumerable<Vacancy> GetVacanciesByName(string name);
        Vacancy GetVacancyById(int id);
        Vacancy Add(Vacancy newVacancy);
        Vacancy Update(Vacancy vacancy);
        Vacancy Delete(Vacancy vacancy);
        int Commit();

    }
}
