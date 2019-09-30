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
    [BindProperties]
    public class VacanciesModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IVacancyData vacancyData;

        public IEnumerable<Vacancy> Vacancies { get; set; }
        public Vacancy Vacancy { get; set; }
        public string JobTitle { get; set; }
        public string Location { get; set; }
        public string Department { get; set; }
        public string Salary { get; set; }
        public string Description { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public VacanciesModel(IConfiguration config, IVacancyData vacancyData)
        {
            this.config = config;
            this.vacancyData = vacancyData;
        }

        public IActionResult OnGet()
        {
            Vacancies = vacancyData.GetVacanciesByName(SearchTerm);
            return Page();
        }

        public IActionResult OnPost() 
        {
            Vacancy = vacancyData.Update(Vacancy);
            vacancyData.Commit();
            return RedirectToPage("./Vacancies");
        }
    }
}