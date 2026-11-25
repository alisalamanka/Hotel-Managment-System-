namespace HMS.Stays
{
    partial class FrmManageStays
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
            this.lblNumberOfStays = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CBStayStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DGVStays = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CMSstays = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.TSMIaddStay = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIshowStayInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIeditinfo = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFilterByValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.CBfilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStays)).BeginInit();
            this.CMSstays.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumberOfStays
            // 
            this.lblNumberOfStays.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfStays.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfStays.Location = new System.Drawing.Point(204, 690);
            this.lblNumberOfStays.Name = "lblNumberOfStays";
            this.lblNumberOfStays.Size = new System.Drawing.Size(14, 26);
            this.lblNumberOfStays.TabIndex = 46;
            this.lblNumberOfStays.Text = "0";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(17, 690);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(172, 25);
            this.guna2HtmlLabel3.TabIndex = 45;
            this.guna2HtmlLabel3.Text = "Number Of Stays:";
            // 
            // CBStayStatus
            // 
            this.CBStayStatus.BackColor = System.Drawing.Color.Transparent;
            this.CBStayStatus.BorderRadius = 16;
            this.CBStayStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBStayStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBStayStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBStayStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBStayStatus.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.CBStayStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CBStayStatus.ItemHeight = 30;
            this.CBStayStatus.Items.AddRange(new object[] {
            "All",
            "Pending",
            "Confirmed",
            "Cancelled",
            "CheckedIn",
            "CheckedOut",
            "NoShow"});
            this.CBStayStatus.Location = new System.Drawing.Point(407, 291);
            this.CBStayStatus.Name = "CBStayStatus";
            this.CBStayStatus.Size = new System.Drawing.Size(255, 36);
            this.CBStayStatus.TabIndex = 44;
            // 
            // DGVStays
            // 
            this.DGVStays.AllowUserToAddRows = false;
            this.DGVStays.AllowUserToDeleteRows = false;
            this.DGVStays.AllowUserToResizeColumns = false;
            this.DGVStays.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVStays.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVStays.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVStays.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVStays.ColumnHeadersHeight = 20;
            this.DGVStays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVStays.ContextMenuStrip = this.CMSstays;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVStays.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVStays.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVStays.Location = new System.Drawing.Point(18, 356);
            this.DGVStays.Name = "DGVStays";
            this.DGVStays.ReadOnly = true;
            this.DGVStays.RowHeadersVisible = false;
            this.DGVStays.Size = new System.Drawing.Size(1317, 295);
            this.DGVStays.TabIndex = 43;
            this.DGVStays.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVStays.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.DGVStays.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVStays.ThemeStyle.HeaderStyle.Height = 20;
            this.DGVStays.ThemeStyle.ReadOnly = true;
            this.DGVStays.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // CMSstays
            // 
            this.CMSstays.BackColor = System.Drawing.Color.Silver;
            this.CMSstays.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMSstays.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.CMSstays.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.CMSstays.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIaddStay,
            this.TSMIshowStayInfo,
            this.TSMIeditinfo,
            this.TSMCancel});
            this.CMSstays.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.CMSstays.Name = "CMSusers";
            this.CMSstays.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.CMSstays.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CMSstays.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.CMSstays.RenderStyle.ColorTable = null;
            this.CMSstays.RenderStyle.RoundedEdges = true;
            this.CMSstays.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.CMSstays.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CMSstays.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.CMSstays.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.CMSstays.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.CMSstays.Size = new System.Drawing.Size(314, 148);
            // 
            // TSMIaddStay
            // 
            this.TSMIaddStay.Image = global::HMS.Properties.Resources.retention;
            this.TSMIaddStay.Name = "TSMIaddStay";
            this.TSMIaddStay.Size = new System.Drawing.Size(313, 36);
            this.TSMIaddStay.Text = "Add New Reservation";
            // 
            // TSMIshowStayInfo
            // 
            this.TSMIshowStayInfo.Image = global::HMS.Properties.Resources.info;
            this.TSMIshowStayInfo.Name = "TSMIshowStayInfo";
            this.TSMIshowStayInfo.Size = new System.Drawing.Size(313, 36);
            this.TSMIshowStayInfo.Text = "Show Stay Info";
            // 
            // TSMIeditinfo
            // 
            this.TSMIeditinfo.Image = global::HMS.Properties.Resources.pencil;
            this.TSMIeditinfo.Name = "TSMIeditinfo";
            this.TSMIeditinfo.Size = new System.Drawing.Size(313, 36);
            this.TSMIeditinfo.Text = "Edit Stay Info";
            // 
            // TSMCancel
            // 
            this.TSMCancel.Image = global::HMS.Properties.Resources.cancel;
            this.TSMCancel.Name = "TSMCancel";
            this.TSMCancel.Size = new System.Drawing.Size(313, 36);
            this.TSMCancel.Text = "Cancel Stay";
            this.TSMCancel.Click += new System.EventHandler(this.TSMCancel_Click_1);
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
            this.txtFilterByValue.Location = new System.Drawing.Point(407, 291);
            this.txtFilterByValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilterByValue.Name = "txtFilterByValue";
            this.txtFilterByValue.PlaceholderText = "";
            this.txtFilterByValue.SelectedText = "";
            this.txtFilterByValue.Size = new System.Drawing.Size(332, 36);
            this.txtFilterByValue.TabIndex = 42;
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
            this.CBfilterBy.Location = new System.Drawing.Point(18, 291);
            this.CBfilterBy.Name = "CBfilterBy";
            this.CBfilterBy.Size = new System.Drawing.Size(332, 36);
            this.CBfilterBy.TabIndex = 41;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(-120, 296);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(105, 27);
            this.guna2HtmlLabel2.TabIndex = 40;
            this.guna2HtmlLabel2.Text = "Filter  By :  ";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(579, 190);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(255, 44);
            this.guna2HtmlLabel1.TabIndex = 39;
            this.guna2HtmlLabel1.Text = "Manage Stays";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::HMS.Properties.Resources.retention;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(609, 25);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(172, 135);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 38;
            this.guna2CirclePictureBox1.TabStop = false;
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
            this.btnClose.Location = new System.Drawing.Point(1156, 665);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(179, 51);
            this.btnClose.TabIndex = 47;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmManageStays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 753);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblNumberOfStays);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.CBStayStatus);
            this.Controls.Add(this.DGVStays);
            this.Controls.Add(this.txtFilterByValue);
            this.Controls.Add(this.CBfilterBy);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmManageStays";
            this.Text = "FrmManageStays";
            this.Load += new System.EventHandler(this.FrmManageStays_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DGVStays)).EndInit();
            this.CMSstays.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNumberOfStays;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox CBStayStatus;
        private Guna.UI2.WinForms.Guna2DataGridView DGVStays;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip CMSstays;
        private System.Windows.Forms.ToolStripMenuItem TSMIaddStay;
        private System.Windows.Forms.ToolStripMenuItem TSMIshowStayInfo;
        private System.Windows.Forms.ToolStripMenuItem TSMIeditinfo;
        private System.Windows.Forms.ToolStripMenuItem TSMCancel;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterByValue;
        private Guna.UI2.WinForms.Guna2ComboBox CBfilterBy;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}