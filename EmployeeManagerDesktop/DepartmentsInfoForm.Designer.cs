namespace EmployeeManagerDesktop
{
    partial class DepartmentsInfoForm
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
            this.departmentsInfoListview = new System.Windows.Forms.ListView();
            this.headerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // departmentsInfoListview
            // 
            this.departmentsInfoListview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentsInfoListview.AutoArrange = false;
            this.departmentsInfoListview.BackColor = System.Drawing.Color.GhostWhite;
            this.departmentsInfoListview.HideSelection = false;
            this.departmentsInfoListview.Location = new System.Drawing.Point(13, 31);
            this.departmentsInfoListview.Name = "departmentsInfoListview";
            this.departmentsInfoListview.Size = new System.Drawing.Size(607, 428);
            this.departmentsInfoListview.TabIndex = 0;
            this.departmentsInfoListview.UseCompatibleStateImageBehavior = false;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Location = new System.Drawing.Point(13, 8);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(200, 17);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Всего сотрудников в отделах";
            // 
            // DepartmentsInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(632, 471);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.departmentsInfoListview);
            this.Name = "DepartmentsInfoForm";
            this.Text = "DepartmentsInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView departmentsInfoListview;
        private System.Windows.Forms.Label headerLabel;
    }
}