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
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BNclose = new Guna.UI2.WinForms.Guna2Button();
            this.uCpersonCardWithFilter3 = new HMS.People.Controls.UCpersonCardWithFilter();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(374, 27);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(202, 33);
            this.guna2HtmlLabel2.TabIndex = 1;
            this.guna2HtmlLabel2.Text = "FIND PERSON";
            // 
            // BNclose
            // 
            this.BNclose.BorderRadius = 20;
            this.BNclose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BNclose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BNclose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BNclose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BNclose.FillColor = System.Drawing.Color.Gray;
            this.BNclose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNclose.ForeColor = System.Drawing.Color.Black;
            this.BNclose.Image = global::HMS.Properties.Resources.close__1_;
            this.BNclose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BNclose.Location = new System.Drawing.Point(794, 561);
            this.BNclose.Name = "BNclose";
            this.BNclose.Size = new System.Drawing.Size(146, 45);
            this.BNclose.TabIndex = 2;
            this.BNclose.Text = "Close";
            this.BNclose.Click += new System.EventHandler(this.BNclose_Click_1);
            // 
            // uCpersonCardWithFilter3
            // 
            this.uCpersonCardWithFilter3.BackColor = System.Drawing.Color.Gainsboro;
            this.uCpersonCardWithFilter3.FilterEnabled = true;
            this.uCpersonCardWithFilter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uCpersonCardWithFilter3.Location = new System.Drawing.Point(13, 78);
            this.uCpersonCardWithFilter3.Margin = new System.Windows.Forms.Padding(4);
            this.uCpersonCardWithFilter3.Name = "uCpersonCardWithFilter3";
            this.uCpersonCardWithFilter3.ShowAddnewPerson = true;
            this.uCpersonCardWithFilter3.Size = new System.Drawing.Size(952, 478);
            this.uCpersonCardWithFilter3.TabIndex = 3;
            // 
            // FrmFindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1002, 613);
            this.Controls.Add(this.uCpersonCardWithFilter3);
            this.Controls.Add(this.BNclose);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Name = "FrmFindPerson";
            this.Text = "x";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private People.Controls.UCpersonCardWithFilter uCpersonCardWithFilter1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private People.Controls.UCpersonCardWithFilter uCpersonCardWithFilter2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button BNclose;
        private People.Controls.UCpersonCardWithFilter uCpersonCardWithFilter3;
    }
}

