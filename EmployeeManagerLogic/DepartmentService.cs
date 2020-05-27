using EmployeeManagerModel;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EmployeeManagerLogic
{
    //Реализация репозитория для работы с сущностями типа Employee
    //Устроен идентично классу EmployeeService (все комментарии содержатся там же)
    public class DepartmentService
    {
        private readonly EmployeeManagerDbContext _context;
        private readonly DbSet<Department> _dbset;

        public DepartmentService(EmployeeManagerDbContext context)
        {
            _context = context;
            _dbset = context.Departments;
        }

        public IEnumerable<Department> GetAll()
        {
            return _context.Departments;
        }

        //Удаляет из БД все отделы, численность которых равна нулю
        public void CleanEmptyDepartments()
        {
            _dbset.RemoveRange(_dbset.Where(d => d.Employees.Any() == false));
        }

        public void Remove(Department department)
        {
            if(department!=null)
                _dbset.Remove(department);
        }
    }
}
