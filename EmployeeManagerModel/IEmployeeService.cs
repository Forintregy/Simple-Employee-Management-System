using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerModel
{
    //Интерфейс Репозитория (сервиса) для работы с таблицей отделов Departments
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAll();
        void Add(Employee newEmployee);
        void Remove(int employeeId);
        void Update(int employeeToUpdateId, Employee newEmployee);
        Employee GetById(int employeeId);
    }
}
