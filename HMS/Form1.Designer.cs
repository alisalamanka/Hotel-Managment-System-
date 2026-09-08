namespace HMS
{
    partial class Form1
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
            this.uCpersonCardWithFilter1 = new HMS.People.Controls.UCpersonCardWithFilter();
            this.SuspendLayout();
            // 
            // uCpersonCardWithFilter1
            // 
            this.uCpersonCardWithFilter1.BackColor = System.Drawing.Color.Gainsboro;
            this.uCpersonCardWithFilter1.FilterEnabled = true;
            this.uCpersonCardWithFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uCpersonCardWithFilter1.Location = new System.Drawing.Point(64, 43);
            this.uCpersonCardWithFilter1.Margin = new System.Windows.Forms.Padding(4);
            this.uCpersonCardWithFilter1.Name = "uCpersonCardWithFilter1";
            this.uCpersonCardWithFilter1.ShowAddnewPerson = true;
            this.uCpersonCardWithFilter1.Size = new System.Drawing.Size(952, 668);
            this.uCpersonCardWithFilter1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 748);
            this.Controls.Add(this.uCpersonCardWithFilter1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private People.Controls.UCpersonCardWithFilter uCpersonCardWithFilter1;
    }
}