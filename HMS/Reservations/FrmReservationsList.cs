using ClsGlobalClasses;
using HMS_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.Reservations
{
    public partial class FrmReservationsList : Form
    {
        private int TotalPages = 0;
        private short PageSize = 10;
        private int CurrentPage = 1;
        private static DataTable _dtReservationList = ClsResevation.ReservationList();
        private DataTable _ReservationsTable = _dtReservationList.DefaultView.ToTable(
            false, "ReservationID", "CostomerID", "RoomID", "ReservationDate", "CostmerTypeName", "Status", "PlannedCheckIn", "PlannedCheckOut", "RoomTypeName"
            );
        private DataTable _dtCurrentPage = _dtReservationList.Clone();


        public FrmReservationsList()
        {
            InitializeComponent();
        }

        private void _LoadCurrentPage()
        {
           
            _dtCurrentPage.Rows.Clear();
            _dtCurrentPage = ClsResevation.ReservationListByPage(CurrentPage, PageSize);
            DGVReservations.DataSource = _dtCurrentPage;
            _ConfigureDGV();
            lblCurrentPage.Text=CurrentPage.ToString();
            _UpdatePaginationButtons();


        }

        private void _UpdatePaginationButtons()
        {
            btNext.Enabled = CurrentPage < TotalPages;
            btnPrevieus.Enabled = CurrentPage > 1;
        }

        private void _RefreshPagination()
        {
            TotalPages = TotalPages = (int)Math.Ceiling(
                (double)_dtReservationList.Rows.Count / PageSize);
            _LoadCurrentPage();
        }


        private void _RefreshList()
        {
            //_dtReservationList = ClsResevation.ReservationList();
            //  _ReservationsTable = _dtReservationList.DefaultView.ToTable(
            //false, "ReservationID", "CostomerID", "RoomID", "ReservationDate", "CostmerTypeName", "Status", "PlannedCheckIn", "PlannedCheckOut", "RoomTypeName"
            //);

            //DGVReservations.DataSource = _ReservationsTable;
            //lblNumberOfReservations.Text=_dtReservationList.Rows.Count.ToString();

            _dtReservationList = ClsResevation.ReservationList();

            lblNumberOfReservations.Text =
                _dtReservationList.Rows.Count.ToString();

            _RefreshPagination();

        }

        private void _ConfigureDGV()
        {
            if (DGVReservations.Columns.Count == 0)
                return;

            DGVReservations.Columns[0].HeaderText = "ReservationID";
            DGVReservations.Columns[0].Width = 100;

            DGVReservations.Columns[1].HeaderText = "Guest ID";
            DGVReservations.Columns[1].Width = 100;

            DGVReservations.Columns[2].HeaderText = "Room ID";
            DGVReservations.Columns[2].Width = 150;

            DGVReservations.Columns[3].HeaderText = "Reservation Date";
            DGVReservations.Columns[3].Width = 130;

            DGVReservations.Columns[4].HeaderText = "Guest Type";
            DGVReservations.Columns[4].Width = 120;

            DGVReservations.Columns[5].HeaderText = "Status";
            DGVReservations.Columns[5].Width = 110;

            DGVReservations.Columns[6].HeaderText = "Planned CheckIn";
            DGVReservations.Columns[6].Width = 120;

            DGVReservations.Columns[7].HeaderText = "Planned CheckOut";
            DGVReservations.Columns[7].Width = 120;

            DGVReservations.Columns[8].HeaderText = "Room Type";
            DGVReservations.Columns[8].Width = 110;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmReservationsList_Load(object sender, EventArgs e)
        {

            CBfilterBy.SelectedIndex = 0;

            _RefreshPagination();

            lblNumberOfReservations.Text =
                _dtReservationList.Rows.Count.ToString();

        
        }

        private void CBfilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBreservationStatus.Visible = CBfilterBy.SelectedIndex == 4;

            txtFilterByValue.Visible = (CBfilterBy.SelectedIndex != 0)&&CBreservationStatus.Visible==false;

            if (txtFilterByValue.Visible)
            {
                txtFilterByValue.Text = "";
                txtFilterByValue.Focus();
            }
        }

        private void txtFilterByValue_TextChanged(object sender, EventArgs e)
        {
            string ColumnName = "";
            switch (CBfilterBy.Text)
            {
                case "None":
                    ColumnName = "";
                    break;
                case "Reservation ID":
                    ColumnName = "ReservationID";
                    break;
                case "Room ID":
                    ColumnName = "RoomID";
                    break;
                case "Guest ID":
                    ColumnName = "CostomerID";
                    break;
                case "Status":
                    ColumnName = "Status";
                    break;
                default:
                    ColumnName = "";
                    break;
            }

            if ((ColumnName == "") || string.IsNullOrEmpty(txtFilterByValue.Text))
            {
                _dtCurrentPage.DefaultView.RowFilter = "";
                return;
            }
            else
            {

                switch (ColumnName)
                {
                    case "ReservationID":

                        if (int.TryParse(txtFilterByValue.Text, out int ResID))
                        {
                            _dtCurrentPage.DefaultView.RowFilter =
                                $"[ReservationID] = {ResID}";
                        }

                        break;

                    case "RoomID":

                        if (int.TryParse(txtFilterByValue.Text, out int RoomID))
                        {
                            _dtCurrentPage.DefaultView.RowFilter =
                                $"[RoomID] = {RoomID}";
                        }

                        break;

                    case "CostomerID":

                        if (int.TryParse(txtFilterByValue.Text, out int CustomerID))
                        {
                            _dtCurrentPage.DefaultView.RowFilter =
                                $"[CostomerID] = {CustomerID}";
                        }

                        break;

                    case "Status":

                        if (short.TryParse(txtFilterByValue.Text, out short status))
                        {
                            _dtCurrentPage.DefaultView.RowFilter =
                                $"[Status] = {status}";
                        }

                        break;
                }
            }
        }

        private void CBreservationStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CBreservationStatus.Text.Trim())
            {
                case "Pending":
                    _dtCurrentPage.DefaultView.RowFilter =
                        "[Status] = 1";
                    break;

                case "Confirmed":
                    _dtCurrentPage.DefaultView.RowFilter =
                        "[Status] = 2";
                    break;

                case "Cancelled":
                    _dtCurrentPage.DefaultView.RowFilter =
                        "[Status] = 3";
                    break;

                case "CheckedIn":
                    _dtCurrentPage.DefaultView.RowFilter =
                        "[Status] = 4";
                    break;

                case "CheckedOut":
                    _dtCurrentPage.DefaultView.RowFilter =
                        "[Status] = 5";
                    break;

                case "NoShow":
                    _dtCurrentPage.DefaultView.RowFilter =
                        "[Status] = 6";
                    break;
                default:
                    _dtCurrentPage.DefaultView.RowFilter = "";
                    break;
            }
            lblNumberOfReservations.Text =
               DGVReservations.RowCount.ToString();
        }

        private void btnAddNewReservation_Click(object sender, EventArgs e)
        {
            FrmAddEditReservation frm=new FrmAddEditReservation();
            frm.ShowDialog();
        }

        private void TSMIaddReservation_Click(object sender, EventArgs e)
        {
            FrmAddEditReservation frm = new FrmAddEditReservation();
            frm.ShowDialog();
        }

        private void TSMIshowReservationInfo_Click(object sender, EventArgs e)
        {
            int ResID = int.Parse(DGVReservations.CurrentRow.Cells[0].Value.ToString());
            FrmReservationDetails drm =new FrmReservationDetails(ResID);
            drm.ShowDialog();
        }

        private void TSMIeditinfo_Click(object sender, EventArgs e)
        {
            int ResID = int.Parse(DGVReservations.CurrentRow.Cells[0].Value.ToString());
            FrmAddEditReservation frm = new FrmAddEditReservation(ResID);
            frm.ShowDialog();
        }

        private void TSMCancel_Click(object sender, EventArgs e)
        {
            int ResID = int.Parse(DGVReservations.CurrentRow.Cells[0].Value.ToString());
            ClsResevation res =ClsResevation.Find(ResID);
            if (res!=null)
            {
                if (MessageBox.Show("Are You Sure You Want To Cancel This Reservation?",
                    "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (res.Cancel())
                    {
                        ClsUtil.ShowSuccessMessage("Reservation Cancelled Successfully!");
                        _RefreshList();
                }
                    else
                    {
                        ClsUtil.ShowSuccessMessage("An Error Occoured !");
                        return;
                    }
                }
                {
                    
                }
            }
            else
            {
                return;
            }
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            CurrentPage++;
            _LoadCurrentPage();
            lblCurrentPage.Text = CurrentPage.ToString();
        }

        private void btnPrevieus_Click(object sender, EventArgs e)
        {
            CurrentPage--;
            _LoadCurrentPage() ;
            lblCurrentPage.Text = CurrentPage.ToString();
        }
    }

}
