// Controllers/DepartmentController.cs
using Microsoft.AspNetCore.Mvc;

public class DepartmentController : Controller
{
    private readonly IDepartmentRepository _departmentRepository;

    public DepartmentController(IDepartmentRepository departmentRepository)
    {
        _departmentRepository = departmentRepository;
    }

    public IActionResult Index()
    {
        var departments = _departmentRepository.GetAllDepartments();
        return View(departments);
    }

    public IActionResult Create()
    {
        // Your logic for the create action
        return View();
    }

    // Other actions...
}
