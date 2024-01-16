using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BtkApp.Models
{
    public class Candidate
    {
        [Required(ErrorMessage = "E-mail is required.")]
        public String? Email { get; set; } = String.Empty;
        [Required(ErrorMessage = "Name is required.")]
        public String? FirstName { get; set; } = String.Empty;
        [Required(ErrorMessage = "Surname is required.")]
        public String? LastName { get; set; } = String.Empty;
        public String? FullName => $"{FirstName} {LastName?.ToUpper()}";
        public int? Age { get; set; }
        public String? SelectedCourse { get; set; } = String.Empty;
        public DateTime ApplyAt { get; set; }

        public Candidate()
        {
            ApplyAt = DateTime.Now;
        }
    }
}