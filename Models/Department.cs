namespace EmployeeManagementApi.Models
{
    public class Department:BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; } 

        public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
