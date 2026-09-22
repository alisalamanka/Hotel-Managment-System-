using GlobalClasses;
using HMS_Business;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace HMS.Guests
{
    public partial class FrmAddEditGuestForm : Form
    {
        public enum EnMode
        {
            AddNew = 0,
            Update = 1
        }

        public EnMode Mode;

        private int? _GuestID;

        public int? CurrentGuestID
        {
            get
            {
                return _GuestID;
            }
        }

        private ClsGuest _CurrentGuest = new ClsGuest();

        private event Action<int> OnGuestAdded;


        public FrmAddEditGuestForm()
        {
            InitializeComponent();

            Mode = EnMode.AddNew;
        }


        public FrmAddEditGuestForm(int GuestID)
        {
            InitializeComponent();

            _GuestID = GuestID;
            Mode = EnMode.Update;
        }


        protected void GuestAdded(int GuestID)
        {
            OnGuestAdded?.Invoke(GuestID);
        }


        private void _SetDefaultValues()
        {
            if (Mode == EnMode.AddNew)
            {
                lblGuestID.Text = "[????]";

                CBisActive.Checked = true;

                GBGuestInfo.Enabled = false;
                btnSave.Enabled = false;
                btnNext.Enabled = false;

                uCpersonCardWithFilter1.Clear();

                lblTitle.Text = "Add New Guest";
                this.Text = "Add New Guest";
            }
            else
            {
                _CurrentGuest = ClsGuest.Find(_GuestID.Value);

                if (_CurrentGuest != null)
                {
                    lblGuestID.Text =
                        _CurrentGuest.GuestID.Value.ToString();

                    lblTitle.Text = "Edit Guest";
                    this.Text = "Edit Guest";

                    CBisActive.Checked =
                        _CurrentGuest.IsActive;

                    uCpersonCardWithFilter1.LoadPersonInfo(
                        _CurrentGuest.PersonID.Value);

                    uCpersonCardWithFilter1.Enabled = false;

                    GBGuestInfo.Enabled = true;
                    btnSave.Enabled = true;
                    btnNext.Enabled = true;
                }
                else
                {
                    ClsUtil.ShowErrorMessage(
                        $"No Guest found with ID = {_GuestID}");

                    Close();
                }
            }
        }


     

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                ClsUtil.ShowErrorMessage(
                    "Some fields are not valid. Please fix the errors before Save.");

                return;
            }


            if (uCpersonCardWithFilter1.SelectedPersonID == null)
            {
                ClsUtil.ShowErrorMessage(
                    "Please select a person!");

                return;
            }


            _CurrentGuest.PersonID =
                uCpersonCardWithFilter1.SelectedPersonID;

            _CurrentGuest.IsActive =
                CBisActive.Checked;


            if (_CurrentGuest.Save())
            {
                _GuestID = _CurrentGuest.GuestID;

                lblGuestID.Text =
                    _CurrentGuest.GuestID.Value.ToString();

                lblTitle.Text = "Update Guest";
                this.Text = "Update Guest";

                Mode = EnMode.Update;

                uCpersonCardWithFilter1.Enabled = false;

                ClsUtil.ShowSuccessMessage(
                    "Guest Saved Successfully");
            }
            else
            {
                ClsUtil.ShowErrorMessage(
                    "Failed To Save This Guest!");
            }
        }

        private void uCpersonCardWithFilter1_Load(object sender, EventArgs e)
        {

        }

        private void FrmAddEditGuestForm_Load(object sender, EventArgs e)
        {
            _SetDefaultValues();

        }

        private void uCpersonCardWithFilter1_OnPersonSelected(int obj)
        {
            _CurrentGuest.PersonID = obj;

            btnNext.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bool ErrorOccurred = false;

            if (Mode != EnMode.AddNew)
                return;

            if (uCpersonCardWithFilter1.SelectedPersonID == null ||
                !uCpersonCardWithFilter1.SelectedPersonID.HasValue)
            {
                ClsUtil.ShowErrorMessage(
                    "Please select a person!");

                uCpersonCardWithFilter1.FilterFocus();

                return;
            }


            bool PersonHasGuest =
                ClsGuest.GuestExistsByPersonID(
                    uCpersonCardWithFilter1.SelectedPersonID.Value,
                    ref ErrorOccurred);


            if (ErrorOccurred)
            {
                ClsUtil.ShowErrorMessage(
                    "An Error Occurred! Please check the event log.");

                return;
            }


            if (PersonHasGuest)
            {
                ClsUtil.ShowErrorMessage(
                    "This Person is already a Guest. Please choose another person.");

                uCpersonCardWithFilter1.FilterFocus();

                return;
            }


            GBGuestInfo.Enabled = true;

            btnSave.Enabled = true;
        }
    }
}