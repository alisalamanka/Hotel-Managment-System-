namespace HMS.Users.UserControls
{
    partial class ctrlUserInfoWithFilter
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
            this.ctrlUserInfo1 = new HMS.Users.UserControls.ctrlUserInfo();
            this.GBfilter = new Guna.UI2.WinForms.Guna2GroupBox();
            this.CBfilterby = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFilterByValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnfinduser = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddUser = new Guna.UI2.WinForms.Guna2Button();
            this.GBfilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlUserInfo1
            // 
            this.ctrlUserInfo1.BackColor = System.Drawing.Color.Gainsboro;
            this.ctrlUserInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlUserInfo1.Location = new System.Drawing.Point(23, 149);
            this.ctrlUserInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlUserInfo1.Name = "ctrlUserInfo1";
            this.ctrlUserInfo1.Size = new System.Drawing.Size(966, 526);
            this.ctrlUserInfo1.TabIndex = 0;
            this.ctrlUserInfo1.Load += new System.EventHandler(this.ctrlUserInfo1_Load);
            // 
            // GBfilter
            // 
            this.GBfilter.BorderRadius = 17;
            this.GBfilter.Controls.Add(this.btnAddUser);
            this.GBfilter.Controls.Add(this.btnfinduser);
            this.GBfilter.Controls.Add(this.txtFilterByValue);
            this.GBfilter.Controls.Add(this.CBfilterby);
            this.GBfilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GBfilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.GBfilter.Location = new System.Drawing.Point(57, 20);
            this.GBfilter.Name = "GBfilter";
            this.GBfilter.Size = new System.Drawing.Size(912, 121);
            this.GBfilter.TabIndex = 1;
            this.GBfilter.Text = "Filter";
            // 
            // CBfilterby
            // 
            this.CBfilterby.BackColor = System.Drawing.Color.Transparent;
            this.CBfilterby.BorderRadius = 15;
            this.CBfilterby.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBfilterby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBfilterby.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBfilterby.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBfilterby.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBfilterby.ForeColor = System.Drawing.Color.Black;
            this.CBfilterby.ItemHeight = 30;
            this.CBfilterby.Items.AddRange(new object[] {
            "Person ID",
            "National Number",
            "User ID"});
            this.CBfilterby.Location = new System.Drawing.Point(22, 56);
            this.CBfilterby.Name = "CBfilterby";
            this.CBfilterby.Size = new System.Drawing.Size(263, 36);
            this.CBfilterby.TabIndex = 0;
            // 
            // txtFilterByValue
            // 
            this.txtFilterByValue.BackColor = System.Drawing.Color.Transparent;
            this.txtFilterByValue.BorderRadius = 15;
            this.txtFilterByValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterByValue.DefaultText = "";
            this.txtFilterByValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilterByValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilterByValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterByValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterByValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterByValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFilterByValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterByValue.Location = new System.Drawing.Point(312, 55);
            this.txtFilterByValue.Name = "txtFilterByValue";
            this.txtFilterByValue.PlaceholderText = "";
            this.txtFilterByValue.SelectedText = "";
            this.txtFilterByValue.Size = new System.Drawing.Size(249, 36);
            this.txtFilterByValue.TabIndex = 1;
            // 
            // btnfinduser
            // 
            this.btnfinduser.BackColor = System.Drawing.Color.Transparent;
            this.btnfinduser.BorderRadius = 15;
            this.btnfinduser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnfinduser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnfinduser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnfinduser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnfinduser.FillColor = System.Drawing.Color.Gainsboro;
            this.btnfinduser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfinduser.ForeColor = System.Drawing.Color.Black;
            this.btnfinduser.Image = global::HMS.Properties.Resources.finduserr;
            this.btnfinduser.ImageSize = new System.Drawing.Size(35, 35);
            this.btnfinduser.Location = new System.Drawing.Point(701, 56);
            this.btnfinduser.Name = "btnfinduser";
            this.btnfinduser.Size = new System.Drawing.Size(68, 36);
            this.btnfinduser.TabIndex = 3;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddUser.BorderRadius = 15;
            this.btnAddUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddUser.FillColor = System.Drawing.Color.Gainsboro;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddUser.ForeColor = System.Drawing.Color.Black;
            this.btnAddUser.Image = global::HMS.Properties.Resources.AddPerson;
            this.btnAddUser.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAddUser.Location = new System.Drawing.Point(798, 56);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(68, 36);
            this.btnAddUser.TabIndex = 4;
            // 
            // ctrlUserInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.GBfilter);
            this.Controls.Add(this.ctrlUserInfo1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ctrlUserInfoWithFilter";
            this.Size = new System.Drawing.Size(1014, 685);
            this.GBfilter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlUserInfo ctrlUserInfo1;
        private Guna.UI2.WinForms.Guna2GroupBox GBfilter;
        private Guna.UI2.WinForms.Guna2ComboBox CBfilterby;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterByValue;
        private Guna.UI2.WinForms.Guna2Button btnAddUser;
        private Guna.UI2.WinForms.Guna2Button btnfinduser;
    }
}
