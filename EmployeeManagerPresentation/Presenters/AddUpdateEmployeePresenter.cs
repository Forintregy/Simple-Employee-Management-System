using EmployeeManagerLogic;
using EmployeeManagerModel;
using EmployeeManagerPresentation.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerPresentation
{
    //Presenter выступает в качестве аналога контроллера паттерна MVC
    //Управляет получением данных от Представления (реализующего интерфейс IView)
    //и передачей новых/обновлённых данных в БД и передачей данных от БД Представлению
    public class AddUpdateEmployeePresenter
    {
        UnitOfWork unitOfWork;
        private readonly IAddUpdateEmployeeView _view;

        //Конструктор по умолчанию.
        //Событие PrepareView передаёт на View данные по списку отделов от репозитория для заполнения формы
        //Событие AddUpdateEmployee передаёт введённые данные репозиторию EmployeeService
        public AddUpdateEmployeePresenter(IAddUpdateEmployeeView view)
        {
            unitOfWork = new UnitOfWork(new EmployeeManagerDbContext());
            _view = view;
            view.AddUpdateEmployee += View_AddUpdateEmployee;
            view.PrepareView += View_PrepareView;
        }

        //Метод подготовки Представления, получает перечень отделов
        private void View_PrepareView()
        {
            _view.Departments = GetDepartments();
        }

        private IEnumerable<Department> GetDepartments()
        {
            return unitOfWork.DepartmentService.GetAll();
        }

        //Метод добавления или обновления сотрудника
        private void View_AddUpdateEmployee()
        {
            if (unitOfWork.EmployeeService.GetById(_view.NewEmployee.Id) != null)
                unitOfWork.EmployeeService.Update(_view.NewEmployee.Id, _view.NewEmployee);
            else unitOfWork.EmployeeService.Add(_view.NewEmployee);
            unitOfWork.Save();
        }
    }
}
