using System.ComponentModel.DataAnnotations.Schema;

namespace NuGetOracle
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        [ForeignKey("Manager")]
        public int ManagerId { get; set; }
        public Employee Manager { get; set; }
    }
}