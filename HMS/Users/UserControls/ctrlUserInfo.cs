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

namespace HMS.Users.UserControls
{
    public partial class ctrlUserInfo : UserControl
    {
        private Clsuser _CurrentUser= new Clsuser();
        private int? _userId=null;
        public ctrlUserInfo()
        {
            InitializeComponent();
        }

        private void _Reset()
        {
            uCpersonCard1.Clear();
            lblUserID.Text = "????";
            lblUserName.Text = "????";
            lblIsActive.Text = "????";
        }
        public void LoadUserInfo(int? userID)
        {
            _userId = userID;
            if (_userId.HasValue)
            {
                _CurrentUser = Clsuser.Find(_userId.Value);
                if (_CurrentUser != null)
                {
                    uCpersonCard1._LoadPersonInfo(_CurrentUser.PersonID.Value);
                    _FillUserInfo();
                }
                else
                {
                    ClsUtil.ShowErrorMessage("User not found or An Error Occured please check the event log!");
                    _Reset();
                }
            }
            else
            {
                ClsUtil.ShowErrorMessage("Invalid User ID provided!");
                return;
            }

        }

        private void _FillUserInfo()
        {
            lblUserID.Text = _CurrentUser.UserID.ToString();  
            lblUserName.Text = _CurrentUser.Username;
            lblIsActive.Text = _CurrentUser.isActive ? "Active" : "Inactive";
        }

        
    }
}
