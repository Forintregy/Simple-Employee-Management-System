using EmployeeManagerModel;
using System.Collections.Generic;

namespace EmployeeManagerPresentation
{
    //Интерфейс Представления
    //Определяет необходимые для работы Представителя(Presenter) поля и события
    public delegate void VoidEventHandler();

    public interface IMainView
    {
        event VoidEventHandler PrepareView;
        event VoidEventHandler DeleteEmployee;
        event VoidEventHandler PrepareDepartmentsList;
        Employee Employee { get; }
        IList<Employee> Employees { set; }
        IList<Department> Departments { get; set; }
    }
}
