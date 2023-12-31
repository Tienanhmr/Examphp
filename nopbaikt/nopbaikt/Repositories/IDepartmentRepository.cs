﻿// Repositories/IDepartmentRepository.cs
public interface IDepartmentRepository
{
    IEnumerable<Department> GetAllDepartments();
    Department GetDepartmentById(int id);
    void AddDepartment(Department department);
    void UpdateDepartment(Department department);
    void DeleteDepartment(int id);
}
