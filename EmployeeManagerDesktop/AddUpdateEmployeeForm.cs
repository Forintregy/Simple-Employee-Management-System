using EmployeeManagerModel;
using EmployeeManagerPresentation;
using EmployeeManagerPresentation.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;


namespace EmployeeManagerDesktop
{
    public partial class AddUpdateEmployeeForm : Form, IAddUpdateEmployeeView
    {
        private AddUpdateEmployeePresenter _presenter;
        private int EmployeeId = 0;
        public IEnumerable<Department> Departments { set => departmentsComboBox.DataSource = value.ToList(); }
        public Employee NewEmployee => CreateEmployee();
        public Department NewDepartment => CreateDepartment();

        public event VoidEventHandler AddUpdateEmployee;
        public event VoidEventHandler PrepareView;

        //Конструктор по умолчанию
        //При передаче существующего Employee заполняются все поля формы
        //В противном случае, поля остаются пустыми
        public AddUpdateEmployeeForm(Employee employeeToUpdate = null)
        {
            InitializeComponent();
            _presenter = new AddUpdateEmployeePresenter(this);
            if (employeeToUpdate == null) EmployeeId = 0;
            else
            {
                this.Text = employeeToUpdate.ToString();
                EmployeeId = employeeToUpdate.Id;
            }
            PrepareView();
            if (employeeToUpdate != null) UpdateFormFields(employeeToUpdate);
            this.ActiveControl = lastNameTextBox;
        }


        #region Методы создания новых сущностей
        private Employee CreateEmployee()
        {
            var employeeAddress = new Address
            {
                Country = countryTextBox.Text.Trim(),
                ZipCode = zipcodeTextBox.Text.Trim(),
                Region = regionTextBox.Text.Trim(),
                City = cityTextBox.Text.Trim(),
                StreetAddress = streetTextBox.Text.Trim(),
                Apartment = apartmentTextBox.Text.Trim()
            };
            return new Employee
            {
                Id = EmployeeId,
                LastName = lastNameTextBox.Text.Trim(),
                FirstName = firstNameTextBox.Text.Trim(),
                Department = (Department) departmentsComboBox.SelectedItem ?? NewDepartment,
                About = aboutTextBox.Text.Trim(),
                SecondName = secondNameTextBox.Text.Trim(),
                DateOfBirth = dateOfBirthPicker.Value,
                Address = employeeAddress
            };
        }

        private Department CreateDepartment()
        {
            return new Department
            {
                DepartmentName = departmentsComboBox.Text.Trim()
            };
        }
        #endregion

        #region События нажатия кнопок
        //Очистка всех полей ввода
        private void cleanInputsButton_Click(object sender, EventArgs e)
        {
            UpdateFormFields();
        }
        
        // Добавление нового пользоваетля в базу данных с валидацией ввода
        private void addUpdateEmployeeButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Selectable))
            {
                if (EmployeeId != 0)
                {
                    var confirmAction = MessageBox.Show($"Вы уверены, что хотите изменить данные этого сотрудника:\n" +
                                                        $"{lastNameTextBox.Text} {firstNameTextBox.Text}" +
                                                        $", {departmentsComboBox.SelectedItem ?? $" и создать отдел {departmentsComboBox.Text}?"}",
                                             "Подтвердите обновление",
                                             MessageBoxButtons.YesNoCancel);
                    if (confirmAction == DialogResult.Cancel) DialogResult = DialogResult.Cancel;
                    else if (confirmAction == DialogResult.No) DialogResult = DialogResult.None;
                }
                if (DialogResult != DialogResult.Cancel && DialogResult != DialogResult.None) AddUpdateEmployee();
            }
            else
            {
                MessageBox.Show(this, "Часть данных не соответствует требованиям. \n Проверьте информацию еще раз", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DialogResult = DialogResult.None;
            }
        }

        private void cancelAddUpdateEmployeeButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

       
        //Заполнение полей ввода данными пользователя при обновлении данных существующего Employee
        private void UpdateFormFields(Employee employee = null)
        {
            lastNameTextBox.Text = employee?.LastName;
            firstNameTextBox.Text = employee?.FirstName;
            departmentsComboBox.SelectedIndex =
                employee == null ? 0 : departmentsComboBox.FindString(employee.Department.DepartmentName);
            aboutTextBox.Text = employee?.About;
            secondNameTextBox.Text = employee?.SecondName;
            dateOfBirthPicker.Value = employee == null ? DateTime.Now : employee.DateOfBirth;
            countryTextBox.Text = employee?.Address?.Country;
            zipcodeTextBox.Text = employee?.Address?.ZipCode;
            regionTextBox.Text = employee?.Address?.Region;
            cityTextBox.Text = employee?.Address?.City;
            streetTextBox.Text = employee?.Address?.StreetAddress;
            apartmentTextBox.Text = employee?.Address?.Apartment;
        }
        #endregion

        #region Валидация и форматирование полей 
        //Здесь находятся события и методы валидации и форматирования пользовательского ввода

        
        //Проверка на наличие символов в поле ввода
        private bool ValidateInputAlphabeticalNotEmpty(Control control)
        {
            if (string.IsNullOrEmpty(control.Text.Trim()) || !Regex.IsMatch(control.Text.Trim(), "[A-Za-zА-Яа-я]+"))
            {
                employeeDataErrorProvider.SetError(control, "Поле не должно быть пустым и может содержать только буквы");
                attentionLabel.ForeColor = Color.Red;
                return true;
            }
            else
            {
                employeeDataErrorProvider.Clear();
                attentionLabel.ForeColor = Color.Black;
                return false;
            }
        }

        //Удаление пробелов в начале и конце строки (при событии смены фокуса элемента)
        private void control_Trim(object sender, EventArgs e)
        {
            var control = sender as Control;
            control.Text = control.Text.Trim();
            control.Update();
        }
        
        // Проверка на наличие исключительно буквенных символов
        private bool ValidateInputAlphabetical(Control control)
        {
            if (!string.IsNullOrEmpty(control.Text.Trim()) && !Regex.IsMatch(control.Text.Trim(), "[A-Za-zА-Яа-я]+"))
            {
                employeeDataErrorProvider.SetError(control, "Поле может содержать только буквы");
                return true;
            }
            return false;
        }

        private void textBox_ValidatingAlphabeticalNotEmpty(object sender, CancelEventArgs e)
        {
            e.Cancel = ValidateInputAlphabeticalNotEmpty(sender as Control);
        }

        private void textBox_ValidatingOnlyLetters(object sender, CancelEventArgs e)
        {
            e.Cancel = ValidateInputAlphabetical(sender as Control);
        }

        
        #endregion

        #region Всплывающие подсказки
        private void tooltipAlphabeticalNotEmpty(object sender, MouseEventArgs e)
        {
            ShowToolTip("Значение должно быть буквенным и не может быть пустым",
                    (Control)sender);
        }

        private void tooltipAlphabeticalEmpty(object sender, MouseEventArgs e)
        {
            ShowToolTip("Значение должно быть буквенным (может быть пустым)",
                    (Control)sender);
        }

        private void departmentsComboBox_TextUpdate(object sender, EventArgs e)
        {
            ShowToolTip("Изменение названия приведёт к \nдобавлению нового отдела", sender as Control);
        }

        //Метод вывода подсказки
        private void ShowToolTip(string message, Control sender)
        {
            Point position = this.PointToClient(Cursor.Position);
            //Коррекция по оси Y подобрана эмпирическим путём :)
            position.Offset(0, -50);
            var tooltip = new ToolTip
            {
                InitialDelay = 0,
                IsBalloon = true,
                ToolTipIcon = ToolTipIcon.Info,
                UseFading = true
            };
            tooltip.Show(message, this, position, 2000);
        }

        #endregion

       
    }
}
