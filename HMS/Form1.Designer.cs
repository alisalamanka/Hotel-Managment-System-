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
            this.ctrlGuestDetails1 = new HMS.Guests.Controls.ctrlGuestDetails();
            this.SuspendLayout();
            // 
            // ctrlGuestDetails1
            // 
            this.ctrlGuestDetails1.BackColor = System.Drawing.Color.Gainsboro;
            this.ctrlGuestDetails1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlGuestDetails1.Location = new System.Drawing.Point(78, 36);
            this.ctrlGuestDetails1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlGuestDetails1.Name = "ctrlGuestDetails1";
            this.ctrlGuestDetails1.Size = new System.Drawing.Size(1016, 546);
            this.ctrlGuestDetails1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 1061);
            this.Controls.Add(this.ctrlGuestDetails1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guests.Controls.ctrlGuestDetails ctrlGuestDetails1;
    }
}