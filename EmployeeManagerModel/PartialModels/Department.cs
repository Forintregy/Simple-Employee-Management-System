using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerModel
{
    public partial class Department
    {
        public override string ToString()
        {
            return DepartmentName;
        }

        public int CompareTo(object obj)
        {
            if (obj as Department == null) throw new ArgumentException($"Сравниваемый тип не является типом {typeof(Department)}");
            else
            {
                var other = (Department)obj;
                return string.Compare(this.DepartmentName, other.DepartmentName, StringComparison.InvariantCultureIgnoreCase);
            }
        }
    }
}
