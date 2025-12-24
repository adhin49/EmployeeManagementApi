namespace EmployeeManagementApi.DTOs.Employee
{
    public class EmployeeDto
    {
        public int Id { get; set; } // From BaseEntity
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
        public DateTime DateOfJoining { get; set; }
        public bool IsActive { get; set; }

        // Show department name in the response
        public string DepartmentName { get; set; }
    }
}
