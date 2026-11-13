using System.Windows.Forms;

namespace HMS.Reservations.Controls
{
    public partial class ctrlReservationInfo : UserControl
    {
        private ClsReservation _Reservation;

        public ctrlReservationInfo()
        {
            InitializeComponent();
        }

        public void LoadReservationInfo(int reservationID)
        {
            _Reservation = ClsReservation.Find(reservationID);

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
            lblStayID.Text = _Reservation.ReservationID.ToString();

            lblGuestID.Text = _Reservation.GuestID.ToString();

            lblGuestRoomID.Text = _Reservation.RoomID.ToString();

            lblUserID.Text = _Reservation.UserID.ToString();

            lblReservationID.Text = _Reservation.ReservationID.ToString();

            lblGuestType.Text = _Reservation.GuestType.ToString();

            lblReservationDate.Text =
                _Reservation.ReservationDate.ToString("dd/MM/yyyy");

            lblPlannedCheckInDate.Text =
                _Reservation.PlannedCheckInDate.ToString("dd/MM/yyyy");

            lblPlannedCheckoutDate.Text =
                _Reservation.PlannedCheckOutDate.ToString("dd/MM/yyyy");

            lblPricePerNight.Text =
                _Reservation.PricePerNight.ToString("N2");

            lblTotalAMount.Text =
                _Reservation.TotalAmount.ToString("N2");

            lblStatus.Text = _Reservation.Status.ToString();

            lblNotes.Text =
                string.IsNullOrWhiteSpace(_Reservation.Notes)
                ? "No Notes"
                : _Reservation.Notes;

            // Number of guests
            guna2HtmlLabel3.Text =
                _Reservation.NumberOfGuests.ToString();
        }

        private void ResetReservationInfo()
        {
            lblStayID.Text = "????";
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

            guna2HtmlLabel3.Text = "????";

            _Reservation = null;
        }
    }
}
