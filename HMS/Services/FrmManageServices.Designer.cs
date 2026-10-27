namespace HMS.Services
{
    partial class FrmManageServices
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LBLnumberOfservices = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CBstatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DGVListServices = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CMSservices = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.TSMIaddNewService = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIshowdetails = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIeditRoomInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFilterByValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.CBfilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewRoom = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListServices)).BeginInit();
            this.CMSservices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(553, 253);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(272, 41);
            this.guna2HtmlLabel1.TabIndex = 44;
            this.guna2HtmlLabel1.Text = "Manage Services";
            // 
            // LBLnumberOfservices
            // 
            this.LBLnumberOfservices.BackColor = System.Drawing.Color.Transparent;
            this.LBLnumberOfservices.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLnumberOfservices.Location = new System.Drawing.Point(311, 725);
            this.LBLnumberOfservices.Name = "LBLnumberOfservices";
            this.LBLnumberOfservices.Size = new System.Drawing.Size(14, 26);
            this.LBLnumberOfservices.TabIndex = 43;
            this.LBLnumberOfservices.Text = "0";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(116, 725);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(205, 25);
            this.guna2HtmlLabel3.TabIndex = 42;
            this.guna2HtmlLabel3.Text = "Number Of Services : ";
            // 
            // CBstatus
            // 
            this.CBstatus.BackColor = System.Drawing.Color.Transparent;
            this.CBstatus.BorderRadius = 16;
            this.CBstatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBstatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBstatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBstatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CBstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CBstatus.ItemHeight = 30;
            this.CBstatus.Items.AddRange(new object[] {
            "All",
            "Active",
            "InActive"});
            this.CBstatus.Location = new System.Drawing.Point(649, 336);
            this.CBstatus.Name = "CBstatus";
            this.CBstatus.Size = new System.Drawing.Size(255, 36);
            this.CBstatus.TabIndex = 41;
            this.CBstatus.SelectedIndexChanged += new System.EventHandler(this.CBstatus_SelectedIndexChanged);
            // 
            // DGVListServices
            // 
            this.DGVListServices.AllowUserToAddRows = false;
            this.DGVListServices.AllowUserToDeleteRows = false;
            this.DGVListServices.AllowUserToResizeColumns = false;
            this.DGVListServices.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DGVListServices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVListServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVListServices.ColumnHeadersHeight = 20;
            this.DGVListServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVListServices.ContextMenuStrip = this.CMSservices;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVListServices.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVListServices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVListServices.Location = new System.Drawing.Point(122, 396);
            this.DGVListServices.Name = "DGVListServices";
            this.DGVListServices.ReadOnly = true;
            this.DGVListServices.RowHeadersVisible = false;
            this.DGVListServices.Size = new System.Drawing.Size(1179, 295);
            this.DGVListServices.TabIndex = 38;
            this.DGVListServices.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVListServices.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVListServices.ThemeStyle.HeaderStyle.Height = 20;
            this.DGVListServices.ThemeStyle.ReadOnly = true;
            this.DGVListServices.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // CMSservices
            // 
            this.CMSservices.BackColor = System.Drawing.Color.LightGray;
            this.CMSservices.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMSservices.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.CMSservices.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.CMSservices.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIaddNewService,
            this.TSMIshowdetails,
            this.TSMIeditRoomInfo});
            this.CMSservices.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.CMSservices.Name = "CMSusers";
            this.CMSservices.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.CMSservices.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CMSservices.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.CMSservices.RenderStyle.ColorTable = null;
            this.CMSservices.RenderStyle.RoundedEdges = true;
            this.CMSservices.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.CMSservices.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CMSservices.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.CMSservices.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.CMSservices.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.CMSservices.Size = new System.Drawing.Size(269, 112);
            // 
            // TSMIaddNewService
            // 
            this.TSMIaddNewService.Image = global::HMS.Properties.Resources.plus;
            this.TSMIaddNewService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TSMIaddNewService.Name = "TSMIaddNewService";
            this.TSMIaddNewService.Size = new System.Drawing.Size(268, 36);
            this.TSMIaddNewService.Text = "Add New Service";
            this.TSMIaddNewService.Click += new System.EventHandler(this.TSMIaddNewService_Click);
            // 
            // TSMIshowdetails
            // 
            this.TSMIshowdetails.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSMIshowdetails.Image = global::HMS.Properties.Resources.info1;
            this.TSMIshowdetails.Name = "TSMIshowdetails";
            this.TSMIshowdetails.Size = new System.Drawing.Size(268, 36);
            this.TSMIshowdetails.Text = "Show Details";
            this.TSMIshowdetails.Click += new System.EventHandler(this.TSMIshowdetails_Click_1);
            // 
            // TSMIeditRoomInfo
            // 
            this.TSMIeditRoomInfo.Image = global::HMS.Properties.Resources.pencil;
            this.TSMIeditRoomInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TSMIeditRoomInfo.Name = "TSMIeditRoomInfo";
            this.TSMIeditRoomInfo.Size = new System.Drawing.Size(268, 36);
            this.TSMIeditRoomInfo.Text = "Edit Info";
            this.TSMIeditRoomInfo.Click += new System.EventHandler(this.TSMIeditRoomInfo_Click);
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
            this.txtFilterByValue.Location = new System.Drawing.Point(649, 336);
            this.txtFilterByValue.Name = "txtFilterByValue";
            this.txtFilterByValue.PlaceholderText = "";
            this.txtFilterByValue.SelectedText = "";
            this.txtFilterByValue.Size = new System.Drawing.Size(332, 36);
            this.txtFilterByValue.TabIndex = 37;
            this.txtFilterByValue.TextChanged += new System.EventHandler(this.txtFilterByValue_TextChanged);
            // 
            // CBfilterBy
            // 
            this.CBfilterBy.BackColor = System.Drawing.Color.Transparent;
            this.CBfilterBy.BorderRadius = 16;
            this.CBfilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBfilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBfilterBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBfilterBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBfilterBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBfilterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CBfilterBy.ItemHeight = 30;
            this.CBfilterBy.Items.AddRange(new object[] {
            "None",
            "Service ID",
            "Service Name",
            "Status"});
            this.CBfilterBy.Location = new System.Drawing.Point(254, 336);
            this.CBfilterBy.Name = "CBfilterBy";
            this.CBfilterBy.Size = new System.Drawing.Size(332, 36);
            this.CBfilterBy.TabIndex = 36;
            this.CBfilterBy.SelectedIndexChanged += new System.EventHandler(this.CBfilterBy_SelectedIndexChanged);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(122, 341);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(105, 27);
            this.guna2HtmlLabel2.TabIndex = 35;
            this.guna2HtmlLabel2.Text = "Filter  By :  ";
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
            this.guna2Button1.Location = new System.Drawing.Point(1122, 725);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(179, 51);
            this.guna2Button1.TabIndex = 40;
            this.guna2Button1.Text = "Close";
            // 
            // btnAddNewRoom
            // 
            this.btnAddNewRoom.BorderRadius = 15;
            this.btnAddNewRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewRoom.FillColor = System.Drawing.Color.Silver;
            this.btnAddNewRoom.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewRoom.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewRoom.Image = global::HMS.Properties.Resources.plus;
            this.btnAddNewRoom.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddNewRoom.ImageSize = new System.Drawing.Size(45, 45);
            this.btnAddNewRoom.Location = new System.Drawing.Point(1049, 311);
            this.btnAddNewRoom.Name = "btnAddNewRoom";
            this.btnAddNewRoom.Size = new System.Drawing.Size(243, 61);
            this.btnAddNewRoom.TabIndex = 39;
            this.btnAddNewRoom.Text = "Add Service";
            this.btnAddNewRoom.Click += new System.EventHandler(this.btnAddNewRoom_Click_1);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::HMS.Properties.Resources.Service264;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(534, 20);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(283, 213);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 34;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // FrmManageServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 797);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.LBLnumberOfservices);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.CBstatus);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnAddNewRoom);
            this.Controls.Add(this.DGVListServices);
            this.Controls.Add(this.txtFilterByValue);
            this.Controls.Add(this.CBfilterBy);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmManageServices";
            this.Text = "FrmManageServices";
            this.Load += new System.EventHandler(this.FrmManageServices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVListServices)).EndInit();
            this.CMSservices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel LBLnumberOfservices;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox CBstatus;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnAddNewRoom;
        private Guna.UI2.WinForms.Guna2DataGridView DGVListServices;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip CMSservices;
        private System.Windows.Forms.ToolStripMenuItem TSMIaddNewService;
        private System.Windows.Forms.ToolStripMenuItem TSMIshowdetails;
        private System.Windows.Forms.ToolStripMenuItem TSMIeditRoomInfo;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterByValue;
        private Guna.UI2.WinForms.Guna2ComboBox CBfilterBy;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}