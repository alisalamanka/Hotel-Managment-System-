namespace HMS.Order
{
    partial class FrmManageOrders
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
            this.lblCurrentPage = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnPrevieus = new Guna.UI2.WinForms.Guna2Button();
            this.btNext = new Guna.UI2.WinForms.Guna2Button();
            this.lblNumberOfOrders = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CBorderStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewReservation = new Guna.UI2.WinForms.Guna2Button();
            this.DGVorders = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CMSorders = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.TSMIaddOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMISHoworderInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIeditinfo = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFilterByValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.CBfilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DGVorders)).BeginInit();
            this.CMSorders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurrentPage
            // 
            this.lblCurrentPage.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentPage.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPage.Location = new System.Drawing.Point(739, 732);
            this.lblCurrentPage.Name = "lblCurrentPage";
            this.lblCurrentPage.Size = new System.Drawing.Size(15, 25);
            this.lblCurrentPage.TabIndex = 50;
            this.lblCurrentPage.Text = "0";
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
            this.btnPrevieus.Location = new System.Drawing.Point(342, 718);
            this.btnPrevieus.Name = "btnPrevieus";
            this.btnPrevieus.Size = new System.Drawing.Size(179, 51);
            this.btnPrevieus.TabIndex = 49;
            this.btnPrevieus.Text = "Prev";
            this.btnPrevieus.Click += new System.EventHandler(this.btnPrevieus_Click);
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
            this.btNext.Location = new System.Drawing.Point(961, 718);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(179, 51);
            this.btNext.TabIndex = 48;
            this.btNext.Text = "Next";
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // lblNumberOfOrders
            // 
            this.lblNumberOfOrders.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfOrders.Location = new System.Drawing.Point(193, 790);
            this.lblNumberOfOrders.Name = "lblNumberOfOrders";
            this.lblNumberOfOrders.Size = new System.Drawing.Size(14, 26);
            this.lblNumberOfOrders.TabIndex = 47;
            this.lblNumberOfOrders.Text = "0";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(-17, 790);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(184, 25);
            this.guna2HtmlLabel3.TabIndex = 46;
            this.guna2HtmlLabel3.Text = "Number Of Orders:";
            // 
            // CBorderStatus
            // 
            this.CBorderStatus.BackColor = System.Drawing.Color.Transparent;
            this.CBorderStatus.BorderRadius = 16;
            this.CBorderStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBorderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBorderStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBorderStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBorderStatus.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.CBorderStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CBorderStatus.ItemHeight = 30;
            this.CBorderStatus.Items.AddRange(new object[] {
            "All",
            "Pending",
            "Completed",
            "Canceled"});
            this.CBorderStatus.Location = new System.Drawing.Point(572, 343);
            this.CBorderStatus.Name = "CBorderStatus";
            this.CBorderStatus.Size = new System.Drawing.Size(255, 36);
            this.CBorderStatus.TabIndex = 45;
            this.CBorderStatus.SelectedIndexChanged += new System.EventHandler(this.CBorderStatus_SelectedIndexChanged);
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
            this.btnClose.Location = new System.Drawing.Point(1245, 790);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(179, 51);
            this.btnClose.TabIndex = 44;
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
            this.btnAddNewReservation.Image = global::HMS.Properties.Resources.responsible;
            this.btnAddNewReservation.ImageSize = new System.Drawing.Size(45, 45);
            this.btnAddNewReservation.Location = new System.Drawing.Point(1320, 330);
            this.btnAddNewReservation.Name = "btnAddNewReservation";
            this.btnAddNewReservation.Size = new System.Drawing.Size(104, 61);
            this.btnAddNewReservation.TabIndex = 43;
            this.btnAddNewReservation.Click += new System.EventHandler(this.btnAddNewReservation_Click);
            // 
            // DGVorders
            // 
            this.DGVorders.AllowUserToAddRows = false;
            this.DGVorders.AllowUserToDeleteRows = false;
            this.DGVorders.AllowUserToResizeColumns = false;
            this.DGVorders.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVorders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVorders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVorders.ColumnHeadersHeight = 20;
            this.DGVorders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVorders.ContextMenuStrip = this.CMSorders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVorders.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVorders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVorders.Location = new System.Drawing.Point(43, 397);
            this.DGVorders.Name = "DGVorders";
            this.DGVorders.ReadOnly = true;
            this.DGVorders.RowHeadersVisible = false;
            this.DGVorders.Size = new System.Drawing.Size(1381, 295);
            this.DGVorders.TabIndex = 42;
            this.DGVorders.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVorders.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVorders.ThemeStyle.HeaderStyle.Height = 20;
            this.DGVorders.ThemeStyle.ReadOnly = true;
            this.DGVorders.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // CMSorders
            // 
            this.CMSorders.BackColor = System.Drawing.Color.Silver;
            this.CMSorders.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMSorders.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.CMSorders.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.CMSorders.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIaddOrder,
            this.TSMISHoworderInfo,
            this.TSMIeditinfo,
            this.TSMCancel});
            this.CMSorders.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.CMSorders.Name = "CMSusers";
            this.CMSorders.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.CMSorders.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CMSorders.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.CMSorders.RenderStyle.ColorTable = null;
            this.CMSorders.RenderStyle.RoundedEdges = true;
            this.CMSorders.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.CMSorders.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CMSorders.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.CMSorders.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.CMSorders.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.CMSorders.Size = new System.Drawing.Size(265, 148);
            // 
            // TSMIaddOrder
            // 
            this.TSMIaddOrder.Image = global::HMS.Properties.Resources.responsible;
            this.TSMIaddOrder.Name = "TSMIaddOrder";
            this.TSMIaddOrder.Size = new System.Drawing.Size(264, 36);
            this.TSMIaddOrder.Text = "Add New Order";
            // 
            // TSMISHoworderInfo
            // 
            this.TSMISHoworderInfo.Image = global::HMS.Properties.Resources.info;
            this.TSMISHoworderInfo.Name = "TSMISHoworderInfo";
            this.TSMISHoworderInfo.Size = new System.Drawing.Size(264, 36);
            this.TSMISHoworderInfo.Text = "Show Order Info";
            this.TSMISHoworderInfo.Click += new System.EventHandler(this.TSMISHoworderInfo_Click);
            // 
            // TSMIeditinfo
            // 
            this.TSMIeditinfo.Image = global::HMS.Properties.Resources.pencil;
            this.TSMIeditinfo.Name = "TSMIeditinfo";
            this.TSMIeditinfo.Size = new System.Drawing.Size(264, 36);
            this.TSMIeditinfo.Text = "Edit Order Info";
            this.TSMIeditinfo.Click += new System.EventHandler(this.TSMIeditinfo_Click);
            // 
            // TSMCancel
            // 
            this.TSMCancel.Image = global::HMS.Properties.Resources.cancel;
            this.TSMCancel.Name = "TSMCancel";
            this.TSMCancel.Size = new System.Drawing.Size(264, 36);
            this.TSMCancel.Text = "Cancel Order";
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
            this.txtFilterByValue.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.txtFilterByValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterByValue.Location = new System.Drawing.Point(572, 343);
            this.txtFilterByValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilterByValue.Name = "txtFilterByValue";
            this.txtFilterByValue.PlaceholderText = "";
            this.txtFilterByValue.SelectedText = "";
            this.txtFilterByValue.Size = new System.Drawing.Size(332, 36);
            this.txtFilterByValue.TabIndex = 41;
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
            "OrderID",
            "User ID",
            "Order Type",
            "Status"});
            this.CBfilterBy.Location = new System.Drawing.Point(177, 343);
            this.CBfilterBy.Name = "CBfilterBy";
            this.CBfilterBy.Size = new System.Drawing.Size(332, 36);
            this.CBfilterBy.TabIndex = 40;
            this.CBfilterBy.SelectedIndexChanged += new System.EventHandler(this.CBfilterBy_SelectedIndexChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(537, 212);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(276, 44);
            this.guna2HtmlLabel1.TabIndex = 39;
            this.guna2HtmlLabel1.Text = "Manage Orders";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::HMS.Properties.Resources.Reservationss;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(537, -30);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(283, 213);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 38;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(43, 353);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(85, 26);
            this.guna2HtmlLabel2.TabIndex = 51;
            this.guna2HtmlLabel2.Text = "Filter By:";
            // 
            // FrmManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1495, 855);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.lblCurrentPage);
            this.Controls.Add(this.btnPrevieus);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.lblNumberOfOrders);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.CBorderStatus);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddNewReservation);
            this.Controls.Add(this.DGVorders);
            this.Controls.Add(this.txtFilterByValue);
            this.Controls.Add(this.CBfilterBy);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Name = "FrmManageOrders";
            this.Text = "FrmManageOrders";
            this.Load += new System.EventHandler(this.FrmManageOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVorders)).EndInit();
            this.CMSorders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblCurrentPage;
        private Guna.UI2.WinForms.Guna2Button btnPrevieus;
        private Guna.UI2.WinForms.Guna2Button btNext;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNumberOfOrders;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox CBorderStatus;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnAddNewReservation;
        private Guna.UI2.WinForms.Guna2DataGridView DGVorders;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip CMSorders;
        private System.Windows.Forms.ToolStripMenuItem TSMIaddOrder;
        private System.Windows.Forms.ToolStripMenuItem TSMISHoworderInfo;
        private System.Windows.Forms.ToolStripMenuItem TSMIeditinfo;
        private System.Windows.Forms.ToolStripMenuItem TSMCancel;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterByValue;
        private Guna.UI2.WinForms.Guna2ComboBox CBfilterBy;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}