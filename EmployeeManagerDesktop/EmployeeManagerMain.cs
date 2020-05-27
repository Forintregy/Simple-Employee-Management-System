using EmployeeManagerModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeManagerPresentation;
using System.Linq;
using System.Data;

namespace EmployeeManagerDesktop
{
    public partial class EmployeeManagerMain : Form, IMainView
    {
        private EmployeesMainPresenter _presenter;
        public IList<Employee> Employees { set => employeesGridView.DataSource = HelperMethods.EmployeesToDataTable(value); }
        public Employee Employee { get => GetSelectedEmployee(); }
        public IList<Department> Departments { get; set; }

        public event VoidEventHandler PrepareView;
        public event VoidEventHandler DeleteEmployee;
        public event VoidEventHandler PrepareDepartmentsList;

        //Констуктор формы по умолчанию
        //Принимает данные для таблицы сотрудников вызывая UpdateViewData (см. ниже)
        public EmployeeManagerMain()
        {
            InitializeComponent();
            this.Text = "Менеджер персонала 0.1b";
            UpdateViewData();
        }

        #region События кнопок
        //Обработчики событий нажатия кнопок

        //Отображение формы с полной информацией о сотруднике
        private void detailsButton_Click(object sender, EventArgs e)
        {
            if (Employee == null) SelectEmployeeWarning();
            else
            {
                var form = new EmployeeDetailedForm(Employee);
                DialogResult result = form.ShowDialog(this);
                if (result == DialogResult.Cancel) return;
            }
        }

        //Для добавления и редактирования данных сотрудников используется одна и та же
        //форма. Логика формы реализована иаким образом, что при передаче значения null
        //происходит создание сотрудника, а прим передаче существующего экземпляра Employee - 
        //редактирование данных.

        //Отображение формы добавления информациии о сотруднике
        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            var createEmployeeForm = new AddUpdateEmployeeForm();
            DialogResult result = createEmployeeForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                UpdateViewData();
                return;
            }
        }

        //Отображение формы изменения информациии о сотруднике
        private void buttonEditEmployee_Click(object sender, EventArgs e)
        {
            if (Employee == null) SelectEmployeeWarning();
            else
            {
                var editEmployeeForm = new AddUpdateEmployeeForm(Employee);
                DialogResult result = editEmployeeForm.ShowDialog(this);
                if (result == DialogResult.Cancel) return;
            }
            UpdateViewData();
        }

        //Отображения диалога удаления сотрудника из БД
        private void buttonDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (Employee == null) SelectEmployeeWarning();
            else
            {
                var confirmAction = MessageBox.Show($"Вы уверены, что хотите удалить этого сотрудника:\n{Employee}?\n"
                    + HelperMethods.GenerateVeryImportantReason(),
                                     "Подтвердите удаление",
                                     MessageBoxButtons.YesNo);
                if (confirmAction == DialogResult.Yes) DeleteEmployee();
            }
            UpdateViewData();
        }

        //Метод сортировки данных в столбце при щелчке по заголовку
        private void employeesGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = employeesGridView.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = employeesGridView.SortedColumn;
            ListSortDirection direction;
            if (oldColumn != null)
            {
                if (oldColumn == newColumn &&
                    employeesGridView.SortOrder == SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }
            employeesGridView.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                SortOrder.Ascending : SortOrder.Descending;
        }

        //Отображение данных по отделам
        private void departmentsInfoButton_Click(object sender, EventArgs e)
        {
            PrepareDepartmentsList();
            var form = new DepartmentsInfoForm(Departments);
            DialogResult result = form.ShowDialog(this);
            if (result == DialogResult.Cancel) return;
        }
        #endregion

        #region Вспомогательные методы
        //Предупреждение о необходимости выбора элемента таблицы для проведеняи операций с ним
        private void SelectEmployeeWarning()
        {
            MessageBox.Show(this, "Выберите работника из таблицы", "Работник не выбран", 
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        //Номер ячейки, хранящей Employee, известен благодаря самостоятельной 
        //реализации DataTable (HelperMethods.ToDataTable())
        private Employee GetSelectedEmployee()
        {
            Employee employee = null;
            if (employeesGridView.CurrentRow != null && employeesGridView.CurrentRow.Cells[0].Value != null)
                employee = (Employee) employeesGridView.CurrentRow.Cells[4].Value;
            return employee;
        }

        //Настройка таблицы и минимальных размеров формы
        private void employeesGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int minX = 0;
            int minY = 0;
            employeesGridView.Columns["Employee"].Visible = false;
            employeesGridView.AutoResizeColumns();
            foreach (var column in employeesGridView.Columns)
            {
                var c = column as DataGridViewColumn;
                c.MinimumWidth = (int) (TextRenderer.MeasureText(c.HeaderText, employeesGridView.Font).Width * 1.5);
                minX += c.MinimumWidth;
                minY += c.HeaderCell.Size.Height;
                c.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
            employeesGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            employeesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.MinimumSize = new System.Drawing.Size((int) (minX*1.5), minY * Math.Min(employeesGridView.RowCount, 3));
        }

        //Вспомогательный метод, обновляющий данные формы при каждом изменении
        //PrepareView передаёт форме перечень сотрудников с их данными
        private void UpdateViewData()
        {
            _presenter = new EmployeesMainPresenter(this);
            PrepareView();
        }
        #endregion
    }
}
