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

namespace HMS.Guests
{
    public partial class FrmGuestDetails : Form
    {
        private int? _GuestID;
        public FrmGuestDetails(int? GuestID)
        {
            InitializeComponent();
            _GuestID = GuestID;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmGuestDetails_Load(object sender, EventArgs e)
        {
            bool ErrorOcoured = false;
            bool Exists = ClsGuest.GuestExistsByID(_GuestID.Value, ref ErrorOcoured);
            if (ErrorOcoured)
            {
                ClsUtil.ShowErrorMessage("An Error Occoured Please Show the Event Log!");
                return;
            }
            if (!Exists)
            {
                ClsUtil.ShowErrorMessage($"No Guest With Id = {_GuestID.Value}");
                return;
            }
            else
            {
                ctrlGuestDetails1.LoadGuestInfo(_GuestID);
            }
        }
    }
}
