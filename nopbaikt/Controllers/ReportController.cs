
using Microsoft.AspNetCore.Mvc;

namespace exam.asp.net.Controllers
{
    public class ReportController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public ReportController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        // Implement actions for generating reports and statistics
    }
}
