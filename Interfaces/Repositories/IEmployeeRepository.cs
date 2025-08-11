﻿using EmployeeManagementApi.Models;

namespace EmployeeManagementApi.Interfaces.Repositories
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetallAsync();
        Task<Employee?> GetByIdAsync(int id);

        Task AddAsync(Employee employee);

        Task UpdateAsync(Employee employee);

        Task DeleteAsync(Employee employee);

        Task<bool> SaveChangesAsync();
    }
}
