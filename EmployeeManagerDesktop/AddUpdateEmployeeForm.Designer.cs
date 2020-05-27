namespace EmployeeManagerDesktop
{
    partial class AddUpdateEmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()

        {
            this.components = new System.ComponentModel.Container();
            this.headerLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.secondnameLabel = new System.Windows.Forms.Label();
            this.dateofbirthLabel = new System.Windows.Forms.Label();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.secondNameTextBox = new System.Windows.Forms.TextBox();
            this.aboutTextBox = new System.Windows.Forms.TextBox();
            this.departmentsComboBox = new System.Windows.Forms.ComboBox();
            this.cleanInputsButton = new System.Windows.Forms.Button();
            this.cancelAddUpdateEmployeeButton = new System.Windows.Forms.Button();
            this.dateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.employeeDataErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.addUpdateEmployeeButton = new System.Windows.Forms.Button();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.zipcodeTextBox = new System.Windows.Forms.TextBox();
            this.regionTextBox = new System.Windows.Forms.TextBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.apartmentTextBox = new System.Windows.Forms.TextBox();
            this.zipcodeLabel = new System.Windows.Forms.Label();
            this.regionLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.apartmentLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.attentionLabel = new System.Windows.Forms.Label();
            this.personalDataGroup = new System.Windows.Forms.GroupBox();
            this.addressGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataErrorProvider)).BeginInit();
            this.personalDataGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerLabel.Location = new System.Drawing.Point(16, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(227, 17);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Введите данные сотрудника:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(155, 73);
            this.lastNameTextBox.MaxLength = 50;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(256, 22);
            this.lastNameTextBox.TabIndex = 1;
            this.lastNameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tooltipAlphabeticalNotEmpty);
            this.lastNameTextBox.Leave += new System.EventHandler(this.control_Trim);
            this.lastNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_ValidatingAlphabeticalNotEmpty);
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Location = new System.Drawing.Point(16, 78);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(83, 17);
            this.lastnameLabel.TabIndex = 2;
            this.lastnameLabel.Text = "Фамилия: *";
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Location = new System.Drawing.Point(16, 116);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(48, 17);
            this.firstnameLabel.TabIndex = 2;
            this.firstnameLabel.Text = "Имя: *";
            // 
            // secondnameLabel
            // 
            this.secondnameLabel.AutoSize = true;
            this.secondnameLabel.Location = new System.Drawing.Point(16, 154);
            this.secondnameLabel.Name = "secondnameLabel";
            this.secondnameLabel.Size = new System.Drawing.Size(75, 17);
            this.secondnameLabel.TabIndex = 2;
            this.secondnameLabel.Text = "Отчество:";
            // 
            // dateofbirthLabel
            // 
            this.dateofbirthLabel.AutoSize = true;
            this.dateofbirthLabel.Location = new System.Drawing.Point(16, 192);
            this.dateofbirthLabel.Name = "dateofbirthLabel";
            this.dateofbirthLabel.Size = new System.Drawing.Size(124, 17);
            this.dateofbirthLabel.TabIndex = 2;
            this.dateofbirthLabel.Text = "Дата рождения: *";
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Location = new System.Drawing.Point(16, 229);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(63, 17);
            this.departmentLabel.TabIndex = 2;
            this.departmentLabel.Text = "Отдел: *";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(155, 111);
            this.firstNameTextBox.MaxLength = 50;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(256, 22);
            this.firstNameTextBox.TabIndex = 1;
            this.firstNameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tooltipAlphabeticalNotEmpty);
            this.firstNameTextBox.Leave += new System.EventHandler(this.control_Trim);
            this.firstNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_ValidatingAlphabeticalNotEmpty);
            // 
            // secondNameTextBox
            // 
            this.secondNameTextBox.Location = new System.Drawing.Point(155, 149);
            this.secondNameTextBox.MaxLength = 50;
            this.secondNameTextBox.Name = "secondNameTextBox";
            this.secondNameTextBox.Size = new System.Drawing.Size(256, 22);
            this.secondNameTextBox.TabIndex = 1;
            this.secondNameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tooltipAlphabeticalEmpty);
            this.secondNameTextBox.Leave += new System.EventHandler(this.control_Trim);
            this.secondNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_ValidatingOnlyLetters);
            // 
            // aboutTextBox
            // 
            this.aboutTextBox.CausesValidation = false;
            this.aboutTextBox.Location = new System.Drawing.Point(143, 223);
            this.aboutTextBox.Multiline = true;
            this.aboutTextBox.Name = "aboutTextBox";
            this.aboutTextBox.Size = new System.Drawing.Size(256, 130);
            this.aboutTextBox.TabIndex = 1;
            this.aboutTextBox.Leave += new System.EventHandler(this.control_Trim);
            // 
            // departmentsComboBox
            // 
            this.departmentsComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.departmentsComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.departmentsComboBox.FormattingEnabled = true;
            this.departmentsComboBox.Location = new System.Drawing.Point(155, 225);
            this.departmentsComboBox.MaxLength = 100;
            this.departmentsComboBox.Name = "departmentsComboBox";
            this.departmentsComboBox.Size = new System.Drawing.Size(256, 24);
            this.departmentsComboBox.TabIndex = 3;
            this.departmentsComboBox.TextUpdate += new System.EventHandler(this.departmentsComboBox_TextUpdate);
            this.departmentsComboBox.Leave += new System.EventHandler(this.control_Trim);
            this.departmentsComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tooltipAlphabeticalNotEmpty);
            this.departmentsComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_ValidatingAlphabeticalNotEmpty);
            // 
            // cleanInputsButton
            // 
            this.cleanInputsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cleanInputsButton.BackColor = System.Drawing.Color.Linen;
            this.cleanInputsButton.CausesValidation = false;
            this.cleanInputsButton.Location = new System.Drawing.Point(791, 388);
            this.cleanInputsButton.Name = "cleanInputsButton";
            this.cleanInputsButton.Size = new System.Drawing.Size(75, 30);
            this.cleanInputsButton.TabIndex = 4;
            this.cleanInputsButton.Text = "&Сброс";
            this.cleanInputsButton.UseVisualStyleBackColor = false;
            this.cleanInputsButton.Click += new System.EventHandler(this.cleanInputsButton_Click);
            // 
            // cancelAddUpdateEmployeeButton
            // 
            this.cancelAddUpdateEmployeeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelAddUpdateEmployeeButton.BackColor = System.Drawing.Color.Linen;
            this.cancelAddUpdateEmployeeButton.CausesValidation = false;
            this.cancelAddUpdateEmployeeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelAddUpdateEmployeeButton.Location = new System.Drawing.Point(710, 387);
            this.cancelAddUpdateEmployeeButton.Name = "cancelAddUpdateEmployeeButton";
            this.cancelAddUpdateEmployeeButton.Size = new System.Drawing.Size(75, 30);
            this.cancelAddUpdateEmployeeButton.TabIndex = 4;
            this.cancelAddUpdateEmployeeButton.Text = "&Отмена";
            this.cancelAddUpdateEmployeeButton.UseVisualStyleBackColor = false;
            this.cancelAddUpdateEmployeeButton.Click += new System.EventHandler(this.cancelAddUpdateEmployeeButton_Click);
            // 
            // dateOfBirthPicker
            // 
            this.dateOfBirthPicker.Location = new System.Drawing.Point(155, 187);
            this.dateOfBirthPicker.Name = "dateOfBirthPicker";
            this.dateOfBirthPicker.Size = new System.Drawing.Size(256, 22);
            this.dateOfBirthPicker.TabIndex = 6;
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Location = new System.Drawing.Point(4, 226);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(58, 17);
            this.aboutLabel.TabIndex = 2;
            this.aboutLabel.Text = "О себе:";
            // 
            // employeeDataErrorProvider
            // 
            this.employeeDataErrorProvider.BlinkRate = 0;
            this.employeeDataErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.employeeDataErrorProvider.ContainerControl = this;
            // 
            // addUpdateEmployeeButton
            // 
            this.addUpdateEmployeeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addUpdateEmployeeButton.BackColor = System.Drawing.Color.Linen;
            this.addUpdateEmployeeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addUpdateEmployeeButton.Location = new System.Drawing.Point(631, 387);
            this.addUpdateEmployeeButton.Name = "addUpdateEmployeeButton";
            this.addUpdateEmployeeButton.Size = new System.Drawing.Size(73, 30);
            this.addUpdateEmployeeButton.TabIndex = 4;
            this.addUpdateEmployeeButton.Text = "&Готово";
            this.addUpdateEmployeeButton.UseVisualStyleBackColor = false;
            this.addUpdateEmployeeButton.Click += new System.EventHandler(this.addUpdateEmployeeButton_Click);
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(598, 73);
            this.countryTextBox.MaxLength = 70;
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(256, 22);
            this.countryTextBox.TabIndex = 1;
            this.countryTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tooltipAlphabeticalNotEmpty);
            this.countryTextBox.Leave += new System.EventHandler(this.control_Trim);
            this.countryTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_ValidatingAlphabeticalNotEmpty);
            // 
            // zipcodeTextBox
            // 
            this.zipcodeTextBox.CausesValidation = false;
            this.zipcodeTextBox.Location = new System.Drawing.Point(598, 111);
            this.zipcodeTextBox.MaxLength = 20;
            this.zipcodeTextBox.Name = "zipcodeTextBox";
            this.zipcodeTextBox.Size = new System.Drawing.Size(256, 22);
            this.zipcodeTextBox.TabIndex = 1;
            this.zipcodeTextBox.Leave += new System.EventHandler(this.control_Trim);
            // 
            // regionTextBox
            // 
            this.regionTextBox.Location = new System.Drawing.Point(598, 149);
            this.regionTextBox.MaxLength = 100;
            this.regionTextBox.Name = "regionTextBox";
            this.regionTextBox.Size = new System.Drawing.Size(256, 22);
            this.regionTextBox.TabIndex = 1;
            this.regionTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tooltipAlphabeticalEmpty);
            this.regionTextBox.Leave += new System.EventHandler(this.control_Trim);
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(450, 78);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(69, 17);
            this.countryLabel.TabIndex = 2;
            this.countryLabel.Text = "Страна: *";
            // 
            // apartmentTextBox
            // 
            this.apartmentTextBox.CausesValidation = false;
            this.apartmentTextBox.Location = new System.Drawing.Point(598, 263);
            this.apartmentTextBox.MaxLength = 100;
            this.apartmentTextBox.Name = "apartmentTextBox";
            this.apartmentTextBox.Size = new System.Drawing.Size(256, 22);
            this.apartmentTextBox.TabIndex = 1;
            this.apartmentTextBox.Leave += new System.EventHandler(this.control_Trim);
            // 
            // zipcodeLabel
            // 
            this.zipcodeLabel.AutoSize = true;
            this.zipcodeLabel.Location = new System.Drawing.Point(450, 116);
            this.zipcodeLabel.Name = "zipcodeLabel";
            this.zipcodeLabel.Size = new System.Drawing.Size(128, 17);
            this.zipcodeLabel.TabIndex = 2;
            this.zipcodeLabel.Text = "Почтовый индекс:";
            // 
            // regionLabel
            // 
            this.regionLabel.AutoSize = true;
            this.regionLabel.Location = new System.Drawing.Point(450, 154);
            this.regionLabel.Name = "regionLabel";
            this.regionLabel.Size = new System.Drawing.Size(117, 17);
            this.regionLabel.TabIndex = 2;
            this.regionLabel.Text = "Область/регион:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(450, 192);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(141, 17);
            this.cityLabel.TabIndex = 2;
            this.cityLabel.Text = "Населенный пункт:*";
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(450, 229);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(95, 17);
            this.streetLabel.TabIndex = 2;
            this.streetLabel.Text = "Улица, дом: *";
            // 
            // apartmentLabel
            // 
            this.apartmentLabel.AutoSize = true;
            this.apartmentLabel.Location = new System.Drawing.Point(450, 268);
            this.apartmentLabel.Name = "apartmentLabel";
            this.apartmentLabel.Size = new System.Drawing.Size(122, 17);
            this.apartmentLabel.TabIndex = 2;
            this.apartmentLabel.Text = "Номер квартиры:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(598, 187);
            this.cityTextBox.MaxLength = 50;
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(256, 22);
            this.cityTextBox.TabIndex = 1;
            this.cityTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tooltipAlphabeticalNotEmpty);
            this.cityTextBox.Leave += new System.EventHandler(this.control_Trim);
            this.cityTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_ValidatingAlphabeticalNotEmpty);
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(598, 225);
            this.streetTextBox.MaxLength = 100;
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(256, 22);
            this.streetTextBox.TabIndex = 1;
            this.streetTextBox.Leave += new System.EventHandler(this.control_Trim);
            this.streetTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_ValidatingAlphabeticalNotEmpty);
            // 
            // attentionLabel
            // 
            this.attentionLabel.AutoSize = true;
            this.attentionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attentionLabel.Location = new System.Drawing.Point(599, 310);
            this.attentionLabel.Name = "attentionLabel";
            this.attentionLabel.Size = new System.Drawing.Size(252, 17);
            this.attentionLabel.TabIndex = 0;
            this.attentionLabel.Text = "* - обязательно для заполнения";
            // 
            // personalDataGroup
            // 
            this.personalDataGroup.Controls.Add(this.aboutTextBox);
            this.personalDataGroup.Controls.Add(this.aboutLabel);
            this.personalDataGroup.Location = new System.Drawing.Point(12, 45);
            this.personalDataGroup.Name = "personalDataGroup";
            this.personalDataGroup.Size = new System.Drawing.Size(416, 372);
            this.personalDataGroup.TabIndex = 7;
            this.personalDataGroup.TabStop = false;
            this.personalDataGroup.Text = "Личные данные:";
            // 
            // addressGroupBox
            // 
            this.addressGroupBox.Location = new System.Drawing.Point(441, 45);
            this.addressGroupBox.Name = "addressGroupBox";
            this.addressGroupBox.Size = new System.Drawing.Size(426, 313);
            this.addressGroupBox.TabIndex = 8;
            this.addressGroupBox.TabStop = false;
            this.addressGroupBox.Text = "Адрес:";
            // 
            // AddUpdateEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.CancelButton = this.cancelAddUpdateEmployeeButton;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(879, 435);
            this.Controls.Add(this.dateOfBirthPicker);
            this.Controls.Add(this.addUpdateEmployeeButton);
            this.Controls.Add(this.cancelAddUpdateEmployeeButton);
            this.Controls.Add(this.cleanInputsButton);
            this.Controls.Add(this.departmentsComboBox);
            this.Controls.Add(this.apartmentLabel);
            this.Controls.Add(this.streetLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.regionLabel);
            this.Controls.Add(this.dateofbirthLabel);
            this.Controls.Add(this.zipcodeLabel);
            this.Controls.Add(this.secondnameLabel);
            this.Controls.Add(this.apartmentTextBox);
            this.Controls.Add(this.firstnameLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.lastnameLabel);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.regionTextBox);
            this.Controls.Add(this.zipcodeTextBox);
            this.Controls.Add(this.secondNameTextBox);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.attentionLabel);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.personalDataGroup);
            this.Controls.Add(this.addressGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddUpdateEmployeeForm";
            this.Text = "Новый сотрудник";
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataErrorProvider)).EndInit();
            this.personalDataGroup.ResumeLayout(false);
            this.personalDataGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.Label secondnameLabel;
        protected internal System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label dateofbirthLabel;
        private System.Windows.Forms.Label departmentLabel;
        protected internal System.Windows.Forms.TextBox firstNameTextBox;
        protected internal System.Windows.Forms.TextBox secondNameTextBox;
        protected internal System.Windows.Forms.TextBox aboutTextBox;
        protected internal System.Windows.Forms.ComboBox departmentsComboBox;
        private System.Windows.Forms.Button cleanInputsButton;
        private System.Windows.Forms.Button cancelAddUpdateEmployeeButton;
        public System.Windows.Forms.DateTimePicker dateOfBirthPicker;
        private System.Windows.Forms.Label aboutLabel;
        public System.Windows.Forms.ErrorProvider employeeDataErrorProvider;
        private System.Windows.Forms.Button addUpdateEmployeeButton;
        private System.Windows.Forms.Label apartmentLabel;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label regionLabel;
        protected internal System.Windows.Forms.TextBox apartmentTextBox;
        private System.Windows.Forms.Label countryLabel;
        protected internal System.Windows.Forms.TextBox regionTextBox;
        protected internal System.Windows.Forms.TextBox zipcodeTextBox;
        protected internal System.Windows.Forms.TextBox countryTextBox;
        internal System.Windows.Forms.Label zipcodeLabel;
        protected internal System.Windows.Forms.TextBox streetTextBox;
        protected internal System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label attentionLabel;
        private System.Windows.Forms.GroupBox personalDataGroup;
        private System.Windows.Forms.GroupBox addressGroupBox;
    }
}