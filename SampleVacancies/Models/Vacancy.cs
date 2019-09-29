using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleVacancies.Core.Models
{
    public class Vacancy
    {
        public string Id { get; set; }
        public string JobTitle { get; set; }
        public string Location { get; set; }
        public string Department { get; set; }
        public string Salary { get; set; }
        public string Description { get; set; }
    }
}
