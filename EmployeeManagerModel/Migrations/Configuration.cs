namespace EmployeeManagerModel.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeeManagerModel.EmployeeManagerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EmployeeManagerModel.EmployeeManagerDbContext context)
        {
            context.Employees.AddOrUpdate<Employee>(
                new Employee
                {
                    LastName = "Лавлейс",
                    FirstName = "Ада",
                    Department = new Department { DepartmentName = "Отдел информационных технологий" },
                    DateOfBirth = new DateTime(1852, 12, 10),
                    Address = new Address
                    {
                        Country = "Великобритания",
                        City = "Лондон",
                        StreetAddress = "12 St James's Square, St James's, London"
                    }
                },
                new Employee
                {
                    LastName = "Доливо-Добровольский",
                    FirstName = "Михаил",
                    Department = new Department { DepartmentName = "Электротехнический отдел" },
                    DateOfBirth = new DateTime(1862, 01, 02),
                    Address = new Address
                    {
                        Country = "Российская Империя",
                        City = "Петербург",
                        StreetAddress = "Неизвестно"
                    }
                },
                new Employee
                {
                    LastName = "Склодовская-Кюри",
                    FirstName = "Мария",
                    Department = new Department { DepartmentName = "Отдел исследований свойств радиоактивных материалов" },
                    DateOfBirth = new DateTime(1867, 11, 07),
                    Address = new Address
                    {
                        Country = "Польша",
                        City = "Варшава",
                        StreetAddress = "Фрета, 5"
                    }
                }
            );
        }
    }
}
