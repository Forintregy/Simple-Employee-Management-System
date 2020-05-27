using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerModel
{
    //Интерфейс Репозитория (сервиса) для работы с таблицей работников Employees
    public interface IDepartmentService
    {
        IEnumerable<Department> GetAll();
        void Add(Department newDepartment);
        void Remove(int departmentId);
        void Update(int departmentId);
        void SetDepartmentHead(int departmentId, int employeeId);
    }
}
