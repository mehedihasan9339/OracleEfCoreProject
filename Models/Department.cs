// Models/Employee.cs
using System.ComponentModel.DataAnnotations;

namespace OracleEfCoreProject.Models
{
    public class Department:Base
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string RoomNo { get; set; }
    }
}
