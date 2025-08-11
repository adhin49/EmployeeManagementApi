using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementApi.DTOs.Employee
{
    public class EmployeeUpdateDto
    {
        [Required]
        public int Id { get; set; } // Ensure the employee to update is identified

        [Required, StringLength(50)]
        public string FirstName { get; set; }

        [Required, StringLength(50)]
        public string LastName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, Range(0, double.MaxValue)]
        public decimal Salary { get; set; }

        [Required]
        public int DepartmentId { get; set; }

        public bool IsActive { get; set; }
    }
}
