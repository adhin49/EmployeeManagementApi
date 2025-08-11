using AutoMapper;
using EmployeeManagementApi.DTOs.Employee;
using EmployeeManagementApi.Interfaces.Repositories;
using EmployeeManagementApi.Interfaces.Services;
using EmployeeManagementApi.Models;
using EmployeeManagementApi.Wrappers;

namespace EmployeeManagementApi.Services
{
    public class EmployeeService:IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public EmployeeService(IEmployeeRepository employeeRepository,IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public async Task<ResponseWrapper<IEnumerable<EmployeeDto>>> GetAllAsync()
        {
            var employees = await _employeeRepository.GetallAsync();
            var employeeDtos = _mapper.Map<IEnumerable<EmployeeDto>>(employees);
            return new ResponseWrapper<IEnumerable<EmployeeDto>>(employeeDtos);
        }

        public async Task<ResponseWrapper<EmployeeDto>> GetByIdAsync(int id)
        {
            var employee = await _employeeRepository.GetByIdAsync(id);
            if (employee == null)
            {
                return new ResponseWrapper<EmployeeDto>("Employee not found");
            }
            var employeeDto = _mapper.Map<EmployeeDto>(employee);
            return new ResponseWrapper<EmployeeDto>(employeeDto);
        }

        public async Task<ResponseWrapper<EmployeeDto>> AddAsync(EmployeeCreateDto dto)
        {
            var employee = _mapper.Map<Employee>(dto);
            await _employeeRepository.AddAsync(employee);
            if (await _employeeRepository.SaveChangesAsync())
            {
                var employeeDto = _mapper.Map<EmployeeDto>(employee);
                return new ResponseWrapper<EmployeeDto>(employeeDto, "Employee added successfully");
            }
            return new ResponseWrapper<EmployeeDto>("Failed to add employee");
        }

        public async Task<ResponseWrapper<EmployeeDto>> UpdateAsync(int id, EmployeeUpdateDto dto)
        {
            var employee = await _employeeRepository.GetByIdAsync(id);
            if (employee == null)
            {
                return new ResponseWrapper<EmployeeDto>("Employee not found");
            }
            _mapper.Map(dto, employee);
            await _employeeRepository.UpdateAsync(employee);
            if (await _employeeRepository.SaveChangesAsync())
            {
                var employeeDto = _mapper.Map<EmployeeDto>(employee);
                return new ResponseWrapper<EmployeeDto>(employeeDto, "Employee updated successfully");
            }
            return new ResponseWrapper<EmployeeDto>("Failed to update employee");
        }

        public async Task<ResponseWrapper<string>> DeleteAsync(int id)
        {
            var employee = await _employeeRepository.GetByIdAsync(id);
            if (employee == null)
            {
                return new ResponseWrapper<string>("Employee not found");
            }
            await _employeeRepository.DeleteAsync(employee);
            if (await _employeeRepository.SaveChangesAsync())
            {
                return new ResponseWrapper<string>("Employee deleted successfully");
            }
            return new ResponseWrapper<string>("Failed to delete employee");
        }

    }
}
