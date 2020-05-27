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
                    LastName = "�������",
                    FirstName = "���",
                    Department = new Department { DepartmentName = "����� �������������� ����������" },
                    DateOfBirth = new DateTime(1852, 12, 10),
                    Address = new Address
                    {
                        Country = "��������������",
                        City = "������",
                        StreetAddress = "12 St James's Square, St James's, London"
                    }
                },
                new Employee
                {
                    LastName = "������-�������������",
                    FirstName = "������",
                    Department = new Department { DepartmentName = "������������������ �����" },
                    DateOfBirth = new DateTime(1862, 01, 02),
                    Address = new Address
                    {
                        Country = "���������� �������",
                        City = "���������",
                        StreetAddress = "����������"
                    }
                },
                new Employee
                {
                    LastName = "�����������-����",
                    FirstName = "�����",
                    Department = new Department { DepartmentName = "����� ������������ ������� ������������� ����������" },
                    DateOfBirth = new DateTime(1867, 11, 07),
                    Address = new Address
                    {
                        Country = "������",
                        City = "�������",
                        StreetAddress = "�����, 5"
                    }
                }
            );
        }
    }
}
