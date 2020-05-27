using EmployeeManagerModel;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagerLogic
{
    //Реализация репозитория для работы с сущностями типа Employee
    public class EmployeeService : IEmployeeService
    {
        private readonly EmployeeManagerDbContext _context;
        private DbSet<Employee> _dbset;

        //Конструктор по умолчанию
        //Передаёт ссылку на контекст и набор данных от UnitOfWork во внутренние поля 
        public EmployeeService(EmployeeManagerDbContext context)
        {
            _context = context;
            _dbset = context.Set<Employee>();
        }

        #region Методы работы с БД
        //Методы получения и изменения данных БД

        //По умолчанию Entity Framework загружает данные реализую ленивую загрузку (Lazy Loading) - 
        //загружаются непостредственно поля самой сущности, без загрузки данных связанных таблиц.
        //Метод расширения Include() позволяет реализовать жадную загрузку (EagerLoading) - 
        //сущность выдаётся с данными таблиц, указанных в списке параметров метода Include()
        public IEnumerable<Employee> GetAll()
        {
            return _dbset
                .Include(e=>e.Department)
                .Include(e=>e.Address);
        }

        //Возвращает сотрудника, соответствующего employeeId либо null
        public Employee GetById(int employeeId)
        {
            return  _dbset
                .Include(e => e.Department)
                .Include(e => e.Address)
                .Where(e => e.Id == employeeId)
                .FirstOrDefault();
        }

        //Добавление сотрудника в БД
        public void Add(Employee newEmployee)
        {
            _dbset.Add(newEmployee);
        }

        //Удаление сотрудника из БД
        public void Remove(int employeeId)
        {
            var employeeToDelete = GetById(employeeId);
            if (employeeToDelete != null)
                _dbset.Remove(employeeToDelete);
        }

        //Проверка на различие значений полей существующего и обновлённого Employee
        //(Entity Framework сравнивает только первичные ключи и при их равенстве обновляет все поля)
        public void Update(int employeeId, Employee newEmployee)
        {
            var employeeToUpdate = GetById(employeeId);
            if (employeeToUpdate != null && !newEmployee.Equals(employeeToUpdate))
            {
                employeeToUpdate.Address = newEmployee.Address;
                employeeToUpdate.About = newEmployee.About;
                employeeToUpdate.DateOfBirth = newEmployee.DateOfBirth;
                employeeToUpdate.Department = newEmployee.Department;
                employeeToUpdate.FirstName = newEmployee.FirstName;
                employeeToUpdate.LastName = newEmployee.LastName;
                employeeToUpdate.SecondName = newEmployee.SecondName;
                _context.Entry(employeeToUpdate).State = EntityState.Modified;
            }
            if (employeeToUpdate == null && newEmployee != null)
            {
                _dbset.Add(newEmployee);
            }
        }
        #endregion
    }
}
