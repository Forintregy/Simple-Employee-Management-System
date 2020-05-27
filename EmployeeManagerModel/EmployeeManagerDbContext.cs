using System.Data.Entity;

namespace EmployeeManagerModel
{
    //Класс контекста БД
    public class EmployeeManagerDbContext : DbContext
    {
        //Строка подключения к БД передается в конструктор базового класса,
        //должна соответствовать параметру name в разделе connectionstrings файла App.config
        public EmployeeManagerDbContext() : base("EFDbConnection")
        { }

        //Таблицы данных
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
