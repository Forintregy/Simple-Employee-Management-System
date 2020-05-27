using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagerLogic;
using EmployeeManagerModel;

namespace EmployeeManagerPresentation
{
    //Presenter выступает в качестве аналога Контроллера паттерна MVC
    //Управляет получением данных от Представления (реализующего интерфейс IView)
    //и передачей новых/обновлённых данных в БД
    public class EmployeesMainPresenter
    {
        UnitOfWork unitOfWork;
        private readonly IMainView _view;

        //Конструктор по умолчанию
        //Событие PrepareView передаёт Представлению данные по всем сотрудникам
        //Событие DeleteEmployee передаёт Репозиторию Id сотрудника для его удаления
        public EmployeesMainPresenter(IMainView view)
        {
            unitOfWork = new UnitOfWork(new EmployeeManagerDbContext());
            //При запуске программы выполняется проверка на наличие отделов 
            //с нулевой численностью и таковые удаляются из БД
            unitOfWork.DepartmentService.CleanEmptyDepartments();
            unitOfWork.Save();

            _view = view;
            view.DeleteEmployee += View_DeleteEmployee;
            view.PrepareView += View_PrepareView;
            view.PrepareDepartmentsList += View_PrepareDepartmentsList;
        }

        private void View_PrepareDepartmentsList()
        {
            _view.Departments = GetDepartments();
        }

        private void View_PrepareView()
        {
            _view.Employees=GetEmployees();
        }

        private IList<Department> GetDepartments()
        {
            return unitOfWork.DepartmentService.GetAll().ToList();
        }

        private IList<Employee> GetEmployees()
        {
            return unitOfWork.EmployeeService.GetAll().ToList();
        }

        public virtual void View_DeleteEmployee()
        {
            var employee = _view.Employee;
            unitOfWork.EmployeeService.Remove(employee.Id);
            unitOfWork.Save();
        }

    }
}
