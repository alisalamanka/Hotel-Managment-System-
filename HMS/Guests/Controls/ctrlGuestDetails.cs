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
        int? _GuestID;
        ClsGuest CurrentGuestinfo = new ClsGuest();
        public ctrlGuestDetails()
        {
            InitializeComponent();
        }

        private void ctrlGuestDetails_Load(object sender, EventArgs e)
        {
          
        }

        public void LoadGuestInfo(int? GuestID)
        {
            _GuestID=GuestID;
            CurrentGuestinfo = ClsGuest.Find(_GuestID.Value);
            if (CurrentGuestinfo != null)
            {
                uCpersonCard1._LoadPersonInfo(CurrentGuestinfo.PersonInfo.Id.Value);
                lblGuestID.Text = CurrentGuestinfo.GuestID.ToString();
                lblIsActive.Text = CurrentGuestinfo.IsActive ? "Yes" : "No";
            }
            else
            {
                ClsUtil.ShowErrorMessage("Guest Not Found Or An error Occoured!");
                Reset();
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
