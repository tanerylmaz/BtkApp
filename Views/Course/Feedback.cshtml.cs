using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace BtkApp.Views.Course
{
    public class Feedback : PageModel
    {
        private readonly ILogger<Feedback> _logger;

        public Feedback(ILogger<Feedback> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}