using EmployeeManagerModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeManagerDesktop
{
    public partial class DepartmentsInfoForm : Form
    {
        //Конструктор по умолчанию с установкой минимальных размеров формы
        public DepartmentsInfoForm(IList<Department> departments)
        {
            InitializeComponent();
            this.Text = $"Данные по численности отделов предприятия";
            departmentsInfoListview.View = View.List;
            int employeesCount = 0;
            if (departments.Any() != false)
            {
                int minWidth = 0;
                int minHeight = 0;
                foreach (var d in departments)
                {
                    string text = $"{d.ToString()}. Сотрудников: {d.Employees.Count.ToString()}";
                    departmentsInfoListview.Items.Add(text);
                    var minSize = HelperMethods.GetMinSize(text, departmentsInfoListview.Font);
                    minWidth = Math.Max(minWidth, minSize.Width);
                    minHeight += minSize.Height;
                    employeesCount += d.Employees.Count;
                }
                this.MinimumSize = new Size(
                    minWidth + departmentsInfoListview.Left + (this.Right - departmentsInfoListview.Right),
                    minHeight + departmentsInfoListview.Top + (this.Bottom - departmentsInfoListview.Bottom) + 40);
                headerLabel.Text = $"Числов сотрудников: {employeesCount}. " +
                                   $"Число отделов: {departments.Count}.";
            }
            else headerLabel.Text = "На предприятии ещё никто не работает";
        }
    }
}
