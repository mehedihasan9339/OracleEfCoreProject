// Models/Employee.cs
using System.ComponentModel.DataAnnotations;

namespace OracleEfCoreProject.Models
{
    public class Employee : Base
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Email { get; set; }

        public DateTime? JoiningDate { get; set; }

        [Required]
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }
    }
}
