using EmployeeManagerModel;
using System.Collections.Generic;

namespace EmployeeManagerPresentation.ViewInterfaces
{
    //Интерфейс Представления
    //Определяет необходимые для работы Представителя(Presenter) поля и события
    public interface IAddUpdateEmployeeView
    {
        Employee NewEmployee { get; }
        Department NewDepartment { get; }
        IEnumerable<Department> Departments { set; }
        event VoidEventHandler AddUpdateEmployee;
        event VoidEventHandler PrepareView;
    }
}
