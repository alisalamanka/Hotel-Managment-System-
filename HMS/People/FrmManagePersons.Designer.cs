namespace HMS.People
{
    partial class FrmManagePersons
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvListPeople = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CMSpersons = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMIshowPersonInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIaddPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIeditPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIdelete = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CBfilterby = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TBfilterbyvalue = new Guna.UI2.WinForms.Guna2TextBox();
            this.CbIsActive = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAddPerson = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LBLnumberofreccords = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPeople)).BeginInit();
            this.CMSpersons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(458, 225);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(239, 38);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Manage People";
            // 
            // dgvListPeople
            // 
            this.dgvListPeople.AllowDrop = true;
            this.dgvListPeople.AllowUserToAddRows = false;
            this.dgvListPeople.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvListPeople.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListPeople.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListPeople.ColumnHeadersHeight = 45;
            this.dgvListPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListPeople.ContextMenuStrip = this.CMSpersons;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListPeople.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListPeople.EnableHeadersVisualStyles = true;
            this.dgvListPeople.GridColor = System.Drawing.Color.White;
            this.dgvListPeople.Location = new System.Drawing.Point(90, 393);
            this.dgvListPeople.Name = "dgvListPeople";
            this.dgvListPeople.ReadOnly = true;
            this.dgvListPeople.RowHeadersVisible = false;
            this.dgvListPeople.Size = new System.Drawing.Size(986, 360);
            this.dgvListPeople.TabIndex = 2;
            this.dgvListPeople.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListPeople.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgvListPeople.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListPeople.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvListPeople.ThemeStyle.ReadOnly = true;
            this.dgvListPeople.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListPeople.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListPeople_CellDoubleClick);
            // 
            // CMSpersons
            // 
            this.CMSpersons.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CMSpersons.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMSpersons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIshowPersonInfo,
            this.TSMIaddPerson,
            this.TSMIeditPerson,
            this.TSMIdelete});
            this.CMSpersons.Name = "CMSpersons";
            this.CMSpersons.Size = new System.Drawing.Size(295, 156);
            // 
            // TSMIshowPersonInfo
            // 
            this.TSMIshowPersonInfo.Image = global::HMS.Properties.Resources.PersonInfo32;
            this.TSMIshowPersonInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMIshowPersonInfo.Name = "TSMIshowPersonInfo";
            this.TSMIshowPersonInfo.Size = new System.Drawing.Size(294, 38);
            this.TSMIshowPersonInfo.Text = "Show Person Details";
            this.TSMIshowPersonInfo.Click += new System.EventHandler(this.TSMIshowPersonInfo_Click);
            // 
            // TSMIaddPerson
            // 
            this.TSMIaddPerson.Image = global::HMS.Properties.Resources.addPerson32;
            this.TSMIaddPerson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMIaddPerson.Name = "TSMIaddPerson";
            this.TSMIaddPerson.Size = new System.Drawing.Size(294, 38);
            this.TSMIaddPerson.Text = "Add New Person";
            this.TSMIaddPerson.Click += new System.EventHandler(this.TSMIaddPerson_Click);
            // 
            // TSMIeditPerson
            // 
            this.TSMIeditPerson.Image = global::HMS.Properties.Resources.edit_Person32;
            this.TSMIeditPerson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMIeditPerson.Name = "TSMIeditPerson";
            this.TSMIeditPerson.Size = new System.Drawing.Size(294, 38);
            this.TSMIeditPerson.Text = "Edit";
            this.TSMIeditPerson.Click += new System.EventHandler(this.TSMIeditPerson_Click);
            // 
            // TSMIdelete
            // 
            this.TSMIdelete.Image = global::HMS.Properties.Resources.deletePerson32;
            this.TSMIdelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMIdelete.Name = "TSMIdelete";
            this.TSMIdelete.Size = new System.Drawing.Size(294, 38);
            this.TSMIdelete.Text = "Delete";
            this.TSMIdelete.Click += new System.EventHandler(this.TSMIdelete_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(90, 349);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(122, 27);
            this.guna2HtmlLabel2.TabIndex = 3;
            this.guna2HtmlLabel2.Text = "Filter By:";
            // 
            // CBfilterby
            // 
            this.CBfilterby.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.CBfilterby.BorderRadius = 15;
            this.CBfilterby.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBfilterby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBfilterby.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBfilterby.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBfilterby.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBfilterby.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CBfilterby.ItemHeight = 30;
            this.CBfilterby.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "National Number",
            "First Name",
            "Last Name",
            "Email",
            "Phone",
            "Country",
            "Is Active"});
            this.CBfilterby.Location = new System.Drawing.Point(219, 343);
            this.CBfilterby.Name = "CBfilterby";
            this.CBfilterby.Size = new System.Drawing.Size(251, 36);
            this.CBfilterby.TabIndex = 4;
            this.CBfilterby.SelectedIndexChanged += new System.EventHandler(this.CBfilterby_SelectedIndexChanged);
            // 
            // TBfilterbyvalue
            // 
            this.TBfilterbyvalue.BorderRadius = 15;
            this.TBfilterbyvalue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBfilterbyvalue.DefaultText = "";
            this.TBfilterbyvalue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBfilterbyvalue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBfilterbyvalue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBfilterbyvalue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBfilterbyvalue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBfilterbyvalue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBfilterbyvalue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBfilterbyvalue.Location = new System.Drawing.Point(496, 343);
            this.TBfilterbyvalue.Name = "TBfilterbyvalue";
            this.TBfilterbyvalue.PlaceholderText = "";
            this.TBfilterbyvalue.SelectedText = "";
            this.TBfilterbyvalue.Size = new System.Drawing.Size(235, 36);
            this.TBfilterbyvalue.TabIndex = 5;
            this.TBfilterbyvalue.TextChanged += new System.EventHandler(this.TBfilterbyvalue_TextChanged);
            this.TBfilterbyvalue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBfilterbyvalue_KeyPress);
            // 
            // CbIsActive
            // 
            this.CbIsActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.CbIsActive.BorderRadius = 15;
            this.CbIsActive.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbIsActive.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbIsActive.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbIsActive.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbIsActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CbIsActive.ItemHeight = 30;
            this.CbIsActive.Items.AddRange(new object[] {
            "Yes",
            "No ",
            "All"});
            this.CbIsActive.Location = new System.Drawing.Point(496, 343);
            this.CbIsActive.Name = "CbIsActive";
            this.CbIsActive.Size = new System.Drawing.Size(185, 36);
            this.CbIsActive.TabIndex = 6;
            this.CbIsActive.SelectedIndexChanged += new System.EventHandler(this.CbIsActive_SelectedIndexChanged);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Animated = true;
            this.btnAddPerson.BorderRadius = 18;
            this.btnAddPerson.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPerson.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPerson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddPerson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddPerson.FillColor = System.Drawing.Color.Black;
            this.btnAddPerson.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddPerson.ForeColor = System.Drawing.Color.White;
            this.btnAddPerson.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddPerson.Location = new System.Drawing.Point(887, 334);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(180, 45);
            this.btnAddPerson.TabIndex = 8;
            this.btnAddPerson.Text = "Add Person";
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Animated = true;
            this.btnCancel.BorderRadius = 17;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.Black;
            this.btnCancel.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(935, 784);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(141, 45);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(90, 785);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(124, 24);
            this.guna2HtmlLabel3.TabIndex = 10;
            this.guna2HtmlLabel3.Text = "#Reccords:";
            // 
            // LBLnumberofreccords
            // 
            this.LBLnumberofreccords.BackColor = System.Drawing.Color.Transparent;
            this.LBLnumberofreccords.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLnumberofreccords.Location = new System.Drawing.Point(229, 785);
            this.LBLnumberofreccords.Name = "LBLnumberofreccords";
            this.LBLnumberofreccords.Size = new System.Drawing.Size(15, 24);
            this.LBLnumberofreccords.TabIndex = 11;
            this.LBLnumberofreccords.Text = "0";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::HMS.Properties.Resources.ManagePersons;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(431, 12);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(291, 191);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // FrmManagePersons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1187, 880);
            this.Controls.Add(this.LBLnumberofreccords);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.CbIsActive);
            this.Controls.Add(this.TBfilterbyvalue);
            this.Controls.Add(this.CBfilterby);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.dgvListPeople);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmManagePersons";
            this.Text = "FrmManagePersons";
            this.Load += new System.EventHandler(this.FrmManagePersons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPeople)).EndInit();
            this.CMSpersons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListPeople;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox CBfilterby;
        private Guna.UI2.WinForms.Guna2TextBox TBfilterbyvalue;
        private Guna.UI2.WinForms.Guna2ComboBox CbIsActive;
        private System.Windows.Forms.ContextMenuStrip CMSpersons;
        private System.Windows.Forms.ToolStripMenuItem TSMIshowPersonInfo;
        private System.Windows.Forms.ToolStripMenuItem TSMIaddPerson;
        private System.Windows.Forms.ToolStripMenuItem TSMIeditPerson;
        private System.Windows.Forms.ToolStripMenuItem TSMIdelete;
        private Guna.UI2.WinForms.Guna2Button btnAddPerson;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel LBLnumberofreccords;
    }
}