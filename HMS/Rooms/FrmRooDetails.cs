using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.Rooms
{
    public partial class FrmRooDetails : Form
    {
        private int _RoomID;
        public FrmRooDetails(int RoomID)
        {
            InitializeComponent();
            _RoomID = RoomID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRooDetails_Load(object sender, EventArgs e)
        {
            ctrlRoomInfo1.LoadRoomInfo(_RoomID);
        }
    }
}
