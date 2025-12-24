using AutoMapper;
using EmployeeManagementApi.DTOs.Employee;
using EmployeeManagementApi.Models;

namespace EmployeeManagementApi.Common
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, EmployeeDto>();
            CreateMap<EmployeeCreateDto, Employee>();
            CreateMap<EmployeeUpdateDto, Employee>();
        }
    }
}
