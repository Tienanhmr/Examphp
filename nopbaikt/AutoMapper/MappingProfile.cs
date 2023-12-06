// AutoMapperProfiles/MappingProfile.cs
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Department, DepartmentViewModel>(); // DepartmentViewModel is not defined here
        CreateMap<Employee, EmployeeViewModel>(); // EmployeeViewModel is not defined here
    }

    private void CreateMap<T1, T2>()
    {
        throw new NotImplementedException();
    }

    private class DepartmentViewModel
    {
    }
}

public class Profile
{
}

internal class EmployeeViewModel
{
}