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

namespace HMS.Reservations.Controls
{
    public partial class ctrlReservationInfo : UserControl
    {
        private int? ReservationID;
        private ClsResevation ReservationInfo = new ClsResevation();
        public ctrlReservationInfo()
        {
            InitializeComponent();
        }
        private void _FillReservationInfo()
        {
            lblResID.Text = ReservationInfo.ReservationID.ToString();
            lblUserID.Text = ReservationInfo.UserID.ToString();
            lblGuestID.Text = ReservationInfo.GuestID.ToString();
            lblRoomID.Text = ReservationInfo.RoomID.ToString();
            lblGuestType.Text =ClsGuestType.Find(ReservationInfo.GuestTypeID.Value).GuestTypeName;
            lblNotes.Text = ReservationInfo.Notes;
            lblNumberOfGuests.Text = ReservationInfo.NumberOfGuests.ToString();
            lblReservationDate.Text = ReservationInfo.ReservationDate.ToShortDateString();
            lblPlannedCheckIn.Text = ReservationInfo.PlannedCheckin.ToShortDateString();
            lblPlannedCheckOut.Text = ReservationInfo.PlannedCheckOut.ToShortDateString();
            lblPricePerNight.Text = ReservationInfo.PricePerNight.ToString("C");
            lblTotalAmount.Text = ReservationInfo.TotalAmount.ToString("C");
            lblStatus.Text=ReservationInfo.GetStatusString();

        }

        public void Clear()
        {
            lblGuestID.Text = "[????]";
            lblGuestType.Text = "[????]";
            lblNotes.Text = "[????]";
            lblNumberOfGuests.Text = "[????]";
            lblPlannedCheckIn.Text = "[????]";
            lblPlannedCheckOut.Text = "[????]";
            lblPricePerNight.Text = "[????]";
            lblReservationDate.Text = "[????]";
            lblResID.Text = "[????]";
            lblRoomID.Text = "[????]";
            lblStatus.Text = "[????]";
            lblTotalAmount.Text = "[????]";
            lblUserID.Text = "[????]";
        }

        public void LoadReservationInfo(int ReservationID)
        {
            this.ReservationID = ReservationID;
            ReservationInfo =  ClsResevation.Find(ReservationID);
            if (ReservationInfo!=null)
            {
                _FillReservationInfo();
            }
            else
            {
                ClsUtil.ShowErrorMessage($"No Reservation With ID {ReservationID}");
                return;
            }
        }
    }
}
