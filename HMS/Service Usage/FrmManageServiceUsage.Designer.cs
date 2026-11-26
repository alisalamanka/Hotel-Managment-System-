namespace HMS.Service_Usage
{
    partial class FrmManageServiceUsages
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNumberOfServiceUsages = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CBServiceUsageStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DGVserviceusages = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CMSserviceusages = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.TSMIaddServiceUsage = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIshowServiceusageInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIeditinfo = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFilterByValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.CBfilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddServiceUsage = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVserviceusages)).BeginInit();
            this.CMSserviceusages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumberOfServiceUsages
            // 
            this.lblNumberOfServiceUsages.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfServiceUsages.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfServiceUsages.Location = new System.Drawing.Point(302, 711);
            this.lblNumberOfServiceUsages.Name = "lblNumberOfServiceUsages";
            this.lblNumberOfServiceUsages.Size = new System.Drawing.Size(14, 26);
            this.lblNumberOfServiceUsages.TabIndex = 55;
            this.lblNumberOfServiceUsages.Text = "0";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(29, 711);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(263, 25);
            this.guna2HtmlLabel3.TabIndex = 54;
            this.guna2HtmlLabel3.Text = "Number Of Service Usages:";
            // 
            // CBServiceUsageStatus
            // 
            this.CBServiceUsageStatus.BackColor = System.Drawing.Color.Transparent;
            this.CBServiceUsageStatus.BorderRadius = 16;
            this.CBServiceUsageStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBServiceUsageStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBServiceUsageStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBServiceUsageStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBServiceUsageStatus.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.CBServiceUsageStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CBServiceUsageStatus.ItemHeight = 30;
            this.CBServiceUsageStatus.Items.AddRange(new object[] {
            "All",
            "Confirmed",
            "Cancelled"});
            this.CBServiceUsageStatus.Location = new System.Drawing.Point(421, 312);
            this.CBServiceUsageStatus.Name = "CBServiceUsageStatus";
            this.CBServiceUsageStatus.Size = new System.Drawing.Size(255, 36);
            this.CBServiceUsageStatus.TabIndex = 53;
            // 
            // DGVserviceusages
            // 
            this.DGVserviceusages.AllowUserToAddRows = false;
            this.DGVserviceusages.AllowUserToDeleteRows = false;
            this.DGVserviceusages.AllowUserToResizeColumns = false;
            this.DGVserviceusages.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.DGVserviceusages.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DGVserviceusages.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVserviceusages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DGVserviceusages.ColumnHeadersHeight = 20;
            this.DGVserviceusages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVserviceusages.ContextMenuStrip = this.CMSserviceusages;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVserviceusages.DefaultCellStyle = dataGridViewCellStyle9;
            this.DGVserviceusages.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVserviceusages.Location = new System.Drawing.Point(37, 377);
            this.DGVserviceusages.Name = "DGVserviceusages";
            this.DGVserviceusages.ReadOnly = true;
            this.DGVserviceusages.RowHeadersVisible = false;
            this.DGVserviceusages.Size = new System.Drawing.Size(1317, 295);
            this.DGVserviceusages.TabIndex = 52;
            this.DGVserviceusages.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVserviceusages.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.DGVserviceusages.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVserviceusages.ThemeStyle.HeaderStyle.Height = 20;
            this.DGVserviceusages.ThemeStyle.ReadOnly = true;
            this.DGVserviceusages.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // CMSserviceusages
            // 
            this.CMSserviceusages.BackColor = System.Drawing.Color.Silver;
            this.CMSserviceusages.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMSserviceusages.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.CMSserviceusages.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.CMSserviceusages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIaddServiceUsage,
            this.TSMIshowServiceusageInfo,
            this.TSMIeditinfo,
            this.TSMCancel});
            this.CMSserviceusages.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.CMSserviceusages.Name = "CMSusers";
            this.CMSserviceusages.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.CMSserviceusages.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CMSserviceusages.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.CMSserviceusages.RenderStyle.ColorTable = null;
            this.CMSserviceusages.RenderStyle.RoundedEdges = true;
            this.CMSserviceusages.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.CMSserviceusages.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CMSserviceusages.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.CMSserviceusages.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.CMSserviceusages.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.CMSserviceusages.Size = new System.Drawing.Size(344, 148);
            // 
            // TSMIaddServiceUsage
            // 
            this.TSMIaddServiceUsage.Image = global::HMS.Properties.Resources.responsible;
            this.TSMIaddServiceUsage.Name = "TSMIaddServiceUsage";
            this.TSMIaddServiceUsage.Size = new System.Drawing.Size(343, 36);
            this.TSMIaddServiceUsage.Text = "Add New Service Usage";
            // 
            // TSMIshowServiceusageInfo
            // 
            this.TSMIshowServiceusageInfo.Image = global::HMS.Properties.Resources.info;
            this.TSMIshowServiceusageInfo.Name = "TSMIshowServiceusageInfo";
            this.TSMIshowServiceusageInfo.Size = new System.Drawing.Size(343, 36);
            this.TSMIshowServiceusageInfo.Text = "Show Service Usage Info";
            // 
            // TSMIeditinfo
            // 
            this.TSMIeditinfo.Image = global::HMS.Properties.Resources.pencil;
            this.TSMIeditinfo.Name = "TSMIeditinfo";
            this.TSMIeditinfo.Size = new System.Drawing.Size(343, 36);
            this.TSMIeditinfo.Text = "Edit Service Usage Info";
            // 
            // TSMCancel
            // 
            this.TSMCancel.Image = global::HMS.Properties.Resources.cancel;
            this.TSMCancel.Name = "TSMCancel";
            this.TSMCancel.Size = new System.Drawing.Size(343, 36);
            this.TSMCancel.Text = "Cancel Service Usage";
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
            this.txtFilterByValue.Location = new System.Drawing.Point(422, 312);
            this.txtFilterByValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilterByValue.Name = "txtFilterByValue";
            this.txtFilterByValue.PlaceholderText = "";
            this.txtFilterByValue.SelectedText = "";
            this.txtFilterByValue.Size = new System.Drawing.Size(332, 36);
            this.txtFilterByValue.TabIndex = 51;
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
            "ServiceUsage ID",
            "Stay ID",
            "Guest ID",
            "Order ID",
            "Status"});
            this.CBfilterBy.Location = new System.Drawing.Point(41, 312);
            this.CBfilterBy.Name = "CBfilterBy";
            this.CBfilterBy.Size = new System.Drawing.Size(332, 36);
            this.CBfilterBy.TabIndex = 50;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(476, 211);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(433, 44);
            this.guna2HtmlLabel1.TabIndex = 49;
            this.guna2HtmlLabel1.Text = "Manage Service Usages";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::HMS.Properties.Resources.Service264;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(609, 54);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(172, 135);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 48;
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
            this.btnClose.Location = new System.Drawing.Point(1175, 685);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(179, 51);
            this.btnClose.TabIndex = 56;
            this.btnClose.Text = "Close";
            // 
            // btnAddServiceUsage
            // 
            this.btnAddServiceUsage.BorderRadius = 15;
            this.btnAddServiceUsage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddServiceUsage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddServiceUsage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddServiceUsage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddServiceUsage.FillColor = System.Drawing.Color.Silver;
            this.btnAddServiceUsage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddServiceUsage.ForeColor = System.Drawing.Color.Black;
            this.btnAddServiceUsage.Image = global::HMS.Properties.Resources.plus;
            this.btnAddServiceUsage.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddServiceUsage.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddServiceUsage.Location = new System.Drawing.Point(1198, 303);
            this.btnAddServiceUsage.Name = "btnAddServiceUsage";
            this.btnAddServiceUsage.Size = new System.Drawing.Size(156, 59);
            this.btnAddServiceUsage.TabIndex = 57;
            this.btnAddServiceUsage.Text = "ADD";
            this.btnAddServiceUsage.Click += new System.EventHandler(this.btnAddServiceUsage_Click);
            // 
            // FrmManageServiceUsages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 783);
            this.Controls.Add(this.btnAddServiceUsage);
            this.Controls.Add(this.lblNumberOfServiceUsages);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.CBServiceUsageStatus);
            this.Controls.Add(this.DGVserviceusages);
            this.Controls.Add(this.txtFilterByValue);
            this.Controls.Add(this.CBfilterBy);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmManageServiceUsages";
            this.Text = "FrmManageServiceUsage";
            ((System.ComponentModel.ISupportInitialize)(this.DGVserviceusages)).EndInit();
            this.CMSserviceusages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblNumberOfServiceUsages;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox CBServiceUsageStatus;
        private Guna.UI2.WinForms.Guna2DataGridView DGVserviceusages;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip CMSserviceusages;
        private System.Windows.Forms.ToolStripMenuItem TSMIaddServiceUsage;
        private System.Windows.Forms.ToolStripMenuItem TSMIshowServiceusageInfo;
        private System.Windows.Forms.ToolStripMenuItem TSMIeditinfo;
        private System.Windows.Forms.ToolStripMenuItem TSMCancel;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterByValue;
        private Guna.UI2.WinForms.Guna2ComboBox CBfilterBy;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnAddServiceUsage;
    }
}