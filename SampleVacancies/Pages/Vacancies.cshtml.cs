using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using SampleVacancies.Core.Models;
using SampleVacancies.Data;

namespace SampleVacancies.Pages
{
    public class VacanciesModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IVacancyData vacancyData;

        public IEnumerable<Vacancy> Vacancies { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public VacanciesModel(IConfiguration config, IVacancyData vacancyData)
        {
            this.config = config;
            this.vacancyData = vacancyData;
        }

        public void OnGet()
        {
            Vacancies = vacancyData.GetAllVacancies();
        }
    }
}