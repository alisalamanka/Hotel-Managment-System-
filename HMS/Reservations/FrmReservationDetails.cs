using System;
using System.Windows.Forms;

namespace HMS.Reservations
{
    public partial class FrmReservationDetails : Form
    {
        private int? ResID;
        public FrmReservationDetails(int ReservationID)
        {
            InitializeComponent();
            ResID = ReservationID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmReservationDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
