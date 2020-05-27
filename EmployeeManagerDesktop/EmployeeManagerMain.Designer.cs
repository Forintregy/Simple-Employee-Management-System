namespace EmployeeManagerDesktop
{
    partial class EmployeeManagerMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.employeesGridView = new System.Windows.Forms.DataGridView();
            this.buttonDeleteEmployee = new System.Windows.Forms.Button();
            this.buttonEditEmployee = new System.Windows.Forms.Button();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.detailsButton = new System.Windows.Forms.Button();
            this.departmentsInfoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // employeesGridView
            // 
            this.employeesGridView.AllowUserToAddRows = false;
            this.employeesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeesGridView.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.employeesGridView.CausesValidation = false;
            this.employeesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeesGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.employeesGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.employeesGridView.GridColor = System.Drawing.Color.Azure;
            this.employeesGridView.Location = new System.Drawing.Point(13, 12);
            this.employeesGridView.Name = "employeesGridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeesGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.employeesGridView.RowHeadersVisible = false;
            this.employeesGridView.RowTemplate.Height = 24;
            this.employeesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeesGridView.Size = new System.Drawing.Size(775, 400);
            this.employeesGridView.TabIndex = 0;
            this.employeesGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.employeesGridView_ColumnHeaderMouseClick);
            this.employeesGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.employeesGridView_DataBindingComplete);
            // 
            // buttonDeleteEmployee
            // 
            this.buttonDeleteEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteEmployee.Location = new System.Drawing.Point(570, 419);
            this.buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            this.buttonDeleteEmployee.Size = new System.Drawing.Size(106, 29);
            this.buttonDeleteEmployee.TabIndex = 1;
            this.buttonDeleteEmployee.Text = "&Удалить";
            this.buttonDeleteEmployee.UseVisualStyleBackColor = true;
            this.buttonDeleteEmployee.Click += new System.EventHandler(this.buttonDeleteEmployee_Click);
            // 
            // buttonEditEmployee
            // 
            this.buttonEditEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditEmployee.Location = new System.Drawing.Point(458, 419);
            this.buttonEditEmployee.Name = "buttonEditEmployee";
            this.buttonEditEmployee.Size = new System.Drawing.Size(106, 29);
            this.buttonEditEmployee.TabIndex = 1;
            this.buttonEditEmployee.Text = "&Изменить";
            this.buttonEditEmployee.UseVisualStyleBackColor = true;
            this.buttonEditEmployee.Click += new System.EventHandler(this.buttonEditEmployee_Click);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddEmployee.Location = new System.Drawing.Point(346, 419);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(106, 29);
            this.buttonAddEmployee.TabIndex = 1;
            this.buttonAddEmployee.Text = "&Добавить";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // detailsButton
            // 
            this.detailsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsButton.Location = new System.Drawing.Point(682, 419);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(106, 29);
            this.detailsButton.TabIndex = 1;
            this.detailsButton.Text = "&Просмотр";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // departmentsInfoButton
            // 
            this.departmentsInfoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.departmentsInfoButton.Location = new System.Drawing.Point(13, 418);
            this.departmentsInfoButton.Name = "departmentsInfoButton";
            this.departmentsInfoButton.Size = new System.Drawing.Size(75, 30);
            this.departmentsInfoButton.TabIndex = 2;
            this.departmentsInfoButton.Text = "&Отделы";
            this.departmentsInfoButton.UseVisualStyleBackColor = true;
            this.departmentsInfoButton.Click += new System.EventHandler(this.departmentsInfoButton_Click);
            // 
            // EmployeeManagerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.departmentsInfoButton);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.buttonEditEmployee);
            this.Controls.Add(this.buttonDeleteEmployee);
            this.Controls.Add(this.employeesGridView);
            this.Name = "EmployeeManagerMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.employeesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView employeesGridView;
        private System.Windows.Forms.Button buttonDeleteEmployee;
        private System.Windows.Forms.Button buttonEditEmployee;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.Button departmentsInfoButton;
    }
}

