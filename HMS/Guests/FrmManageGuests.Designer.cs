namespace HMS.Guests
{
    partial class FrmManageGuests
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
            this.lblNOusers = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbIsActive = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DGVListGuests = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CMSGuests = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.TSMIaddNewGuest = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIshowdetails = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIeditinfo = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIdelete = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFilterByValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.CBfilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrev = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewGuest = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListGuests)).BeginInit();
            this.CMSGuests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNOusers
            // 
            this.lblNOusers.BackColor = System.Drawing.Color.Transparent;
            this.lblNOusers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNOusers.Location = new System.Drawing.Point(276, 876);
            this.lblNOusers.Name = "lblNOusers";
            this.lblNOusers.Size = new System.Drawing.Size(14, 26);
            this.lblNOusers.TabIndex = 22;
            this.lblNOusers.Text = "0";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(81, 876);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(179, 25);
            this.guna2HtmlLabel3.TabIndex = 21;
            this.guna2HtmlLabel3.Text = "Number Of Users : ";
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
            this.cbIsActive.Location = new System.Drawing.Point(608, 380);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(255, 36);
            this.cbIsActive.TabIndex = 20;
            this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
            // 
            // DGVListGuests
            // 
            this.DGVListGuests.AllowUserToAddRows = false;
            this.DGVListGuests.AllowUserToDeleteRows = false;
            this.DGVListGuests.AllowUserToResizeColumns = false;
            this.DGVListGuests.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVListGuests.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVListGuests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVListGuests.ColumnHeadersHeight = 20;
            this.DGVListGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVListGuests.ContextMenuStrip = this.CMSGuests;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVListGuests.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVListGuests.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVListGuests.Location = new System.Drawing.Point(81, 440);
            this.DGVListGuests.Name = "DGVListGuests";
            this.DGVListGuests.ReadOnly = true;
            this.DGVListGuests.RowHeadersVisible = false;
            this.DGVListGuests.Size = new System.Drawing.Size(1179, 295);
            this.DGVListGuests.TabIndex = 17;
            this.DGVListGuests.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVListGuests.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVListGuests.ThemeStyle.HeaderStyle.Height = 20;
            this.DGVListGuests.ThemeStyle.ReadOnly = true;
            this.DGVListGuests.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // CMSGuests
            // 
            this.CMSGuests.BackColor = System.Drawing.Color.LightGray;
            this.CMSGuests.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMSGuests.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.CMSGuests.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.CMSGuests.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIaddNewGuest,
            this.TSMIshowdetails,
            this.TSMIeditinfo,
            this.TSMIdelete});
            this.CMSGuests.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.CMSGuests.Name = "CMSusers";
            this.CMSGuests.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.CMSGuests.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CMSGuests.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.CMSGuests.RenderStyle.ColorTable = null;
            this.CMSGuests.RenderStyle.RoundedEdges = true;
            this.CMSGuests.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.CMSGuests.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CMSGuests.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.CMSGuests.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.CMSGuests.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.CMSGuests.Size = new System.Drawing.Size(255, 170);
            // 
            // TSMIaddNewGuest
            // 
            this.TSMIaddNewGuest.Image = global::HMS.Properties.Resources.AddPerson;
            this.TSMIaddNewGuest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TSMIaddNewGuest.Name = "TSMIaddNewGuest";
            this.TSMIaddNewGuest.Size = new System.Drawing.Size(254, 36);
            this.TSMIaddNewGuest.Text = "Add New Guest";
            this.TSMIaddNewGuest.Click += new System.EventHandler(this.TSMIaddNewGuest_Click);
            // 
            // TSMIshowdetails
            // 
            this.TSMIshowdetails.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSMIshowdetails.Image = global::HMS.Properties.Resources.PersonInfo;
            this.TSMIshowdetails.Name = "TSMIshowdetails";
            this.TSMIshowdetails.Size = new System.Drawing.Size(254, 36);
            this.TSMIshowdetails.Text = "Show Details";
            this.TSMIshowdetails.Click += new System.EventHandler(this.TSMIshowdetails_Click);
            // 
            // TSMIeditinfo
            // 
            this.TSMIeditinfo.Image = global::HMS.Properties.Resources.edit_Person;
            this.TSMIeditinfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TSMIeditinfo.Name = "TSMIeditinfo";
            this.TSMIeditinfo.Size = new System.Drawing.Size(254, 36);
            this.TSMIeditinfo.Text = "Edit Info";
            this.TSMIeditinfo.Click += new System.EventHandler(this.TSMIeditinfo_Click);
            // 
            // TSMIdelete
            // 
            this.TSMIdelete.Image = global::HMS.Properties.Resources.delete_Person;
            this.TSMIdelete.Name = "TSMIdelete";
            this.TSMIdelete.Size = new System.Drawing.Size(254, 36);
            this.TSMIdelete.Text = "Delete";
            this.TSMIdelete.Click += new System.EventHandler(this.TSMIdelete_Click);
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
            this.txtFilterByValue.Location = new System.Drawing.Point(608, 380);
            this.txtFilterByValue.Name = "txtFilterByValue";
            this.txtFilterByValue.PlaceholderText = "";
            this.txtFilterByValue.SelectedText = "";
            this.txtFilterByValue.Size = new System.Drawing.Size(332, 36);
            this.txtFilterByValue.TabIndex = 16;
            this.txtFilterByValue.TextChanged += new System.EventHandler(this.txtFilterByValue_TextChanged);
            this.txtFilterByValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterByValue_KeyPress);
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
            "Guest ID",
            "Person ID",
            "National Number",
            "Full Name",
            "is Active"});
            this.CBfilterBy.Location = new System.Drawing.Point(213, 380);
            this.CBfilterBy.Name = "CBfilterBy";
            this.CBfilterBy.Size = new System.Drawing.Size(332, 36);
            this.CBfilterBy.TabIndex = 15;
            this.CBfilterBy.SelectedIndexChanged += new System.EventHandler(this.CBfilterBy_SelectedIndexChanged);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(81, 385);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(105, 27);
            this.guna2HtmlLabel2.TabIndex = 14;
            this.guna2HtmlLabel2.Text = "Filter  By :  ";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(521, 247);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(304, 46);
            this.guna2HtmlLabel1.TabIndex = 13;
            this.guna2HtmlLabel1.Text = "Manage Guests";
            // 
            // btnNext
            // 
            this.btnNext.BorderRadius = 15;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.Silver;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Image = global::HMS.Properties.Resources.right_arrow;
            this.btnNext.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnNext.ImageSize = new System.Drawing.Size(40, 40);
            this.btnNext.Location = new System.Drawing.Point(879, 741);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(179, 51);
            this.btnNext.TabIndex = 24;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BorderRadius = 15;
            this.btnPrev.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrev.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrev.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrev.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrev.FillColor = System.Drawing.Color.Silver;
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.Black;
            this.btnPrev.Image = global::HMS.Properties.Resources.left_arrow;
            this.btnPrev.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPrev.ImageSize = new System.Drawing.Size(40, 40);
            this.btnPrev.Location = new System.Drawing.Point(315, 741);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(179, 51);
            this.btnPrev.TabIndex = 23;
            this.btnPrev.Text = "Prev";
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
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
            this.guna2Button1.Location = new System.Drawing.Point(1058, 876);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(179, 51);
            this.guna2Button1.TabIndex = 19;
            this.guna2Button1.Text = "Close";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnAddNewGuest
            // 
            this.btnAddNewGuest.BorderRadius = 15;
            this.btnAddNewGuest.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewGuest.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewGuest.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewGuest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewGuest.FillColor = System.Drawing.Color.Silver;
            this.btnAddNewGuest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddNewGuest.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewGuest.Image = global::HMS.Properties.Resources.AddPerson;
            this.btnAddNewGuest.ImageSize = new System.Drawing.Size(45, 45);
            this.btnAddNewGuest.Location = new System.Drawing.Point(1156, 371);
            this.btnAddNewGuest.Name = "btnAddNewGuest";
            this.btnAddNewGuest.Size = new System.Drawing.Size(104, 61);
            this.btnAddNewGuest.TabIndex = 18;
            this.btnAddNewGuest.Click += new System.EventHandler(this.btnAddNewGuest_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::HMS.Properties.Resources.shortlist;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(521, 12);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(283, 213);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 12;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // FrmManageGuests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 966);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.lblNOusers);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.cbIsActive);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnAddNewGuest);
            this.Controls.Add(this.DGVListGuests);
            this.Controls.Add(this.txtFilterByValue);
            this.Controls.Add(this.CBfilterBy);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmManageGuests";
            this.Text = "Guests List";
            this.Load += new System.EventHandler(this.FrmManageGuests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVListGuests)).EndInit();
            this.CMSGuests.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblNOusers;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox cbIsActive;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnAddNewGuest;
        private Guna.UI2.WinForms.Guna2DataGridView DGVListGuests;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterByValue;
        private Guna.UI2.WinForms.Guna2ComboBox CBfilterBy;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnPrev;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip CMSGuests;
        private System.Windows.Forms.ToolStripMenuItem TSMIaddNewGuest;
        private System.Windows.Forms.ToolStripMenuItem TSMIshowdetails;
        private System.Windows.Forms.ToolStripMenuItem TSMIeditinfo;
        private System.Windows.Forms.ToolStripMenuItem TSMIdelete;
    }
}