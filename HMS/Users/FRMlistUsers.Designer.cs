namespace HMS.Users
{
    partial class FRMlistUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CBfilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFilterByValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.DGVListUsers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CMSusers = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.TSMIaddnewuser = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIshowdetails = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIeditinfo = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIdelete = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIchangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddNewUser = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.cbIsActive = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNOusers = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListUsers)).BeginInit();
            this.CMSusers.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::HMS.Properties.Resources.shortlist;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(523, 12);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(283, 213);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(523, 247);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(284, 46);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Manage Users";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(83, 385);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(105, 27);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "Filter  By :  ";
            // 
            // CBfilterBy
            // 
            this.CBfilterBy.BackColor = System.Drawing.Color.Transparent;
            this.CBfilterBy.BorderRadius = 16;
            this.CBfilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBfilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBfilterBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBfilterBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBfilterBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CBfilterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CBfilterBy.ItemHeight = 30;
            this.CBfilterBy.Items.AddRange(new object[] {
            "None",
            "User ID",
            "Person ID",
            "Full Name",
            "is Active"});
            this.CBfilterBy.Location = new System.Drawing.Point(215, 380);
            this.CBfilterBy.Name = "CBfilterBy";
            this.CBfilterBy.Size = new System.Drawing.Size(332, 36);
            this.CBfilterBy.TabIndex = 3;
            this.CBfilterBy.SelectedIndexChanged += new System.EventHandler(this.CBfilterBy_SelectedIndexChanged);
            // 
            // txtFilterByValue
            // 
            this.txtFilterByValue.BorderRadius = 16;
            this.txtFilterByValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterByValue.DefaultText = "";
            this.txtFilterByValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilterByValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilterByValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterByValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterByValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterByValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFilterByValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterByValue.Location = new System.Drawing.Point(610, 380);
            this.txtFilterByValue.Name = "txtFilterByValue";
            this.txtFilterByValue.PlaceholderText = "";
            this.txtFilterByValue.SelectedText = "";
            this.txtFilterByValue.Size = new System.Drawing.Size(332, 36);
            this.txtFilterByValue.TabIndex = 4;
            this.txtFilterByValue.TextChanged += new System.EventHandler(this.txtFilterByValue_TextChanged);
            this.txtFilterByValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterByValue_KeyPress);
            // 
            // DGVListUsers
            // 
            this.DGVListUsers.AllowUserToAddRows = false;
            this.DGVListUsers.AllowUserToDeleteRows = false;
            this.DGVListUsers.AllowUserToResizeColumns = false;
            this.DGVListUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVListUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVListUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVListUsers.ColumnHeadersHeight = 20;
            this.DGVListUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVListUsers.ContextMenuStrip = this.CMSusers;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVListUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVListUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVListUsers.Location = new System.Drawing.Point(83, 440);
            this.DGVListUsers.Name = "DGVListUsers";
            this.DGVListUsers.ReadOnly = true;
            this.DGVListUsers.RowHeadersVisible = false;
            this.DGVListUsers.Size = new System.Drawing.Size(1179, 295);
            this.DGVListUsers.TabIndex = 5;
            this.DGVListUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVListUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVListUsers.ThemeStyle.HeaderStyle.Height = 20;
            this.DGVListUsers.ThemeStyle.ReadOnly = true;
            this.DGVListUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVListUsers.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListUsers_CellContentDoubleClick_1);
            this.DGVListUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListUsers_CellDoubleClick);
            // 
            // CMSusers
            // 
            this.CMSusers.BackColor = System.Drawing.Color.LightGray;
            this.CMSusers.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMSusers.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.CMSusers.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.CMSusers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIaddnewuser,
            this.TSMIshowdetails,
            this.TSMIeditinfo,
            this.TSMIdelete,
            this.TSMIchangePassword});
            this.CMSusers.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.CMSusers.Name = "CMSusers";
            this.CMSusers.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.CMSusers.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CMSusers.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.CMSusers.RenderStyle.ColorTable = null;
            this.CMSusers.RenderStyle.RoundedEdges = true;
            this.CMSusers.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.CMSusers.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CMSusers.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.CMSusers.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.CMSusers.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.CMSusers.Size = new System.Drawing.Size(273, 184);
            // 
            // TSMIaddnewuser
            // 
            this.TSMIaddnewuser.Image = global::HMS.Properties.Resources.AddPerson;
            this.TSMIaddnewuser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TSMIaddnewuser.Name = "TSMIaddnewuser";
            this.TSMIaddnewuser.Size = new System.Drawing.Size(272, 36);
            this.TSMIaddnewuser.Text = "Add New User";
            this.TSMIaddnewuser.Click += new System.EventHandler(this.TSMIaddnewuser_Click);
            // 
            // TSMIshowdetails
            // 
            this.TSMIshowdetails.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSMIshowdetails.Image = global::HMS.Properties.Resources.PersonInfo;
            this.TSMIshowdetails.Name = "TSMIshowdetails";
            this.TSMIshowdetails.Size = new System.Drawing.Size(272, 36);
            this.TSMIshowdetails.Text = "Show Details";
            this.TSMIshowdetails.Click += new System.EventHandler(this.TSMIshowdetails_Click);
            // 
            // TSMIeditinfo
            // 
            this.TSMIeditinfo.Image = global::HMS.Properties.Resources.edit_Person;
            this.TSMIeditinfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TSMIeditinfo.Name = "TSMIeditinfo";
            this.TSMIeditinfo.Size = new System.Drawing.Size(272, 36);
            this.TSMIeditinfo.Text = "Edit Info";
            this.TSMIeditinfo.Click += new System.EventHandler(this.TSMIeditinfo_Click);
            // 
            // TSMIdelete
            // 
            this.TSMIdelete.Image = global::HMS.Properties.Resources.delete_Person;
            this.TSMIdelete.Name = "TSMIdelete";
            this.TSMIdelete.Size = new System.Drawing.Size(272, 36);
            this.TSMIdelete.Text = "Delete";
            this.TSMIdelete.Click += new System.EventHandler(this.TSMIdelete_Click);
            // 
            // TSMIchangePassword
            // 
            this.TSMIchangePassword.Image = global::HMS.Properties.Resources.password_protection;
            this.TSMIchangePassword.Name = "TSMIchangePassword";
            this.TSMIchangePassword.Size = new System.Drawing.Size(272, 36);
            this.TSMIchangePassword.Text = "Change Password";
            this.TSMIchangePassword.Click += new System.EventHandler(this.TSMIchangePassword_Click);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BorderRadius = 15;
            this.btnAddNewUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewUser.FillColor = System.Drawing.Color.Silver;
            this.btnAddNewUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddNewUser.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewUser.Image = global::HMS.Properties.Resources.AddPerson;
            this.btnAddNewUser.ImageSize = new System.Drawing.Size(45, 45);
            this.btnAddNewUser.Location = new System.Drawing.Point(1158, 371);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(104, 61);
            this.btnAddNewUser.TabIndex = 6;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Silver;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Image = global::HMS.Properties.Resources.cancel;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button1.Location = new System.Drawing.Point(1060, 782);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(179, 51);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Text = "Close";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // cbIsActive
            // 
            this.cbIsActive.BackColor = System.Drawing.Color.Transparent;
            this.cbIsActive.BorderRadius = 16;
            this.cbIsActive.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsActive.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbIsActive.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbIsActive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cbIsActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbIsActive.ItemHeight = 30;
            this.cbIsActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsActive.Location = new System.Drawing.Point(610, 380);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(255, 36);
            this.cbIsActive.TabIndex = 9;
            this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(83, 782);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(179, 25);
            this.guna2HtmlLabel3.TabIndex = 10;
            this.guna2HtmlLabel3.Text = "Number Of Users : ";
            // 
            // lblNOusers
            // 
            this.lblNOusers.BackColor = System.Drawing.Color.Transparent;
            this.lblNOusers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNOusers.Location = new System.Drawing.Point(278, 782);
            this.lblNOusers.Name = "lblNOusers";
            this.lblNOusers.Size = new System.Drawing.Size(14, 26);
            this.lblNOusers.TabIndex = 11;
            this.lblNOusers.Text = "0";
            // 
            // FRMlistUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1345, 865);
            this.Controls.Add(this.lblNOusers);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.cbIsActive);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.DGVListUsers);
            this.Controls.Add(this.txtFilterByValue);
            this.Controls.Add(this.CBfilterBy);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FRMlistUsers";
            this.Text = "FRMlistUsers";
            this.Load += new System.EventHandler(this.FRMlistUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListUsers)).EndInit();
            this.CMSusers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox CBfilterBy;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterByValue;
        private Guna.UI2.WinForms.Guna2DataGridView DGVListUsers;
        private Guna.UI2.WinForms.Guna2Button btnAddNewUser;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip CMSusers;
        private System.Windows.Forms.ToolStripMenuItem TSMIaddnewuser;
        private System.Windows.Forms.ToolStripMenuItem TSMIshowdetails;
        private System.Windows.Forms.ToolStripMenuItem TSMIeditinfo;
        private System.Windows.Forms.ToolStripMenuItem TSMIdelete;
        private System.Windows.Forms.ToolStripMenuItem TSMIchangePassword;
        private Guna.UI2.WinForms.Guna2ComboBox cbIsActive;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNOusers;
    }
}