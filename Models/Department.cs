namespace EmployeeManagementApi.Models
{
    public class Department:BaseEntity
    {
        public string Name { get; set; }

        public string Descriptions { get; set; } 

        public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
