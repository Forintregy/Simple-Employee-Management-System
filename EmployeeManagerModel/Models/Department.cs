using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerModel
{
    public partial class Department : IComparable
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(1), MaxLength(100)]
        [Column(TypeName = "nvarchar")]
        public string DepartmentName { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
