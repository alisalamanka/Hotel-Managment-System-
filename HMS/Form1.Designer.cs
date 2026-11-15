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
            this.ctrlReservationInfo1 = new HMS.Reservations.Controls.ctrlReservationInfo();
            this.SuspendLayout();
            // 
            // ctrlReservationInfo1
            // 
            this.ctrlReservationInfo1.BackColor = System.Drawing.Color.Silver;
            this.ctrlReservationInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlReservationInfo1.Location = new System.Drawing.Point(144, 95);
            this.ctrlReservationInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlReservationInfo1.Name = "ctrlReservationInfo1";
            this.ctrlReservationInfo1.Size = new System.Drawing.Size(994, 512);
            this.ctrlReservationInfo1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 1061);
            this.Controls.Add(this.ctrlReservationInfo1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Reservations.Controls.ctrlReservationInfo ctrlReservationInfo1;
    }
}