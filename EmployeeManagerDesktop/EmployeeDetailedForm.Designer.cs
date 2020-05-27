namespace EmployeeManagerDesktop
{
    partial class EmployeeDetailedForm
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
            this.employeecardLabel = new System.Windows.Forms.Label();
            this.employeeDataListbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // employeecardLabel
            // 
            this.employeecardLabel.AutoSize = true;
            this.employeecardLabel.Location = new System.Drawing.Point(12, 9);
            this.employeecardLabel.Name = "employeecardLabel";
            this.employeecardLabel.Size = new System.Drawing.Size(155, 17);
            this.employeecardLabel.TabIndex = 1;
            this.employeecardLabel.Text = "Карточка сотрудника ";
            // 
            // employeeDataListbox
            // 
            this.employeeDataListbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeDataListbox.CausesValidation = false;
            this.employeeDataListbox.FormattingEnabled = true;
            this.employeeDataListbox.ItemHeight = 16;
            this.employeeDataListbox.Location = new System.Drawing.Point(12, 33);
            this.employeeDataListbox.Name = "employeeDataListbox";
            this.employeeDataListbox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.employeeDataListbox.Size = new System.Drawing.Size(356, 420);
            this.employeeDataListbox.TabIndex = 2;
            // 
            // EmployeeDetailedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(380, 460);
            this.Controls.Add(this.employeeDataListbox);
            this.Controls.Add(this.employeecardLabel);
            this.Name = "EmployeeDetailedForm";
            this.Text = "EmployeeDetailedForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label employeecardLabel;
        private System.Windows.Forms.ListBox employeeDataListbox;
    }
}