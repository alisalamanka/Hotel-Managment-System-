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

namespace HMS.Guests.Controls
{
    public partial class ctrlGuestDetails : UserControl
    {
        int? GuestID;
        public ctrlGuestDetails(int? guestID)
        {
            InitializeComponent();
            GuestID = guestID;
        }

    

        private void ctrlGuestDetails_Load(object sender, EventArgs e)
        {
            ClsGuest guest = ClsGuest.Find(GuestID.Value);
            if (guest!=null)
            {
                uCpersonCard1._LoadPersonInfo(guest.PersonInfo.Id.Value);
                lblGuestID.Text=guest.GuestID.ToString();
                lblIsActive.Text = guest.IsActive ? "Yes" : "No";
            }
            else
            {
                ClsUtil.ShowErrorMessage("Guest Not Found Or An error Occoured!");
                return;
            }
        }

        public void Reset()
        {
            uCpersonCard1.Clear();
            lblGuestID.Text = "????";
            lblIsActive.Text = "????";
        }
    }
}
