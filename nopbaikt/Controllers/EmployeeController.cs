// Controllers/EmployeeController.cs
using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IDepartmentRepository _departmentRepository;

    public EmployeeController(IEmployeeRepository employeeRepository, IDepartmentRepository departmentRepository)
    {
        _employeeRepository = employeeRepository;
        _departmentRepository = departmentRepository;
    }

    // Implement actions for adding employees and other CRUD operations
}
