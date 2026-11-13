using HMS_Business;
using System.Windows.Forms;

namespace HMS.Reservations.Controls
{
    public partial class ctrlReservationInfo : UserControl
    {
        private ClsResevation _Reservation;

        public ctrlReservationInfo()
        {
            InitializeComponent();
        }

        public void LoadReservationInfo(int reservationID)
        {

            if (_Reservation == null)
            {
                ResetReservationInfo();

                MessageBox.Show(
                    "No Reservation Found With ID = " + reservationID,
                    "Reservation Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            DisplayReservationInfo();
        }

        private void DisplayReservationInfo()
        {

            lblGuestID.Text = _Reservation.GuestID.ToString();

            lblGuestRoomID.Text = _Reservation.RoomID.ToString();

            lblUserID.Text = _Reservation.UserID.ToString();

            lblReservationID.Text = _Reservation.ReservationID.ToString();

            lblGuestType.Text = ClsGuestType.Find(GuestTypeID).GuestTypeName;

            lblReservationDate.Text =
                _Reservation.ReservationDate.ToString("dd/MM/yyyy");

            lblPlannedCheckInDate.Text =
                _Reservation.PlannedCheckin.ToString("dd/MM/yyyy");

            lblPlannedCheckoutDate.Text =
                _Reservation.PlannedCheckOut.ToString("dd/MM/yyyy");

            lblPricePerNight.Text =
                _Reservation.PricePerNight.ToString("N2");

            lblTotalAMount.Text =
                _Reservation.TotalAmount.ToString("N2");

            lblStatus.Text = _Reservation.Status.ToString();

            lblNotes.Text =
                string.IsNullOrWhiteSpace(_Reservation.Notes)
                ? "No Notes"
                : _Reservation.Notes;


        }

        private void ResetReservationInfo()
        {
            lblGuestID.Text = "????";
            lblGuestRoomID.Text = "????";
            lblUserID.Text = "????";
            lblReservationID.Text = "????";

            lblGuestType.Text = "????";
            lblReservationDate.Text = "????";

            lblPlannedCheckInDate.Text = "????";
            lblPlannedCheckoutDate.Text = "????";

            lblPricePerNight.Text = "????";
            lblTotalAMount.Text = "????";

            lblStatus.Text = "????";
            lblNotes.Text = "????";


            _Reservation = null;
        }
    }
}
