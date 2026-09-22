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
            ClsGuest Guest = ClsGuest.Find(_GuestID.Value);
            if (Guest!=null)
            {
                ctrlGuestDetails1.LoadGuestInfo(_GuestID);
            }
            else
            {
                ClsUtil.ShowErrorMessage("Failed To Load Guest Info");
                return;
            }
        }
    }
}
