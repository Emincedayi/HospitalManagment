using AutoMapper;
using HospitalManagement.Departments;

public class DepartmentAutoMapperProfile : Profile
{
    public DepartmentAutoMapperProfile()
    {
        CreateMap<Department, DepartmentDto>().ReverseMap();
    }
}