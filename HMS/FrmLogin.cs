using GlobalClasses;
using HMS_Business;
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
    public partial class FrmLogin : Form
    {
        private Clsuser _LoggedInUser = new Clsuser();
        
        public FrmLogin()
        {
            InitializeComponent();
        }
        
        private void btnUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "UserName cannot be Blank!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Password cannot be Blank!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                ClsUtil.ShowErrorMessage("Some Feilds are not valid . Please correct them and try again.");
                return;
            }
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();
            _LoggedInUser = Clsuser.Find(username, password);
            if (_LoggedInUser!=null)
            {
                if (!_LoggedInUser.isActive)
                {
                    ClsUtil.ShowErrorMessage("This Account is Blocked For Now!");
                    txtUserName.Focus();
                    return;
                }
                if (CBrememberMe.Checked)
                {
                    CLSglobal.RememberUserNameAndPassword(username, password);
                }
                else
                {
                    CLSglobal.RememberUserNameAndPassword("", "");
                }
                this.Hide();
                CLSglobal.LoggedInUser = _LoggedInUser;
                MainForm frmMain = new MainForm(this);
                frmMain.ShowDialog();
            }
            else
            {
                ClsUtil.ShowErrorMessage("Invalid UserName or Password!");
                txtUserName.Focus();
                return;
            }
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            string UserName = "", password = "";
            CLSglobal.GetCurrentCredential(ref UserName, ref password);
            if (!string.IsNullOrEmpty(UserName)&&!string.IsNullOrEmpty(password))
            {
                txtPassword.Text = password;
                txtUserName.Text = UserName;
                CBrememberMe.Checked = true;
                
            }
           
        }
    }
}
