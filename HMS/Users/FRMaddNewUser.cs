using GlobalClasses;
using HMS.Users.UserControls;
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
    public partial class FRMaddNew_EditUser : Form
    {
        public enum EnMode
        {
            AddNew =0,Update=1
        }
        public EnMode Mode;
        private int? _UserID;
        public int? CurrentUserID
        {
            get
            {
                return _UserID;
            }
        }

        private Clsuser _CurrentUser=new Clsuser();

        private event Action<int> OnUserAdded;
        public FRMaddNew_EditUser()
        {
            InitializeComponent();
            Mode=EnMode.AddNew;
        }

        public FRMaddNew_EditUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            Mode = EnMode.Update;
        }

        protected void OnUseradded(int UserID)
        {
            OnUserAdded?.Invoke(UserID);
        }


        private void _SetDefaultValues()
        {
            if (Mode==EnMode.AddNew)
            {
                txtUserName.Text = "";
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";
                Tuserinfo.Enabled = false;
                btnSave.Enabled = false;
                uCpersonCardWithFilter1.Clear();
            }
            else
            {
                _CurrentUser = Clsuser.Find(_UserID.Value);
                if (_CurrentUser!=null)
                {
                    txtUserName.Text = _CurrentUser.Username;
                    txtPassword.Text= _CurrentUser.Password;
                    txtConfirmPassword.Text = _CurrentUser.Password;
                    lblUserID.Text = _CurrentUser.UserID.ToString();
                    lblTitle.Text = "Edit User";
                    this.Text = "Edit User";
                    CBactive.Checked = _CurrentUser.isActive;
                    uCpersonCardWithFilter1.LoadPersonInfo(_CurrentUser.PersonID.Value);
                    TPpersoninfo.Enabled = false;
                    btnSave.Enabled = true;
                    TBuser.SelectedTab = TBuser.TabPages["Tuserinfo"];
                }
            }
        }



        private void btnNext_Click(object sender, EventArgs e)
        {
            bool ErrorOccoured = false;
            if (Mode == EnMode.AddNew)
            {
                if (uCpersonCardWithFilter1.SelectedPersonID == null || !uCpersonCardWithFilter1.SelectedPersonID.HasValue)
                {
                    {
                        ClsUtil.ShowErrorMessage("Please select a person!");
                        uCpersonCardWithFilter1.FilterFocus();
                        return;
                    }
                }
                bool PersonHasUser = Clsuser.PersonHasAUser(uCpersonCardWithFilter1.SelectedPersonID.Value, ref ErrorOccoured);
                if (ErrorOccoured)
                {
                    ClsUtil.ShowErrorMessage("An Error Occoured !Please check the event log");
                    return;
                }
                else if (PersonHasUser)
                {
                    ClsUtil.ShowErrorMessage("This Person Is Used By Another User Please shose another one!");
                    return;
                }

                Tuserinfo.Enabled = true;
                TBuser.SelectedTab = TBuser.TabPages["Tuserinfo"];
                btnSave.Enabled = true;
            }
        }
        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            bool sqlErrorOccoured= false;
            string UserName = txtUserName.Text;
            if (string.IsNullOrEmpty(UserName))
            {
                InputsEP.SetError(txtUserName, "UserName is required!");
            }

        
            if (Clsuser.UserNameUsed(UserName, ref sqlErrorOccoured))
                {
                    InputsEP.SetError(txtUserName, "this UserName is Already used!");
                }
            else
                {
                    InputsEP.SetError(txtUserName, "");
                }

            

             if (sqlErrorOccoured)
            {
                InputsEP.SetError(txtUserName, "An Error Occoured,check the event Log!");
            }
            else
            {
                InputsEP.SetError(txtUserName, "");
            }

        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                InputsEP.SetError(txtPassword, "Password is required!");
            }
            else
            {
                InputsEP.SetError(txtPassword, "");
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text.Trim()!=txtConfirmPassword.Text.Trim())
            {
                InputsEP.SetError(txtConfirmPassword, "Password Confirmation does not match the password!");
            }
            else
            {
                InputsEP.SetError(txtConfirmPassword, "");
            }
        }

        private void uCpersonCardWithFilter1_OnPersonSelected(int obj)
        {
            _CurrentUser.PersonID = obj;
            btnNext.Enabled = true;
        }

        private void FRMaddNewUser_Load(object sender, EventArgs e)
        {
            _SetDefaultValues();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                ClsUtil.ShowErrorMessage("some feilds Are not Valid Please fix the errors before Save");
                return;
            }
            _CurrentUser.PersonID = uCpersonCardWithFilter1.SelectedPersonID;
            _CurrentUser.Username=txtUserName.Text;
            _CurrentUser.Password=txtPassword.Text;
            _CurrentUser.isActive=CBactive.Checked;
            if (_CurrentUser.save())
            {
                lblUserID.Text=_CurrentUser.UserID.Value.ToString();
                lblTitle.Text = "Update User ";
                this.Text = "Update User";
                Mode = EnMode.Update;
                TPpersoninfo.Enabled = false;
                ClsUtil.ShowSuccessMessage("User Saved Successfully");
            }
            else
            {
                ClsUtil.ShowErrorMessage("Failed To Save This User!");
            }
        }
    }
}
