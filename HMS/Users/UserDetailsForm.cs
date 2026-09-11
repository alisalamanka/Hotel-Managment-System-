using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Guna.UI2.WinForms;
using System.Threading.Tasks;
using System.Windows.Forms;
using GlobalClasses;

namespace HMS.Users
{
    public partial class UserDetailsForm : Form
    {
        private int? _UserID= null;
        public UserDetailsForm(int? UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void UserDetailsForm_Load(object sender, EventArgs e)
        {
            if (_UserID!=null&&_UserID.HasValue)
            {
                ctrlUserInfo1.LoadUserInfo(_UserID);
            }
            else
            {
                ClsUtil.ShowErrorMessage("User ID is not provided or invalid!");
                this.Close();
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
