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

namespace HMS.Rooms.Controls
{
    public partial class ctrlRoomInfo : UserControl
    {
        ClsRoom _CurrentRoom;
        public ctrlRoomInfo()
        {
            InitializeComponent();
        }
        private void _FillRoomInfo()
        {
            lblRoomID.Text = _CurrentRoom.GuestRoomID.ToString();
            lblRoomNumber.Text=_CurrentRoom.RoomNumber.ToString();
            lblRoomType.Text=_CurrentRoom.RoomTypeInfo.RoomTypeName.ToString();
            lblStatus.Text = ClsRoom.GetStatusString((ClsRoom.EnRoomStatus)_CurrentRoom.Status);
            lblPricePerNight.Text = _CurrentRoom.PricePerNight.ToString() + "$";

        }

        public void Reset()
        {
            lblPricePerNight.Text = "[????]";
            lblRoomID.Text = "[????]";
            lblRoomNumber.Text = "[????]";
            lblRoomType.Text = "[????]";
            lblStatus.Text = "[????]";
        }

        public void LoadRoomInfo(int RoomID)
        {
            _CurrentRoom = ClsRoom.Find(RoomID);
            if (_CurrentRoom==null)
            {
                ClsUtil.ShowErrorMessage($"No Room With ID = {RoomID}");
                Reset();
                return;
            }
            _FillRoomInfo();
        }

        public void LoadRoomInfoByNumber(int RoomNumber)
        {
            _CurrentRoom = ClsRoom.FindByRoomNumber(RoomNumber);
            if (_CurrentRoom == null)
            {
                ClsUtil.ShowErrorMessage($"No Room With Number = {RoomNumber}");
                Reset();
                return;
            }
            _FillRoomInfo();
        }

    }
}
