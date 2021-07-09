using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TutorialKudvenkat.Models;
using TutorialKudvenkat.Services;

namespace TutorialKudvenkat.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly IEmployeeRepository employeeRepository;

        public IEnumerable<Employee> Employees { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; } //não precisa de bindproperty?
        public IndexModel(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        public void OnGet()
        {
            //Employees = employeeRepository.GetAllEmployees();
            Employees = employeeRepository.Search(SearchTerm);
        }
    }
}
