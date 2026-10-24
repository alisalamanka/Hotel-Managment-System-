namespace HMS.Reservations
{
    partial class FrmReservationsList
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
            this.lblNumberOfReservations = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CBreservationStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DGVReservations = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CMSreservations = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.TSMIaddReservation = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIshowReservationInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIeditinfo = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFilterByValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.CBfilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewReservation = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btNext = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrevieus = new Guna.UI2.WinForms.Guna2Button();
            this.lblCurrentPage = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReservations)).BeginInit();
            this.CMSreservations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumberOfReservations
            // 
            this.lblNumberOfReservations.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfReservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfReservations.Location = new System.Drawing.Point(290, 834);
            this.lblNumberOfReservations.Name = "lblNumberOfReservations";
            this.lblNumberOfReservations.Size = new System.Drawing.Size(14, 26);
            this.lblNumberOfReservations.TabIndex = 33;
            this.lblNumberOfReservations.Text = "0";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(40, 835);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(244, 25);
            this.guna2HtmlLabel3.TabIndex = 32;
            this.guna2HtmlLabel3.Text = "Number Of Reservations:";
            // 
            // CBreservationStatus
            // 
            this.CBreservationStatus.BackColor = System.Drawing.Color.Transparent;
            this.CBreservationStatus.BorderRadius = 16;
            this.CBreservationStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBreservationStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBreservationStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBreservationStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBreservationStatus.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.CBreservationStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CBreservationStatus.ItemHeight = 30;
            this.CBreservationStatus.Items.AddRange(new object[] {
            "All",
            "Pending",
            "Confirmed",
            "Cancelled",
            "CheckedIn",
            "CheckedOut",
            "NoShow"});
            this.CBreservationStatus.Location = new System.Drawing.Point(567, 382);
            this.CBreservationStatus.Name = "CBreservationStatus";
            this.CBreservationStatus.Size = new System.Drawing.Size(255, 36);
            this.CBreservationStatus.TabIndex = 31;
            this.CBreservationStatus.SelectedIndexChanged += new System.EventHandler(this.CBreservationStatus_SelectedIndexChanged);
            // 
            // DGVReservations
            // 
            this.DGVReservations.AllowUserToAddRows = false;
            this.DGVReservations.AllowUserToDeleteRows = false;
            this.DGVReservations.AllowUserToResizeColumns = false;
            this.DGVReservations.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DGVReservations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVReservations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVReservations.ColumnHeadersHeight = 20;
            this.DGVReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVReservations.ContextMenuStrip = this.CMSreservations;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVReservations.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVReservations.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVReservations.Location = new System.Drawing.Point(40, 442);
            this.DGVReservations.Name = "DGVReservations";
            this.DGVReservations.ReadOnly = true;
            this.DGVReservations.RowHeadersVisible = false;
            this.DGVReservations.Size = new System.Drawing.Size(1441, 295);
            this.DGVReservations.TabIndex = 28;
            this.DGVReservations.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVReservations.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVReservations.ThemeStyle.HeaderStyle.Height = 20;
            this.DGVReservations.ThemeStyle.ReadOnly = true;
            this.DGVReservations.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // CMSreservations
            // 
            this.CMSreservations.BackColor = System.Drawing.Color.Silver;
            this.CMSreservations.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMSreservations.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.CMSreservations.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.CMSreservations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIaddReservation,
            this.TSMIshowReservationInfo,
            this.TSMIeditinfo,
            this.TSMCancel});
            this.CMSreservations.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.CMSreservations.Name = "CMSusers";
            this.CMSreservations.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.CMSreservations.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CMSreservations.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.CMSreservations.RenderStyle.ColorTable = null;
            this.CMSreservations.RenderStyle.RoundedEdges = true;
            this.CMSreservations.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.CMSreservations.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CMSreservations.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.CMSreservations.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.CMSreservations.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.CMSreservations.Size = new System.Drawing.Size(324, 148);
            // 
            // TSMIaddReservation
            // 
            this.TSMIaddReservation.Image = global::HMS.Properties.Resources.Reservationss;
            this.TSMIaddReservation.Name = "TSMIaddReservation";
            this.TSMIaddReservation.Size = new System.Drawing.Size(323, 36);
            this.TSMIaddReservation.Text = "Add New Reservation";
            this.TSMIaddReservation.Click += new System.EventHandler(this.TSMIaddReservation_Click);
            // 
            // TSMIshowReservationInfo
            // 
            this.TSMIshowReservationInfo.Image = global::HMS.Properties.Resources.info;
            this.TSMIshowReservationInfo.Name = "TSMIshowReservationInfo";
            this.TSMIshowReservationInfo.Size = new System.Drawing.Size(323, 36);
            this.TSMIshowReservationInfo.Text = "Show Reservation Info";
            this.TSMIshowReservationInfo.Click += new System.EventHandler(this.TSMIshowReservationInfo_Click);
            // 
            // TSMIeditinfo
            // 
            this.TSMIeditinfo.Image = global::HMS.Properties.Resources.pencil;
            this.TSMIeditinfo.Name = "TSMIeditinfo";
            this.TSMIeditinfo.Size = new System.Drawing.Size(323, 36);
            this.TSMIeditinfo.Text = "Edit Reservation Info";
            this.TSMIeditinfo.Click += new System.EventHandler(this.TSMIeditinfo_Click);
            // 
            // TSMCancel
            // 
            this.TSMCancel.Image = global::HMS.Properties.Resources.cancel;
            this.TSMCancel.Name = "TSMCancel";
            this.TSMCancel.Size = new System.Drawing.Size(323, 36);
            this.TSMCancel.Text = "Cancel Reservation";
            this.TSMCancel.Click += new System.EventHandler(this.TSMCancel_Click);
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
            this.txtFilterByValue.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterByValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterByValue.Location = new System.Drawing.Point(567, 382);
            this.txtFilterByValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilterByValue.Name = "txtFilterByValue";
            this.txtFilterByValue.PlaceholderText = "";
            this.txtFilterByValue.SelectedText = "";
            this.txtFilterByValue.Size = new System.Drawing.Size(332, 36);
            this.txtFilterByValue.TabIndex = 27;
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
            this.CBfilterBy.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.CBfilterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CBfilterBy.ItemHeight = 30;
            this.CBfilterBy.Items.AddRange(new object[] {
            "None",
            "Reservation ID",
            "Room ID",
            "Guest ID",
            "Status"});
            this.CBfilterBy.Location = new System.Drawing.Point(172, 382);
            this.CBfilterBy.Name = "CBfilterBy";
            this.CBfilterBy.Size = new System.Drawing.Size(332, 36);
            this.CBfilterBy.TabIndex = 26;
            this.CBfilterBy.SelectedIndexChanged += new System.EventHandler(this.CBfilterBy_SelectedIndexChanged);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(40, 387);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(105, 27);
            this.guna2HtmlLabel2.TabIndex = 25;
            this.guna2HtmlLabel2.Text = "Filter  By :  ";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(510, 256);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(387, 44);
            this.guna2HtmlLabel1.TabIndex = 24;
            this.guna2HtmlLabel1.Text = "Manage Reservations";
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 15;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Silver;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Image = global::HMS.Properties.Resources.cancel;
            this.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClose.ImageSize = new System.Drawing.Size(40, 40);
            this.btnClose.Location = new System.Drawing.Point(1302, 835);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(179, 51);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddNewReservation
            // 
            this.btnAddNewReservation.BorderRadius = 15;
            this.btnAddNewReservation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewReservation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewReservation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewReservation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewReservation.FillColor = System.Drawing.Color.Silver;
            this.btnAddNewReservation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddNewReservation.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewReservation.Image = global::HMS.Properties.Resources.Reservationss;
            this.btnAddNewReservation.ImageSize = new System.Drawing.Size(45, 45);
            this.btnAddNewReservation.Location = new System.Drawing.Point(1377, 375);
            this.btnAddNewReservation.Name = "btnAddNewReservation";
            this.btnAddNewReservation.Size = new System.Drawing.Size(104, 61);
            this.btnAddNewReservation.TabIndex = 29;
            this.btnAddNewReservation.Click += new System.EventHandler(this.btnAddNewReservation_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::HMS.Properties.Resources.Reservationss;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(594, 15);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(283, 213);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 23;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // btNext
            // 
            this.btNext.BorderRadius = 15;
            this.btNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btNext.FillColor = System.Drawing.Color.Silver;
            this.btNext.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNext.ForeColor = System.Drawing.Color.Black;
            this.btNext.Image = global::HMS.Properties.Resources.right_arrow;
            this.btNext.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btNext.ImageSize = new System.Drawing.Size(40, 40);
            this.btNext.Location = new System.Drawing.Point(1018, 763);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(179, 51);
            this.btNext.TabIndex = 35;
            this.btNext.Text = "Next";
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btnPrevieus
            // 
            this.btnPrevieus.BorderRadius = 15;
            this.btnPrevieus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrevieus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrevieus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrevieus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrevieus.FillColor = System.Drawing.Color.Silver;
            this.btnPrevieus.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevieus.ForeColor = System.Drawing.Color.Black;
            this.btnPrevieus.Image = global::HMS.Properties.Resources.left_arrow;
            this.btnPrevieus.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPrevieus.ImageSize = new System.Drawing.Size(40, 40);
            this.btnPrevieus.Location = new System.Drawing.Point(399, 763);
            this.btnPrevieus.Name = "btnPrevieus";
            this.btnPrevieus.Size = new System.Drawing.Size(179, 51);
            this.btnPrevieus.TabIndex = 36;
            this.btnPrevieus.Text = "Prev";
            this.btnPrevieus.Click += new System.EventHandler(this.btnPrevieus_Click);
            // 
            // lblCurrentPage
            // 
            this.lblCurrentPage.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentPage.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPage.Location = new System.Drawing.Point(796, 777);
            this.lblCurrentPage.Name = "lblCurrentPage";
            this.lblCurrentPage.Size = new System.Drawing.Size(15, 25);
            this.lblCurrentPage.TabIndex = 37;
            this.lblCurrentPage.Text = "0";
            // 
            // FrmReservationsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 898);
            this.Controls.Add(this.lblCurrentPage);
            this.Controls.Add(this.btnPrevieus);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.lblNumberOfReservations);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.CBreservationStatus);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddNewReservation);
            this.Controls.Add(this.DGVReservations);
            this.Controls.Add(this.txtFilterByValue);
            this.Controls.Add(this.CBfilterBy);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmReservationsList";
            this.Text = "FrmReservationsList";
            this.Load += new System.EventHandler(this.FrmReservationsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVReservations)).EndInit();
            this.CMSreservations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblNumberOfReservations;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox CBreservationStatus;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnAddNewReservation;
        private Guna.UI2.WinForms.Guna2DataGridView DGVReservations;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip CMSreservations;
        private System.Windows.Forms.ToolStripMenuItem TSMIaddReservation;
        private System.Windows.Forms.ToolStripMenuItem TSMIshowReservationInfo;
        private System.Windows.Forms.ToolStripMenuItem TSMIeditinfo;
        private System.Windows.Forms.ToolStripMenuItem TSMCancel;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterByValue;
        private Guna.UI2.WinForms.Guna2ComboBox CBfilterBy;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button btNext;
        private Guna.UI2.WinForms.Guna2Button btnPrevieus;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCurrentPage;
    }
}