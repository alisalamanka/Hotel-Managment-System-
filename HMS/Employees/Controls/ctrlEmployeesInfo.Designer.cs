namespace HMS.Employees.Controls
{
    partial class ctrlEmployeesInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uCpersonCard1 = new HMS.People.Controls.UCpersonCard();
            this.GBpersonInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.GBpersonInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // uCpersonCard1
            // 
            this.uCpersonCard1.BackColor = System.Drawing.Color.Gainsboro;
            this.uCpersonCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uCpersonCard1.Location = new System.Drawing.Point(16, 15);
            this.uCpersonCard1.Margin = new System.Windows.Forms.Padding(4);
            this.uCpersonCard1.Name = "uCpersonCard1";
            this.uCpersonCard1.Size = new System.Drawing.Size(923, 308);
            this.uCpersonCard1.TabIndex = 0;
            // 
            // GBpersonInfo
            // 
            this.GBpersonInfo.BorderRadius = 20;
            this.GBpersonInfo.Controls.Add(this.guna2HtmlLabel3);
            this.GBpersonInfo.Controls.Add(this.guna2HtmlLabel2);
            this.GBpersonInfo.Controls.Add(this.guna2HtmlLabel1);
            this.GBpersonInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GBpersonInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.GBpersonInfo.Location = new System.Drawing.Point(16, 341);
            this.GBpersonInfo.Name = "GBpersonInfo";
            this.GBpersonInfo.Size = new System.Drawing.Size(912, 200);
            this.GBpersonInfo.TabIndex = 1;
            this.GBpersonInfo.Text = "Employee Information";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(48, 68);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(104, 23);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Employee ID: ";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(489, 68);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(99, 23);
            this.guna2HtmlLabel2.TabIndex = 1;
            this.guna2HtmlLabel2.Text = "Department: ";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(48, 128);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(54, 23);
            this.guna2HtmlLabel3.TabIndex = 2;
            this.guna2HtmlLabel3.Text = "Salary: ";
            // 
            // ctrlEmployeesInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.GBpersonInfo);
            this.Controls.Add(this.uCpersonCard1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ctrlEmployeesInfo";
            this.Size = new System.Drawing.Size(981, 616);
            this.GBpersonInfo.ResumeLayout(false);
            this.GBpersonInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private People.Controls.UCpersonCard uCpersonCard1;
        private Guna.UI2.WinForms.Guna2GroupBox GBpersonInfo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}
