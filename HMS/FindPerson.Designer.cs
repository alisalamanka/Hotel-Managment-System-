namespace HMS
{
    partial class FrmFindPerson
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.uCpersonCardWithFilter1 = new HMS.People.Controls.UCpersonCardWithFilter();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(359, 22);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(199, 38);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Find Person";
            // 
            // uCpersonCardWithFilter1
            // 
            this.uCpersonCardWithFilter1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.uCpersonCardWithFilter1.FilterEnabled = true;
            this.uCpersonCardWithFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uCpersonCardWithFilter1.Location = new System.Drawing.Point(3, 67);
            this.uCpersonCardWithFilter1.Margin = new System.Windows.Forms.Padding(4);
            this.uCpersonCardWithFilter1.Name = "uCpersonCardWithFilter1";
            this.uCpersonCardWithFilter1.ShowAddnewPerson = true;
            this.uCpersonCardWithFilter1.Size = new System.Drawing.Size(952, 466);
            this.uCpersonCardWithFilter1.TabIndex = 2;
            // 
            // FrmFindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(985, 544);
            this.Controls.Add(this.uCpersonCardWithFilter1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "FrmFindPerson";
            this.Text = "Find Person";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private People.Controls.UCpersonCardWithFilter uCpersonCardWithFilter1;
    }
}

