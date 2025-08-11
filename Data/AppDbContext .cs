using EmployeeManagementApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementApi.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        
    }
}
