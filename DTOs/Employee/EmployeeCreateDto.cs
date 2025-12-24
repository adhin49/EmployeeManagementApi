using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementApi.DTOs.Employee
{
    public class EmployeeCreateDto
    {
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
    }
}
