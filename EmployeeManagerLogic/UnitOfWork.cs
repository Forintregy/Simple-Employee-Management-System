using EmployeeManagerModel;
using System.Threading.Tasks;

namespace EmployeeManagerLogic
{
    //Реализация паттерна Unit of work для работы с Репозиториями 
    //(здесь называны Services по аналогии с конвенциями ASP .NET)
    public class UnitOfWork  
    {
        protected EmployeeManagerDbContext _context { get; private set; }
        private DepartmentService _departmentService;
        private EmployeeService _employeeService;

        //Конструктор по умолчанию.         
        //Принимает ссылку на контекст БД для последующей передачи в репозитории
        public UnitOfWork(EmployeeManagerDbContext context)
        {
            _context = context;
        }

        //Передача ссылки на контекст БД в репозитории
        public DepartmentService DepartmentService
        {
            get
            {
                if(_departmentService==null)
                    _departmentService = new DepartmentService(_context);
                return _departmentService;
            }
        }

        public EmployeeService EmployeeService
        {
            get
            {
                if (_employeeService == null)
                    _employeeService = new EmployeeService(_context);
                return _employeeService;
            }
        }

        //Сохранение изменений в БД
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
