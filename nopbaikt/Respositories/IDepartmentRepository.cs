
public interface IDepartmentRepository
{
    IEnumerable<Department> GetDepartments();
    Department GetDepartmentById(int id);
    void AddDepartment(Department department);
    void UpdateDepartment(Department department);
    void DeleteDepartment(int id);
}
