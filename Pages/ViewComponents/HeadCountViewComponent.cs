using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TutorialKudvenkat.Models;
using TutorialKudvenkat.Services;

namespace TutorialKudvenkat.Pages.ViewComponents
{
    public class HeadCountViewComponent : ViewComponent
    {
        private readonly IEmployeeRepository employeeRepository;

        public HeadCountViewComponent(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        public IViewComponentResult Invoke(Dept? dept = null)
        {
            var result = employeeRepository.EmployeeCountByDept(dept);
            return View(result); 
        }
    }
}
