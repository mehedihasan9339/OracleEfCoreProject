// Models/Employee.cs
using System.ComponentModel.DataAnnotations;

namespace OracleEfCoreProject.Models
{
    public class Base
    {
        [Key]
        public int Id { get; set; }
    }
}
