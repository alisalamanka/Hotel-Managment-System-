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

namespace HMS.Users
{
    public partial class FrmChangePassword : Form
    {
        public FrmChangePassword(int UserId)
        {
            InitializeComponent();
            _UserID = UserId;
        }
        private int? _UserID = null;
        private Clsuser _CurrentUser = new Clsuser();



        private void _ResetForm()
        {

            txtCurrentPasssword.Text = "";
            txtNewPassword.Text = "";
            txtConfirmNewPassword.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCurrentPasssword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrentPasssword.Text))
            {
                InputsEP.SetError(txtCurrentPasssword, "Current Password Cannot Be Blanck!");
                e.Cancel = true;
            }
            else if (txtCurrentPasssword.Text.Trim() != _CurrentUser.Password)
            {
                InputsEP.SetError(txtNewPassword, "Current Password is Incorrect!");
                e.Cancel = true;
            }
            else
            {
                InputsEP.SetError(txtCurrentPasssword, "");
            }
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text))
            {
                InputsEP.SetError(txtNewPassword, "New Password Cannoot be blank!");
                e.Cancel = true;
            }
            else
            {
                InputsEP.SetError(txtNewPassword, "");
            }
        }

        private void txtConfirmNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmNewPassword.Text))
            {
                InputsEP.SetError(txtConfirmNewPassword, "Confirm New Password Cannot be blank!");
                e.Cancel = true;
            }
            else if (txtConfirmNewPassword.Text.Trim() != txtNewPassword.Text.Trim())
            {
                InputsEP.SetError(txtConfirmNewPassword, "Confirm New Password does not match with New Password!");
                e.Cancel = true;
            }
            else
            {
                InputsEP.SetError(txtConfirmNewPassword, "");
            }
        
        }

        private void FrmChangePassword_Load(object sender, EventArgs e)
        {
            _CurrentUser = Clsuser.Find(_UserID.Value);
            if (_CurrentUser!=null)
            {
                ctrlUserInfo1.LoadUserInfo(_UserID);
            }
            else
            {
                ClsUtil.ShowErrorMessage("Failed to load user info");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                ClsUtil.ShowErrorMessage("Some feilds are not valid Please fix the errors before save!");
                return;
            }
            _CurrentUser.Password = txtNewPassword.Text.Trim();
            bool ErrorOccoured = false;
            bool PasswordChanged = _CurrentUser.PasswordChanged(_CurrentUser.Password, ref ErrorOccoured);
            if (!PasswordChanged )
            {
                if (ErrorOccoured)
                {
                    ClsUtil.ShowErrorMessage("An error Occoured,Please check the event log!");
                    return;
                }
                else
                {
                    ClsUtil.ShowErrorMessage("Failed to change password,Please try again!");
                    return;
                }
            }
            else
            {
                ClsUtil.ShowSuccessMessage("Password Changed Successfully!");
                _ResetForm();
            }

        }
    }
    }

