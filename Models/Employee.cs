using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagementApi.Models
{
    public class Employee:BaseEntity
    {
        [Required,StringLength(50)]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [EmailAddress]
        public String Email { get; set; }

        [Column(TypeName = "Decimal(18,2)")]
        public decimal Salary{ get; set; }

        public DateTime DateOfJoining { get; set; } = DateTime.UtcNow;

        public int DepartmentId { get; set; }

        public virtual Department? Department { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
