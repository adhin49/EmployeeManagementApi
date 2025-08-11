using EmployeeManagementApi.DTOs.Employee;
using EmployeeManagementApi.Wrappers;

namespace EmployeeManagementApi.Interfaces.Services
{
    public interface IEmployeeService
    {
        Task<ResponseWrapper<IEnumerable<EmployeeDto>>> GetAllAsync();
        Task<ResponseWrapper<EmployeeDto>> GetByIdAsync(int id);
        Task<ResponseWrapper<EmployeeDto>> AddAsync(EmployeeCreateDto dto);
        Task<ResponseWrapper<EmployeeDto>> UpdateAsync(int id, EmployeeUpdateDto dto);
        Task<ResponseWrapper<string>> DeleteAsync(int id);
    }
}
