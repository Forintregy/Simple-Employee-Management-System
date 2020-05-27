using EmployeeManagerModel;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EmployeeManagerDesktop
{
    public partial class EmployeeDetailedForm : Form
    {
        private Employee Employee;

        //Конструктор по умолчанию.
        //Принимает данные о сотруднике и заполняет ими форму, вызывая FillEmployeeData()
        public EmployeeDetailedForm(Employee employee)
        {
            Employee = employee;
            InitializeComponent();
            employeecardLabel.Text += $"{Employee.LastName} {Employee.FirstName}";
            employeeDataListbox.Items.AddRange(FillEmployeeData(Employee));
            this.Text = Employee.ToString();
            int minWidth = 0;
            int minHeight = 0;
            foreach (var row in employeeDataListbox.Items)
            {
                var minSize = HelperMethods.GetMinSize(row.ToString(), employeeDataListbox.Font);
                minWidth = Math.Max(minWidth, minSize.Width);
                minHeight += minSize.Height;
            }
            this.MinimumSize = new Size
            {
                Width = minWidth + (employeeDataListbox.Left+(this.Right-employeeDataListbox.Right)),
                Height = minHeight + (employeeDataListbox.Top*2) + 40
            };
        }

        private ListBox.ObjectCollection FillEmployeeData(Employee e)
        {
            return new ListBox.ObjectCollection(employeeDataListbox)
            {
                "Фамилия: " + e?.LastName,
                "Имя: " + e?.FirstName,
                "Отчество: " + e?.SecondName,
                "Отдел: " + e?.Department,
                "Дата рождения: " + e?.DateOfBirth.ToString("dd.MM.yyyy"),
                "Почтовый индекс: " + e?.Address?.ZipCode,
                "Страна: " + e?.Address?.Country,
                "Область/регион: " + e?.Address?.Region,
                "Город: " + e?.Address?.City,
                "Улица, дом: " + e?.Address?.StreetAddress,
                "Квартира: " + e?.Address?.Apartment
            };
        }
    }
}
