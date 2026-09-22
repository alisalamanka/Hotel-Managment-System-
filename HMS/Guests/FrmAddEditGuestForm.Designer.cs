namespace HMS.Guests
{
    partial class FrmAddEditGuestForm
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
            this.uCpersonCardWithFilter1 = new HMS.People.Controls.UCpersonCardWithFilter();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.GBGuestInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.CBisActive = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblGuestID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.GBGuestInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // uCpersonCardWithFilter1
            // 
            this.uCpersonCardWithFilter1.BackColor = System.Drawing.Color.Gainsboro;
            this.uCpersonCardWithFilter1.FilterEnabled = true;
            this.uCpersonCardWithFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uCpersonCardWithFilter1.Location = new System.Drawing.Point(58, 112);
            this.uCpersonCardWithFilter1.Margin = new System.Windows.Forms.Padding(6);
            this.uCpersonCardWithFilter1.Name = "uCpersonCardWithFilter1";
            this.uCpersonCardWithFilter1.ShowAddnewPerson = true;
            this.uCpersonCardWithFilter1.Size = new System.Drawing.Size(956, 477);
            this.uCpersonCardWithFilter1.TabIndex = 0;
            this.uCpersonCardWithFilter1.OnPersonSelected += new System.Action<int>(this.uCpersonCardWithFilter1_OnPersonSelected);
            this.uCpersonCardWithFilter1.Load += new System.EventHandler(this.uCpersonCardWithFilter1_Load);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(379, 48);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(241, 39);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Add New Guest";
            // 
            // btnNext
            // 
            this.btnNext.BorderRadius = 15;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.DarkGray;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Image = global::HMS.Properties.Resources.confirm;
            this.btnNext.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNext.ImageSize = new System.Drawing.Size(30, 30);
            this.btnNext.Location = new System.Drawing.Point(804, 598);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(180, 45);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // GBGuestInfo
            // 
            this.GBGuestInfo.BorderRadius = 17;
            this.GBGuestInfo.Controls.Add(this.CBisActive);
            this.GBGuestInfo.Controls.Add(this.guna2HtmlLabel3);
            this.GBGuestInfo.Controls.Add(this.lblGuestID);
            this.GBGuestInfo.Controls.Add(this.guna2HtmlLabel1);
            this.GBGuestInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GBGuestInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.GBGuestInfo.Location = new System.Drawing.Point(83, 664);
            this.GBGuestInfo.Name = "GBGuestInfo";
            this.GBGuestInfo.Size = new System.Drawing.Size(901, 126);
            this.GBGuestInfo.TabIndex = 3;
            this.GBGuestInfo.Text = "Guest Informations";
            // 
            // CBisActive
            // 
            this.CBisActive.AutoSize = true;
            this.CBisActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBisActive.CheckedState.BorderRadius = 0;
            this.CBisActive.CheckedState.BorderThickness = 0;
            this.CBisActive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBisActive.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBisActive.Location = new System.Drawing.Point(556, 74);
            this.CBisActive.MaximumSize = new System.Drawing.Size(40, 40);
            this.CBisActive.MinimumSize = new System.Drawing.Size(15, 15);
            this.CBisActive.Name = "CBisActive";
            this.CBisActive.Size = new System.Drawing.Size(15, 15);
            this.CBisActive.TabIndex = 3;
            this.CBisActive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CBisActive.UncheckedState.BorderRadius = 0;
            this.CBisActive.UncheckedState.BorderThickness = 0;
            this.CBisActive.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(463, 68);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(75, 23);
            this.guna2HtmlLabel3.TabIndex = 2;
            this.guna2HtmlLabel3.Text = "Is Active : ";
            // 
            // lblGuestID
            // 
            this.lblGuestID.BackColor = System.Drawing.Color.Transparent;
            this.lblGuestID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestID.ForeColor = System.Drawing.Color.Black;
            this.lblGuestID.Location = new System.Drawing.Point(143, 68);
            this.lblGuestID.Name = "lblGuestID";
            this.lblGuestID.Size = new System.Drawing.Size(31, 23);
            this.lblGuestID.TabIndex = 1;
            this.lblGuestID.Text = "????";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(25, 68);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(75, 23);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Guest ID : ";
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 15;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.DarkGray;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = global::HMS.Properties.Resources.confirm;
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSave.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSave.Location = new System.Drawing.Point(804, 823);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 45);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmAddEditGuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1049, 921);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.GBGuestInfo);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.uCpersonCardWithFilter1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAddEditGuestForm";
            this.Text = "FrmAddEditGuestForm";
            this.Load += new System.EventHandler(this.FrmAddEditGuestForm_Load);
            this.GBGuestInfo.ResumeLayout(false);
            this.GBGuestInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private People.Controls.UCpersonCardWithFilter uCpersonCardWithFilter1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2GroupBox GBGuestInfo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblGuestID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2CheckBox CBisActive;
    }
}