using Guna.UI2.WinForms;
using HMS.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnHover(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            btn.FillColor = Color.White;
            btn.ForeColor = Color.FromArgb(24, 26, 29);
        }

        private void btnexit(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            btn.FillColor = Color.FromArgb(24, 26, 29);
            btn.ForeColor = Color.White;
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void TSMIpersons_Click(object sender, EventArgs e)
        {
            FrmManagePersons frm = new FrmManagePersons();
            frm.ShowDialog();
        }
    }
}
