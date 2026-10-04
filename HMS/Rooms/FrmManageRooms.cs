using HMS_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.Rooms
{
    public partial class FrmManageRooms : Form
    {
        private static DataTable _dtRooms = ClsRoom.GetAllRooms();

        private DataTable _RoomsTable = _dtRooms.DefaultView.ToTable(
           false,
           "GuestRoomID",
           "RoomNumber",
           "RoomTypeName",
           "PricePerNight",
           "Status"
       );

        public FrmManageRooms()
        {
            InitializeComponent();
        }

        private void _RefreshList()
        {
            _dtRooms = ClsRoom.GetAllRooms();

            _RoomsTable = _dtRooms.DefaultView.ToTable(
                false,
                "GuestRoomID",
                "RoomNumber",
                "RoomTypeName",
                "PricePerNight",
                "Status"
            );

            DGVlistRooms.DataSource = _RoomsTable;

            LBLnumberOfRooms.Text =
                _RoomsTable.Rows.Count.ToString();
        }

        private void txtFilterByValue_TextChanged(object sender, EventArgs e)
        {
            string FilterBy = CBfilterBy.Text;
            string FilterValue = txtFilterByValue.Text.Trim();
           

            _RoomsTable.DefaultView.RowFilter = "";

            if (FilterBy == "None")
                return;

            if (string.IsNullOrEmpty(FilterValue))
                return;

            switch (FilterBy)
            {
                case "RoomID":

                    if (int.TryParse(FilterValue, out int RoomID))
                    {
                        _RoomsTable.DefaultView.RowFilter =
                            $"[GuestRoomID] = {RoomID}";
                    }

                    break;

                case "Room Number":

                    if (int.TryParse(FilterValue, out int RoomNumber))
                    {
                        _RoomsTable.DefaultView.RowFilter =
                            $"[RoomNumber] = {RoomNumber}";
                    }

                    break;

                case "Price Per Night":

                    if (decimal.TryParse(FilterValue, out decimal PricePerNight))
                    {
                        _RoomsTable.DefaultView.RowFilter =
                            $"[PricePerNight] = {PricePerNight}";
                    }

                    break;

                case "Status":

                    if (short.TryParse(FilterValue, out short status))
                    {
                        _RoomsTable.DefaultView.RowFilter =
                            $"[Status] = {status}";
                    }

                    break;
                    
            }
        }

        private void btnAddNewRoom_Click(object sender, EventArgs e)
        {
            FrmAddEditRoom AddRoom = new FrmAddEditRoom();
            AddRoom.ShowDialog();

            _RefreshList();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmManageRooms_Load(object sender, EventArgs e)
        {
            DGVlistRooms.DataSource = _RoomsTable;

            CBfilterBy.SelectedIndex = 0;

            LBLnumberOfRooms.Text =
                DGVlistRooms.Rows.Count.ToString();

            if (DGVlistRooms.Rows.Count >= 1)
            {
                DGVlistRooms.Columns[0].HeaderText = "Room ID";
                DGVlistRooms.Columns[0].Width = 100;

                DGVlistRooms.Columns[1].HeaderText = "Room Number";
                DGVlistRooms.Columns[1].Width = 120;

                DGVlistRooms.Columns[2].HeaderText = "Room Type";
                DGVlistRooms.Columns[2].Width = 150;

                DGVlistRooms.Columns[3].HeaderText = "Price Per Night";
                DGVlistRooms.Columns[3].Width = 150;

                DGVlistRooms.Columns[4].HeaderText = "Status";
                DGVlistRooms.Columns[4].Width = 120;
            }
        }

        private void CBfilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterByValue.Visible =
               (CBfilterBy.Text.ToLower() != "none" &&
                CBfilterBy.Text.ToLower() != "status");

            CBstatus.Visible =
                (CBfilterBy.Text == "Status");


            if (txtFilterByValue.Visible)
            {
                txtFilterByValue.Text = "";
                txtFilterByValue.Focus();
            }
        }

        private void CBstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CBstatus.Text.Trim())
            {
                case "Available":
                    _RoomsTable.DefaultView.RowFilter =
                        "[Status] = 1";
                    break;

                case "Reserved":
                    _RoomsTable.DefaultView.RowFilter =
                        "[Status] = 2";
                    break;

                case "Occupied":
                    _RoomsTable.DefaultView.RowFilter =
                        "[Status] = 3";
                    break;

                case "Cleaning":
                    _RoomsTable.DefaultView.RowFilter =
                        "[Status] = 4";
                    break;

                case "Maintenance":
                    _RoomsTable.DefaultView.RowFilter =
                        "[Status] = 5";
                    break;

                default:
                    _RoomsTable.DefaultView.RowFilter = "";
                    break;
            }
            LBLnumberOfRooms.Text =
               DGVlistRooms.RowCount.ToString();
        }

        private void TSMIshowdetails_Click(object sender, EventArgs e)
        {
            int RoomID = Convert.ToInt32(DGVlistRooms.CurrentRow.Cells[0].Value);
            FrmRoomDetails frm = new FrmRoomDetails(RoomID);
            frm.ShowDialog();

        }

        private void TSMIeditRoomInfo_Click(object sender, EventArgs e)
        {
            int RoomID = Convert.ToInt32(DGVlistRooms.CurrentRow.Cells[0].Value);
            FrmAddEditRoom frm = new FrmAddEditRoom(RoomID);
            frm.ShowDialog();
            _RefreshList();
        }

        private void TSMIaddNewRoom_Click(object sender, EventArgs e)
        {
            FrmAddEditRoom frm = new FrmAddEditRoom();
            frm.ShowDialog();
            _RefreshList();
        }
    }
}
