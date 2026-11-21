namespace HMS.Invoices
{
    partial class FRMmanageInvoices
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
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.lblNumberOfInvoices = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CBInvoiceStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DGVInvoices = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CMSInvoices = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.TSMIaddInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIshowInvoiceInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIeditinfo = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFilterByValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.CBfilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInvoices)).BeginInit();
            this.CMSInvoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.btnClose.Location = new System.Drawing.Point(1207, 654);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(179, 51);
            this.btnClose.TabIndex = 56;
            this.btnClose.Text = "Close";
            // 
            // lblNumberOfInvoices
            // 
            this.lblNumberOfInvoices.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfInvoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfInvoices.Location = new System.Drawing.Point(275, 679);
            this.lblNumberOfInvoices.Name = "lblNumberOfInvoices";
            this.lblNumberOfInvoices.Size = new System.Drawing.Size(14, 26);
            this.lblNumberOfInvoices.TabIndex = 55;
            this.lblNumberOfInvoices.Text = "0";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(68, 679);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(201, 25);
            this.guna2HtmlLabel3.TabIndex = 54;
            this.guna2HtmlLabel3.Text = "Number Of Invoices:";
            // 
            // CBInvoiceStatus
            // 
            this.CBInvoiceStatus.BackColor = System.Drawing.Color.Transparent;
            this.CBInvoiceStatus.BorderRadius = 16;
            this.CBInvoiceStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBInvoiceStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBInvoiceStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBInvoiceStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBInvoiceStatus.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.CBInvoiceStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CBInvoiceStatus.ItemHeight = 30;
            this.CBInvoiceStatus.Items.AddRange(new object[] {
            "All",
            "UnPaid",
            "Partialy Paid",
            "Paid",
            "Cancled"});
            this.CBInvoiceStatus.Location = new System.Drawing.Point(621, 280);
            this.CBInvoiceStatus.Name = "CBInvoiceStatus";
            this.CBInvoiceStatus.Size = new System.Drawing.Size(255, 36);
            this.CBInvoiceStatus.TabIndex = 53;
            // 
            // DGVInvoices
            // 
            this.DGVInvoices.AllowUserToAddRows = false;
            this.DGVInvoices.AllowUserToDeleteRows = false;
            this.DGVInvoices.AllowUserToResizeColumns = false;
            this.DGVInvoices.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVInvoices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVInvoices.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVInvoices.ColumnHeadersHeight = 20;
            this.DGVInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVInvoices.ContextMenuStrip = this.CMSInvoices;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVInvoices.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVInvoices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVInvoices.Location = new System.Drawing.Point(69, 345);
            this.DGVInvoices.Name = "DGVInvoices";
            this.DGVInvoices.ReadOnly = true;
            this.DGVInvoices.RowHeadersVisible = false;
            this.DGVInvoices.Size = new System.Drawing.Size(1317, 295);
            this.DGVInvoices.TabIndex = 52;
            this.DGVInvoices.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVInvoices.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.DGVInvoices.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVInvoices.ThemeStyle.HeaderStyle.Height = 20;
            this.DGVInvoices.ThemeStyle.ReadOnly = true;
            this.DGVInvoices.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // CMSInvoices
            // 
            this.CMSInvoices.BackColor = System.Drawing.Color.Silver;
            this.CMSInvoices.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMSInvoices.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.CMSInvoices.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.CMSInvoices.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIaddInvoice,
            this.TSMIshowInvoiceInfo,
            this.TSMIeditinfo,
            this.TSMCancel});
            this.CMSInvoices.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.CMSInvoices.Name = "CMSusers";
            this.CMSInvoices.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.CMSInvoices.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CMSInvoices.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.CMSInvoices.RenderStyle.ColorTable = null;
            this.CMSInvoices.RenderStyle.RoundedEdges = true;
            this.CMSInvoices.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.CMSInvoices.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CMSInvoices.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.CMSInvoices.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.CMSInvoices.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.CMSInvoices.Size = new System.Drawing.Size(280, 148);
            // 
            // TSMIaddInvoice
            // 
            this.TSMIaddInvoice.Image = global::HMS.Properties.Resources.bill__1_;
            this.TSMIaddInvoice.Name = "TSMIaddInvoice";
            this.TSMIaddInvoice.Size = new System.Drawing.Size(279, 36);
            this.TSMIaddInvoice.Text = "Add New Invoice";
            // 
            // TSMIshowInvoiceInfo
            // 
            this.TSMIshowInvoiceInfo.Image = global::HMS.Properties.Resources.info;
            this.TSMIshowInvoiceInfo.Name = "TSMIshowInvoiceInfo";
            this.TSMIshowInvoiceInfo.Size = new System.Drawing.Size(279, 36);
            this.TSMIshowInvoiceInfo.Text = "Show Invoice Info";
            // 
            // TSMIeditinfo
            // 
            this.TSMIeditinfo.Image = global::HMS.Properties.Resources.pencil;
            this.TSMIeditinfo.Name = "TSMIeditinfo";
            this.TSMIeditinfo.Size = new System.Drawing.Size(279, 36);
            this.TSMIeditinfo.Text = "Edit Invoice Info";
            // 
            // TSMCancel
            // 
            this.TSMCancel.Image = global::HMS.Properties.Resources.cancel;
            this.TSMCancel.Name = "TSMCancel";
            this.TSMCancel.Size = new System.Drawing.Size(279, 36);
            this.TSMCancel.Text = "Cancel Invoice";
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
            this.txtFilterByValue.Location = new System.Drawing.Point(621, 280);
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
            "InvoiceID",
            "StayID",
            "User ID",
            "Status"});
            this.CBfilterBy.Location = new System.Drawing.Point(232, 280);
            this.CBfilterBy.Name = "CBfilterBy";
            this.CBfilterBy.Size = new System.Drawing.Size(332, 36);
            this.CBfilterBy.TabIndex = 50;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(591, 180);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(301, 44);
            this.guna2HtmlLabel1.TabIndex = 49;
            this.guna2HtmlLabel1.Text = "Manage Invoices";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::HMS.Properties.Resources.bill__1_;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(660, 14);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(172, 135);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 48;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(107, 289);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(98, 27);
            this.guna2HtmlLabel2.TabIndex = 57;
            this.guna2HtmlLabel2.Text = "Filter By:";
            // 
            // FRMmanageInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 735);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblNumberOfInvoices);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.CBInvoiceStatus);
            this.Controls.Add(this.DGVInvoices);
            this.Controls.Add(this.txtFilterByValue);
            this.Controls.Add(this.CBfilterBy);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Name = "FRMmanageInvoices";
            this.Text = "FRMmanageInvoices";
            ((System.ComponentModel.ISupportInitialize)(this.DGVInvoices)).EndInit();
            this.CMSInvoices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNumberOfInvoices;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox CBInvoiceStatus;
        private Guna.UI2.WinForms.Guna2DataGridView DGVInvoices;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip CMSInvoices;
        private System.Windows.Forms.ToolStripMenuItem TSMIaddInvoice;
        private System.Windows.Forms.ToolStripMenuItem TSMIshowInvoiceInfo;
        private System.Windows.Forms.ToolStripMenuItem TSMIeditinfo;
        private System.Windows.Forms.ToolStripMenuItem TSMCancel;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterByValue;
        private Guna.UI2.WinForms.Guna2ComboBox CBfilterBy;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}