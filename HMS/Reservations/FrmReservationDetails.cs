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
            ctrlReservationInfo1.LoadReservationInfo(ResID.Value);

        }
    }
}
