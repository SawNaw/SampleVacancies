using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleVacancies.Core.Models
{
    public class Vacancy
    {
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string JobTitle { get; set; }

        [Required, StringLength(100)]
        public string Location { get; set; }

        public string Department { get; set; }

        [Required]
        public string Salary { get; set; }

        public string Description { get; set; }
    }
}
