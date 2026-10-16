using ClsGlobalClasses;
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

namespace HMS.Reservations
{
    public partial class FrmAddEditReservation : Form
    {
        private int? _ResID;
        private ClsResevation _reservationInfo = new ClsResevation();
        private enum EnMode
        {
            Add=1,Update=2
        }
        private EnMode _mode;
        public FrmAddEditReservation()
        {
            InitializeComponent();
            _mode = EnMode.Add;
        }
        public FrmAddEditReservation(int ID)
        {
            InitializeComponent();
            _ResID = ID;
            _mode = EnMode.Update;
            _reservationInfo = ClsResevation.Find(_ResID.Value);
            if (_reservationInfo == null)
            {
                ClsUtil.ShowErrorMessage($"No Reservation with ID = {_ResID.Value}");
                return;
            }
        }

        private void _LoadDefaultValues()
        {
            CBguestType.DataSource = ClsGuestType.GetAllGuestTypes();
            CBguestType.DisplayMember = "GuestTypeName";
            CBguestType.ValueMember = "GuestTypeID";

            CBstatus.DataSource = Enum.GetValues(typeof(ClsResevation.EnStatus));
            
           
            DTPreservationDate.Enabled = false;
           

            switch (_mode)
            {
                case EnMode.Add:
                    {
                        lblTitle.Text = "Add New Reservation";
                        lblReservationID.Text = "";
                        txtGuestID.Text = "";
                        txtRoomNumber.Text = "";
                        txtUserID.Text = 2.ToString();
                        txtUserID.Enabled = false;
                        lblTotalAMount.Text = "0";
                        CBguestType.SelectedIndex = 1;
                        CBstatus.SelectedIndex = 1;
                        DTPplannedcheckIn.MinDate = DateTime.Now;
                        DTPPlannedCheckOut.MinDate = DateTime.Now;
                        DTPreservationDate.Value = DateTime.Now;
                        DTPplannedcheckIn.Value = DateTime.Now;
                        DTPPlannedCheckOut.Value = DateTime.Now;
                        NUDnumberOfGuests.Value = 1;
                        lblTotalAMount.Text = "0";
                        txtNotes.Text = "";
                        NUDnumberOfGuests.Minimum = 1;
                        NUDnumberOfGuests.Maximum = 7;
                    }
                    break;
                case EnMode.Update:
                    {
                        if (_reservationInfo!=null)
                        {
                            lblTitle.Text = "Update Reservation";
                            lblReservationID.Text = _reservationInfo.ReservationID.ToString();
                            txtGuestID.Text = _reservationInfo.GuestID.ToString();
                            txtRoomNumber.Text = _reservationInfo.RoomInfo.RoomNumber.ToString();
                            txtUserID.Text = _reservationInfo.UserID.ToString();
                            txtUserID.Enabled = false;
                            lblPricePerNight.Text = _reservationInfo.PricePerNight.ToString();
                            CBguestType.SelectedValue = _reservationInfo.GuestTypeID;
                            CBstatus.SelectedItem = (ClsResevation.EnStatus)_reservationInfo.Status;
                            DTPplannedcheckIn.Value = _reservationInfo.PlannedCheckin;
                            DTPreservationDate.Value = _reservationInfo.ReservationDate;
                            DTPPlannedCheckOut.Value = _reservationInfo.PlannedCheckOut;
                            NUDnumberOfGuests.Value = _reservationInfo.NumberOfGuests;
                            lblTotalAMount.Text = _reservationInfo.TotalAmount.ToString("C");
                            txtNotes.Text = _reservationInfo.Notes;
                        }
                    }
                    break;
            }
        }

        private void _FillNewInfo()
        {
            _reservationInfo.NumberOfGuests= (int)NUDnumberOfGuests.Value;
            _reservationInfo.GuestID = int.Parse(txtGuestID.Text);
            _reservationInfo.RoomID = ClsRoom.FindByRoomNumber(int.Parse(txtRoomNumber.Text)).GuestRoomID;
            _reservationInfo.GuestTypeID = (int)CBguestType.SelectedValue;
            _reservationInfo.PlannedCheckin = DTPplannedcheckIn.Value;
            _reservationInfo.PricePerNight=ClsRoom.Find(_reservationInfo.RoomID.Value).PricePerNight;
            _reservationInfo.PlannedCheckOut = DTPPlannedCheckOut.Value;
            _reservationInfo.Status=(int)(ClsResevation.EnStatus)CBstatus.SelectedItem;
            _reservationInfo.UserID=int.Parse(txtUserID.Text);
            _reservationInfo.Notes=txtNotes.Text;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddEditReservation_Load(object sender, EventArgs e)
         {
          
            _LoadDefaultValues();
        }

        private void DTPplannedcheckIn_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void DTPPlannedCheckOut_Validating(object sender, CancelEventArgs e)
        {
            if (DTPPlannedCheckOut.Value<=DTPplannedcheckIn.Value)
            {
                InputsEP.SetError(DTPPlannedCheckOut, "Planned CheckOut must be After Planed CheckIn");
                e.Cancel = true;
            }
            else
            {
                InputsEP.SetError(DTPPlannedCheckOut, "");
            }
        }

      

        private void txtGuestID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtGuestID.Text))
            {
                InputsEP.SetError(txtGuestID, "Guest ID Cannot Be Emplty!");
                e.Cancel= true;
            }
            else if(!ClsValidation.IsNumber(txtGuestID.Text))
            {
                InputsEP.SetError(txtGuestID, "Please enter a valid ID!");
                e.Cancel = true;
            }
            else if(ClsGuest.Find((int.Parse(txtGuestID.Text))) == null)
            {
                InputsEP.SetError(txtGuestID, $"No Guest With ID = {txtGuestID.Text}");
                e.Cancel = true;
            }
            else
                InputsEP.SetError(txtGuestID, "");

        }

        private void txtRoomNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtRoomNumber.Text))
            {
                InputsEP.SetError(txtRoomNumber, "Room Number Cannot Be Emplty!");
                e.Cancel = true;
            }
            else if (!ClsValidation.IsNumber(txtRoomNumber.Text))
            {
                InputsEP.SetError(txtRoomNumber, "Please enter a valid Number!");
                e.Cancel = true;
            }
            else if (ClsRoom.FindByRoomNumber((int.Parse(txtRoomNumber.Text))) == null)
            {
                InputsEP.SetError(txtRoomNumber, $"No Room With Number = {txtRoomNumber.Text}");
                e.Cancel = true;
            }
            else
                InputsEP.SetError(txtRoomNumber, "");

        }

        private void DTPPlannedCheckOut_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                ClsUtil.ShowErrorMessage("Please Fix The Errors Before Save!");
                return;
            }
            _FillNewInfo();
            bool ErrorOccourder =false;

            ClsResevation.EnStatus Status =(ClsResevation.EnStatus)CBstatus.SelectedItem;

            bool PerformCheckAvailability = _mode == EnMode.Add||( _mode == EnMode.Update &&
                (Status == ClsResevation.EnStatus.Pending || Status == ClsResevation.EnStatus.Confirmed));

            if (PerformCheckAvailability)
            {
                 if (!ClsResevation.IsRoomAvaible(_reservationInfo.RoomID.Value,_reservationInfo.PlannedCheckin,
                  _reservationInfo.PlannedCheckOut,ref ErrorOccourder,_reservationInfo.ReservationID))
            {
                if (ErrorOccourder)
                {
                    ClsUtil.ShowErrorMessage("An Error Occoured Please Show the EventLog Now!");
                    return;
                }
                ClsUtil.ShowErrorMessage("The Room is Not Available For The Selected Dates!");
                return;
            }
            }

            if (_reservationInfo.Save())
            {
                _mode = EnMode.Update;
                _ResID = _reservationInfo.ReservationID;
                _reservationInfo = ClsResevation.Find(_ResID.Value);
                ClsUtil.ShowSuccessMessage("Reservation Saved Successfully!");
                if (_mode == EnMode.Add)
                    lblReservationID.Text = _reservationInfo.ReservationID.ToString();
                lblTitle.Text = "Update Reservation";
                _reservationInfo.Mode = ClsResevation.EnMode.Update;
                lblPricePerNight.Text = _reservationInfo.PricePerNight.ToString("C");
                lblTotalAMount.Text = _reservationInfo.TotalAmount.ToString("C");
            }
            else
            {
                ClsUtil.ShowErrorMessage("Failed To save Reservation!");
                return ;
            }
        }

        private void CBguestType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CBguestType.SelectedIndex==4)
            {
                NUDnumberOfGuests.Value = 1;
                NUDnumberOfGuests.Enabled = false;
            }
            else
            {
                NUDnumberOfGuests.Enabled = true;
            }
        }

        private void CBstatus_Validating(object sender, CancelEventArgs e)
        {
            if (_mode==EnMode.Add)
            {
                ClsResevation.EnStatus SelectedStatus = (ClsResevation.EnStatus)CBstatus.SelectedItem;
                if (!(SelectedStatus==ClsResevation.EnStatus.Confirmed)&&
                    !(SelectedStatus ==(ClsResevation.EnStatus.Pending)))
                {
                    InputsEP.SetError(CBstatus, "Wrong Status For New Reservation!");
                    e.Cancel = true;
                }
                else
                {
                    InputsEP.SetError(CBstatus, "");

                }
            }
        }
    }
}
