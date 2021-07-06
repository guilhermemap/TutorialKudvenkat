using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TutorialKudvenkat.Services;
using TutorialKudvenkat.Models;

namespace TutorialKudvenkat.Pages.Employees
{
    public class DetailsModel : PageModel
    {
        private readonly IEmployeeRepository employeeRepository;
        [BindProperty(SupportsGet = true)]
        public int id { get; set; }

        public DetailsModel(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public Employee Employee { get; private set; }

        // Model-binding automatically maps the query string id
        // value to the id parameter on this OnGet() method
        public IActionResult OnGet()
        {
            Employee = employeeRepository.GetEmployee(id);
            if (Employee == null)
            {
                RedirectToPage("/NotFound");    
            }
            return Page();
        }

    }
}
