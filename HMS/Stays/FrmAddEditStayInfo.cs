using ClsGlobalClasses;
using HMS_Business;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace HMS.Stays
{
    public partial class FrmAddEditStayInfo : Form
    {
        private int? _StayID;

        private ClsStay _StayInfo = new ClsStay();

        private enum EnMode
        {
            Add = 1,
            Update = 2
        }

        private EnMode _mode;
        public FrmAddEditStayInfo()
        {
            InitializeComponent();
            _mode = EnMode.Add;
        }
        public FrmAddEditStayInfo(int StayID)
        {
            InitializeComponent();
            _StayID = StayID;
            _StayInfo = ClsStay.Find(_StayID.Value);
            if (_StayInfo == null)
            {
                ClsUtil.ShowErrorMessage($"No Stay With ID {_StayID.Value}");
                return;
            }


            _mode = EnMode.Update;
        }

        private void _LoadDefaultValues()
        {
            CBstatus.DataSource =
                Enum.GetValues(typeof(ClsStay.EnStayStatus));
            DTPActualCheckOut.ShowCheckBox = true;

            switch (_mode)
            {
                case EnMode.Add:
                    {
                        lblTitle.Text = "Add New Stay";

                        lblStayID.Text = "????";

                        txtGuestID.Text = "";
                        txtRoomID.Text = "";
                        txtReservationID.Text = "";

                        txtUserID.Text = "2";
                        txtUserID.Enabled = false;

                        DTPACtualCheckIn.Value = DateTime.Now;
                        DTPActualCheckOut.Value = DateTime.Now;

                        CBstatus.SelectedItem =
                            ClsStay.EnStayStatus.Active;

                        txtNotes.Text = "";

                        break;
                    }

                case EnMode.Update:
                    {
                        if (_StayInfo != null)
                        {
                            lblTitle.Text = "Update Stay";

                            lblStayID.Text =
                                _StayInfo.StayID.ToString();

                            txtGuestID.Text =
                                _StayInfo.GuestID.ToString();

                            txtRoomID.Text =
                                _StayInfo.RoomID.ToString();

                            txtReservationID.Text =
                                _StayInfo.ReservationID.ToString();

                            txtUserID.Text =
                                _StayInfo.UserID.ToString();

                            txtUserID.Enabled = false;

                            DTPACtualCheckIn.Value =
                                _StayInfo.ActualCheckIn;

                            if (_StayInfo.ActualCheckOut.HasValue)
                            {
                                DTPActualCheckOut.Value =
                                    _StayInfo.ActualCheckOut.Value;
                            }

                            CBstatus.SelectedItem =
                                (ClsStay.EnStayStatus)_StayInfo.Status;

                            txtNotes.Text = _StayInfo.Notes;
                        }

                        break;
                    }
            }
        }

        private void _FillNewInfo()
        {
            _StayInfo.GuestID =
                int.Parse(txtGuestID.Text);

            _StayInfo.RoomID =
                int.Parse(txtRoomID.Text);

            _StayInfo.ReservationID =
                int.Parse(txtReservationID.Text);

            _StayInfo.UserID =
                int.Parse(txtUserID.Text);

            _StayInfo.ActualCheckIn =
                DTPACtualCheckIn.Value;

            _StayInfo.ActualCheckOut =
                DTPActualCheckOut.Checked
                ? DTPActualCheckOut.Value
                : (DateTime?)null;

            _StayInfo.Status =
                (short)(ClsStay.EnStayStatus)CBstatus.SelectedItem;

            _StayInfo.Notes = txtNotes.Text;
        }

        private void CBguestType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddEditStayInfo_Load(object sender, EventArgs e)
        {
            if (_mode == EnMode.Update && _StayInfo == null)
            {
                return;
            }
            _LoadDefaultValues();
        }

        private void txtUserID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserID.Text))
            {
                errorProvider1.SetError(txtUserID, "User ID Cannot Be Null");
                e.Cancel = true;
            }
            else if (!ClsValidation.IsNumber(txtUserID.Text))
            {
                errorProvider1.SetError(txtUserID, "Please Enter A Valid User ID!");
                e.Cancel = true;
            }
            else if (Clsuser.Find((int.Parse(txtUserID.Text))) == null)
            {

                errorProvider1.SetError(txtUserID, $"No User With ID = {txtUserID.Text}");
                e.Cancel = true;

            }
            else
            {
                errorProvider1.SetError(txtUserID, "");
            }
        }

        private void txtGuestID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtGuestID.Text))
            {
                errorProvider1.SetError(txtGuestID, "Guest ID Cannot Be Null");
                e.Cancel = true;
            }
            else if (!ClsValidation.IsNumber(txtGuestID.Text))
            {
                errorProvider1.SetError(txtGuestID, "Please Enter A Valid Guest ID!");
                e.Cancel = true;
            }
            else if (ClsGuest.Find(int.Parse(txtGuestID.Text)) == null)
            {
                errorProvider1.SetError(txtGuestID, $"No Guest With ID = {txtGuestID.Text}");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtGuestID, "");
            }
        }

        private void txtRoomID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtRoomID.Text))
            {
                errorProvider1.SetError(txtRoomID, "Room ID Cannot Be Null");
                e.Cancel = true;
            }
            else if (!ClsValidation.IsNumber(txtRoomID.Text))
            {
                errorProvider1.SetError(txtRoomID, "Please Enter A Valid Room ID!");
                e.Cancel = true;
            }
            else if (ClsRoom.Find(int.Parse(txtRoomID.Text)) == null)
            {
                errorProvider1.SetError(txtRoomID, $"No Room With ID = {txtRoomID.Text}");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtRoomID, "");
            }
        }

        private void txtReservationID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtReservationID.Text))
            {
                errorProvider1.SetError(txtReservationID, "Reservation ID Cannot Be Null");
                e.Cancel = true;
            }
            else if (!ClsValidation.IsNumber(txtReservationID.Text))
            {
                errorProvider1.SetError(txtReservationID, "Please Enter A Valid Reservation ID!");
                e.Cancel = true;
            }
            else if (ClsResevation.Find(int.Parse(txtReservationID.Text)) == null)
            {
                errorProvider1.SetError(txtReservationID, $"No Reservation With ID = {txtReservationID.Text}");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtReservationID, "");
            }
        }

        private void DTPActualCheckOut_Validating(object sender, CancelEventArgs e)
        {
            if (DTPActualCheckOut.Checked &&
        DTPActualCheckOut.Value <= DTPACtualCheckIn.Value)
            {
                errorProvider1.SetError(DTPActualCheckOut,
                    "Actual CheckOut Must Be After Actual CheckIn!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(DTPActualCheckOut, "");
            }
        }

        private void CBstatus_Validating(object sender, CancelEventArgs e)
        {
            if (CBstatus.SelectedItem == null)
            {
                errorProvider1.SetError(CBstatus, "Please Select A Status");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(CBstatus, "");

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                ClsUtil.ShowErrorMessage("Please Correct The Errors Before Save!");
                return;
            }

            _FillNewInfo();

            if (_StayInfo.Save())
            {
                _mode = EnMode.Update;

                _StayID = _StayInfo.StayID;

                _StayInfo.Mode = ClsStay.EnMode.Update;

                lblStayID.Text =
                    _StayInfo.StayID.ToString();

                lblTitle.Text = "Update Stay";

                ClsUtil.ShowSuccessMessage(
                    "Stay Saved Successfully!");
            }
            else
            {
                ClsUtil.ShowErrorMessage(
                    "Failed To Save Stay!");

                return;
            }
        }
    }
}
