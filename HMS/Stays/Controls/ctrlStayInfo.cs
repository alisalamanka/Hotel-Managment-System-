
using HMS_Business;
using System.ComponentModel;
using System.Windows.Forms;

namespace HMS.Stays.Controls
{
    public partial class ctrlStayInfo : UserControl
    {
        private ClsStay _Stay;

        public ctrlStayInfo()
        {
            InitializeComponent();
        }

        public void LoadStayInfo(int stayID)
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                return;
            }
            _Stay = ClsStay.Find(stayID);

            if (_Stay == null)
            {
                ResetStayInfo();

                MessageBox.Show(
                    "No Stay Found With ID = " + stayID,
                    "Stay Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            DisplayStayInfo();
        }

        private void DisplayStayInfo()
        {
            lblStayID.Text = _Stay.StayID.ToString();

            lblGuestID.Text = _Stay.GuestID.ToString();

            lblGuestRoomID.Text = _Stay.RoomID.ToString();

            lblReservationID.Text = _Stay.ReservationID.ToString();

            lblUserID.Text = _Stay.UserID.ToString();

            lblActualCheckIn.Text =
                _Stay.ActualCheckIn.ToString("dd/MM/yyyy");

            lblActualCheckOut.Text =
                _Stay.ActualCheckOut.HasValue
                ? _Stay.ActualCheckOut.Value.ToString("dd/MM/yyyy")
                : "Not Checked Out";

            lblStatus.Text = ClsStay.GetStatusString(_Stay.Status);

            lblNotes.Text =
                string.IsNullOrWhiteSpace(_Stay.Notes)
                ? "No Notes"
                : _Stay.Notes;
        }

        private void ResetStayInfo()
        {
            lblStayID.Text = "????";
            lblGuestID.Text = "????";
            lblGuestRoomID.Text = "????";
            lblReservationID.Text = "????";
            lblUserID.Text = "????";

            lblActualCheckIn.Text = "????";
            lblActualCheckOut.Text = "????";

            lblStatus.Text = "????";
            lblNotes.Text = "????";

            _Stay = null;
        }
    }
}
