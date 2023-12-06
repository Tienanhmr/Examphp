// Repositories/IEmployeeRepository.cs
public interface IEmployeeRepository
{
    IEnumerable<Employee> GetEmployeesByDepartment(int departmentId);
    void AddEmployee(Employee employee);
    // Other CRUD methods for employees
}
