using Guna.UI2.WinForms;
using HMS.Employees;
using HMS.People;
using GlobalClasses;
using HMS.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMS_Business;

namespace HMS
{
    public partial class MainForm : Form
    {
        private FrmLogin _LoginForm = new FrmLogin();
        public MainForm(FrmLogin loginForm)
        {
            InitializeComponent();
            _LoginForm = loginForm;
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

        private void tsmiEmployees_Click(object sender, EventArgs e)
        {
            FrmManageEmployees frm = new FrmManageEmployees();
            frm.ShowDialog();
        }

        private void tsmiUsers_Click(object sender, EventArgs e)
        {
            FRMlistUsers frm = new FRMlistUsers();
            frm.ShowDialog();
        }

        private void TSMIshowcurrentUserInfo_Click(object sender, EventArgs e)
        {
            UserDetailsForm frm = new UserDetailsForm(CLSglobal.LoggedInUser.UserID);
            frm.ShowDialog();
        }

        private void TSMIchangePassword_Click(object sender, EventArgs e)
        {
            FrmChangePassword frm = new FrmChangePassword(CLSglobal.LoggedInUser.UserID.Value);
            frm.ShowDialog();
        }

        private void TSMIsignOut_Click(object sender, EventArgs e)
        {
            _LoginForm.Show();
            this.Hide();
        }
    }
}
