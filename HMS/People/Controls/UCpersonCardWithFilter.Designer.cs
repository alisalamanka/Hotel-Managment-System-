namespace HMS.People.Controls
{
    partial class UCpersonCardWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GPFilter = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnAddNewPerson = new Guna.UI2.WinForms.Guna2Button();
            this.btnFind = new Guna.UI2.WinForms.Guna2Button();
            this.txtFilterByValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.CBfilterby = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.uCpersonCard1 = new HMS.People.Controls.UCpersonCard();
            this.GPFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // GPFilter
            // 
            this.GPFilter.BorderRadius = 16;
            this.GPFilter.Controls.Add(this.btnAddNewPerson);
            this.GPFilter.Controls.Add(this.btnFind);
            this.GPFilter.Controls.Add(this.txtFilterByValue);
            this.GPFilter.Controls.Add(this.CBfilterby);
            this.GPFilter.Controls.Add(this.guna2HtmlLabel2);
            this.GPFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GPFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.GPFilter.Location = new System.Drawing.Point(13, 3);
            this.GPFilter.Name = "GPFilter";
            this.GPFilter.Size = new System.Drawing.Size(914, 135);
            this.GPFilter.TabIndex = 1;
            this.GPFilter.Text = "Filter";
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.Animated = true;
            this.btnAddNewPerson.BorderColor = System.Drawing.Color.DimGray;
            this.btnAddNewPerson.BorderRadius = 13;
            this.btnAddNewPerson.BorderThickness = 2;
            this.btnAddNewPerson.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewPerson.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewPerson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewPerson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewPerson.FillColor = System.Drawing.Color.Silver;
            this.btnAddNewPerson.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewPerson.ForeColor = System.Drawing.Color.White;
            this.btnAddNewPerson.Image = global::HMS.Properties.Resources.add_user;
            this.btnAddNewPerson.Location = new System.Drawing.Point(784, 59);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(85, 45);
            this.btnAddNewPerson.TabIndex = 5;
            // 
            // btnFind
            // 
            this.btnFind.Animated = true;
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.BorderColor = System.Drawing.Color.DimGray;
            this.btnFind.BorderRadius = 13;
            this.btnFind.BorderThickness = 2;
            this.btnFind.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFind.FillColor = System.Drawing.Color.Silver;
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Image = global::HMS.Properties.Resources.user__1_;
            this.btnFind.Location = new System.Drawing.Point(670, 59);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(83, 45);
            this.btnFind.TabIndex = 4;
            // 
            // txtFilterByValue
            // 
            this.txtFilterByValue.BackColor = System.Drawing.Color.Transparent;
            this.txtFilterByValue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.txtFilterByValue.BorderRadius = 17;
            this.txtFilterByValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterByValue.DefaultText = "";
            this.txtFilterByValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilterByValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilterByValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterByValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterByValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterByValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFilterByValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterByValue.Location = new System.Drawing.Point(385, 68);
            this.txtFilterByValue.Name = "txtFilterByValue";
            this.txtFilterByValue.PlaceholderText = "";
            this.txtFilterByValue.SelectedText = "";
            this.txtFilterByValue.Size = new System.Drawing.Size(251, 36);
            this.txtFilterByValue.TabIndex = 3;
            // 
            // CBfilterby
            // 
            this.CBfilterby.BackColor = System.Drawing.Color.Transparent;
            this.CBfilterby.BorderRadius = 15;
            this.CBfilterby.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBfilterby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBfilterby.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBfilterby.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBfilterby.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBfilterby.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CBfilterby.ItemHeight = 30;
            this.CBfilterby.Items.AddRange(new object[] {
            "Person ID",
            "National Number",
            ""});
            this.CBfilterby.Location = new System.Drawing.Point(120, 68);
            this.CBfilterby.Name = "CBfilterby";
            this.CBfilterby.Size = new System.Drawing.Size(247, 36);
            this.CBfilterby.TabIndex = 2;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(41, 74);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(73, 23);
            this.guna2HtmlLabel2.TabIndex = 1;
            this.guna2HtmlLabel2.Text = "Filter By : ";
            // 
            // uCpersonCard1
            // 
            this.uCpersonCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uCpersonCard1.Location = new System.Drawing.Point(13, 145);
            this.uCpersonCard1.Margin = new System.Windows.Forms.Padding(4);
            this.uCpersonCard1.Name = "uCpersonCard1";
            this.uCpersonCard1.Size = new System.Drawing.Size(930, 317);
            this.uCpersonCard1.TabIndex = 2;
            // 
            // UCpersonCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uCpersonCard1);
            this.Controls.Add(this.GPFilter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCpersonCardWithFilter";
            this.Size = new System.Drawing.Size(952, 466);
            this.GPFilter.ResumeLayout(false);
            this.GPFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox GPFilter;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox CBfilterby;
        private UCpersonCard uCpersonCard1;
        private Guna.UI2.WinForms.Guna2Button btnFind;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterByValue;
        private Guna.UI2.WinForms.Guna2Button btnAddNewPerson;
    }
}
