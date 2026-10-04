namespace HMS.Rooms
{
    partial class FrmManageRooms
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
            this.LBLnumberOfRooms = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CBstatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DGVlistRooms = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CMSrooms = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.txtFilterByValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.CBfilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewRoom = new Guna.UI2.WinForms.Guna2Button();
            this.TSMIaddNewRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIshowdetails = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIeditRoomInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVlistRooms)).BeginInit();
            this.CMSrooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLnumberOfRooms
            // 
            this.LBLnumberOfRooms.BackColor = System.Drawing.Color.Transparent;
            this.LBLnumberOfRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLnumberOfRooms.Location = new System.Drawing.Point(318, 717);
            this.LBLnumberOfRooms.Name = "LBLnumberOfRooms";
            this.LBLnumberOfRooms.Size = new System.Drawing.Size(14, 26);
            this.LBLnumberOfRooms.TabIndex = 32;
            this.LBLnumberOfRooms.Text = "0";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(123, 717);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(192, 25);
            this.guna2HtmlLabel3.TabIndex = 31;
            this.guna2HtmlLabel3.Text = "Number Of Rooms : ";
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
            "Available",
            "Reserved",
            "Occupied",
            "Cleaning",
            "Maintenance"});
            this.CBstatus.Location = new System.Drawing.Point(656, 328);
            this.CBstatus.Name = "CBstatus";
            this.CBstatus.Size = new System.Drawing.Size(255, 36);
            this.CBstatus.TabIndex = 30;
            this.CBstatus.SelectedIndexChanged += new System.EventHandler(this.CBstatus_SelectedIndexChanged);
            // 
            // DGVlistRooms
            // 
            this.DGVlistRooms.AllowUserToAddRows = false;
            this.DGVlistRooms.AllowUserToDeleteRows = false;
            this.DGVlistRooms.AllowUserToResizeColumns = false;
            this.DGVlistRooms.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVlistRooms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVlistRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVlistRooms.ColumnHeadersHeight = 20;
            this.DGVlistRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVlistRooms.ContextMenuStrip = this.CMSrooms;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVlistRooms.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVlistRooms.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVlistRooms.Location = new System.Drawing.Point(129, 388);
            this.DGVlistRooms.Name = "DGVlistRooms";
            this.DGVlistRooms.ReadOnly = true;
            this.DGVlistRooms.RowHeadersVisible = false;
            this.DGVlistRooms.Size = new System.Drawing.Size(1179, 295);
            this.DGVlistRooms.TabIndex = 27;
            this.DGVlistRooms.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVlistRooms.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVlistRooms.ThemeStyle.HeaderStyle.Height = 20;
            this.DGVlistRooms.ThemeStyle.ReadOnly = true;
            this.DGVlistRooms.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // CMSrooms
            // 
            this.CMSrooms.BackColor = System.Drawing.Color.LightGray;
            this.CMSrooms.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMSrooms.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.CMSrooms.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.CMSrooms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIaddNewRoom,
            this.TSMIshowdetails,
            this.TSMIeditRoomInfo});
            this.CMSrooms.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.CMSrooms.Name = "CMSusers";
            this.CMSrooms.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.CMSrooms.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CMSrooms.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.CMSrooms.RenderStyle.ColorTable = null;
            this.CMSrooms.RenderStyle.RoundedEdges = true;
            this.CMSrooms.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.CMSrooms.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CMSrooms.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.CMSrooms.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.CMSrooms.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.CMSrooms.Size = new System.Drawing.Size(257, 134);
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
            this.txtFilterByValue.Location = new System.Drawing.Point(656, 328);
            this.txtFilterByValue.Name = "txtFilterByValue";
            this.txtFilterByValue.PlaceholderText = "";
            this.txtFilterByValue.SelectedText = "";
            this.txtFilterByValue.Size = new System.Drawing.Size(332, 36);
            this.txtFilterByValue.TabIndex = 26;
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
            "RoomID",
            "Room Number",
            "Price Per Night",
            "Status"});
            this.CBfilterBy.Location = new System.Drawing.Point(261, 328);
            this.CBfilterBy.Name = "CBfilterBy";
            this.CBfilterBy.Size = new System.Drawing.Size(332, 36);
            this.CBfilterBy.TabIndex = 25;
            this.CBfilterBy.SelectedIndexChanged += new System.EventHandler(this.CBfilterBy_SelectedIndexChanged);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(129, 333);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(105, 27);
            this.guna2HtmlLabel2.TabIndex = 24;
            this.guna2HtmlLabel2.Text = "Filter  By :  ";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(560, 245);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(248, 41);
            this.guna2HtmlLabel1.TabIndex = 33;
            this.guna2HtmlLabel1.Text = "Manage Rooms";
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
            this.guna2Button1.Location = new System.Drawing.Point(1129, 717);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(179, 51);
            this.guna2Button1.TabIndex = 29;
            this.guna2Button1.Text = "Close";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
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
            this.btnAddNewRoom.Location = new System.Drawing.Point(1092, 321);
            this.btnAddNewRoom.Name = "btnAddNewRoom";
            this.btnAddNewRoom.Size = new System.Drawing.Size(216, 61);
            this.btnAddNewRoom.TabIndex = 28;
            this.btnAddNewRoom.Text = "Add Room";
            this.btnAddNewRoom.Click += new System.EventHandler(this.btnAddNewRoom_Click);
            // 
            // TSMIaddNewRoom
            // 
            this.TSMIaddNewRoom.Image = global::HMS.Properties.Resources.plus;
            this.TSMIaddNewRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TSMIaddNewRoom.Name = "TSMIaddNewRoom";
            this.TSMIaddNewRoom.Size = new System.Drawing.Size(256, 36);
            this.TSMIaddNewRoom.Text = "Add New Room";
            this.TSMIaddNewRoom.Click += new System.EventHandler(this.TSMIaddNewRoom_Click);
            // 
            // TSMIshowdetails
            // 
            this.TSMIshowdetails.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSMIshowdetails.Image = global::HMS.Properties.Resources.info1;
            this.TSMIshowdetails.Name = "TSMIshowdetails";
            this.TSMIshowdetails.Size = new System.Drawing.Size(256, 36);
            this.TSMIshowdetails.Text = "Show Details";
            this.TSMIshowdetails.Click += new System.EventHandler(this.TSMIshowdetails_Click);
            // 
            // TSMIeditRoomInfo
            // 
            this.TSMIeditRoomInfo.Image = global::HMS.Properties.Resources.pencil;
            this.TSMIeditRoomInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TSMIeditRoomInfo.Name = "TSMIeditRoomInfo";
            this.TSMIeditRoomInfo.Size = new System.Drawing.Size(256, 36);
            this.TSMIeditRoomInfo.Text = "Edit Info";
            this.TSMIeditRoomInfo.Click += new System.EventHandler(this.TSMIeditRoomInfo_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::HMS.Properties.Resources.bed_264;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(541, 12);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(283, 213);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 23;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // FrmManageRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1496, 824);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.LBLnumberOfRooms);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.CBstatus);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnAddNewRoom);
            this.Controls.Add(this.DGVlistRooms);
            this.Controls.Add(this.txtFilterByValue);
            this.Controls.Add(this.CBfilterBy);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmManageRooms";
            this.Text = "Manage Rooms";
            this.Load += new System.EventHandler(this.FrmManageRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVlistRooms)).EndInit();
            this.CMSrooms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel LBLnumberOfRooms;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox CBstatus;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnAddNewRoom;
        private Guna.UI2.WinForms.Guna2DataGridView DGVlistRooms;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip CMSrooms;
        private System.Windows.Forms.ToolStripMenuItem TSMIaddNewRoom;
        private System.Windows.Forms.ToolStripMenuItem TSMIshowdetails;
        private System.Windows.Forms.ToolStripMenuItem TSMIeditRoomInfo;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterByValue;
        private Guna.UI2.WinForms.Guna2ComboBox CBfilterBy;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}