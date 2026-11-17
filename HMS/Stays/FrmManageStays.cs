
using ClsGlobalClasses;
using HMS_Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace HMS.Stays
{
    public partial class FrmManageStays : Form
    {
        private DataTable _dtStayList = new DataTable();

        public FrmManageStays()
        {
            InitializeComponent();

            // Manually connect events
            Load += FrmManageStays_Load;

            CBfilterBy.SelectedIndexChanged += CBfilterBy_SelectedIndexChanged;
            CBStayStatus.SelectedIndexChanged += CBStayStatus_SelectedIndexChanged;
            txtFilterByValue.TextChanged += txtFilterByValue_TextChanged;

            TSMIaddStay.Click += TSMIaddStay_Click;
            TSMIshowStayInfo.Click += TSMIshowStayInfo_Click;
            TSMIeditinfo.Click += TSMIeditinfo_Click;
            TSMCancel.Click += TSMCancel_Click;
        }

        private void FrmManageStays_Load(object sender, EventArgs e)
        {
            // Configure Filter ComboBox
            CBfilterBy.Items.Clear();

            CBfilterBy.Items.AddRange(new object[]
            {
                "None",
                "Reservation ID",
                "Room Number",
                "Guest Name",
                "Status"
            });

            CBfilterBy.SelectedIndex = 0;

            CBStayStatus.Visible = false;
            txtFilterByValue.Visible = false;

            _RefreshList();
        }

        private void _RefreshList()
        {
            _dtStayList = ClsStay.GetAllStays();

            if (_dtStayList == null)
            {
                ClsUtil.ShowErrorMessage("Unable To Load Stays!");
                return;
            }

            _LoadStatusValues();

            DGVStays.DataSource = _dtStayList;

            _ConfigureDGV();

            lblNumberOfStays.Text = DGVStays.Rows.Count.ToString();
        }

        private void _LoadStatusValues()
        {
            CBStayStatus.Items.Clear();

            CBStayStatus.Items.Add("All");
            CBStayStatus.Items.Add("Active");
            CBStayStatus.Items.Add("Canceled");
            CBStayStatus.Items.Add("Completed");




            CBStayStatus.SelectedIndex = 0;
        }

        private void _ConfigureDGV()
        {
            if (DGVStays.Columns.Count == 0)
                return;


            DGVStays.Columns["StayID"].HeaderText = "Stay ID";
            DGVStays.Columns["StayID"].Width = 80;



            DGVStays.Columns["FirstName"].HeaderText = "First Name";
            DGVStays.Columns["FirstName"].Width = 110;



            DGVStays.Columns["LastName"].HeaderText = "Last Name";
            DGVStays.Columns["LastName"].Width = 110;



            DGVStays.Columns["RoomNumber"].HeaderText = "Room Number";
            DGVStays.Columns["RoomNumber"].Width = 100;



            DGVStays.Columns["ReservationID"].HeaderText = "Reservation ID";
            DGVStays.Columns["ReservationID"].Width = 100;



            DGVStays.Columns["ActualCheckIn"].HeaderText = "Actual Check In";
            DGVStays.Columns["ActualCheckIn"].Width = 120;


            DGVStays.Columns["ActualCheckOut"].HeaderText = "Actual Check Out";
            DGVStays.Columns["ActualCheckOut"].Width = 120;



            DGVStays.Columns["StatusText"].HeaderText = "Status";
            DGVStays.Columns["StatusText"].Width = 100;




            DGVStays.Columns["CreatedByUserID"].HeaderText = "Created By";
            DGVStays.Columns["CreatedByUserID"].Width = 100;




        }

        private void _ApplyFilter()
        {
            string Filter = "";

            // Filter by Status
            if (CBfilterBy.Text == "Status" &&
                CBStayStatus.SelectedIndex > 0)
            {
                string Status = CBStayStatus.Text.Replace("'", "''");

                Filter = $"[StatusText] = '{Status}'";
            }

            // Filter by selected value
            string Value = txtFilterByValue.Text.Trim();

            if (!string.IsNullOrEmpty(Value))
            {
                string ColumnFilter = "";

                switch (CBfilterBy.Text)
                {
                    case "Reservation ID":

                        if (int.TryParse(Value, out int ReservationID))
                        {
                            ColumnFilter =
                                $"[ReservationID] = {ReservationID}";
                        }

                        break;

                    case "Room Number":

                        if (int.TryParse(Value, out int RoomNumber))
                        {
                            ColumnFilter =
                                $"[RoomNumber] = {RoomNumber}";
                        }

                        break;

                    case "Guest Name":

                        Value = Value.Replace("'", "''");

                        ColumnFilter =
                            $"[FirstName] LIKE '%{Value}%' OR " +
                            $"[LastName] LIKE '%{Value}%'";

                        break;
                }

                if (!string.IsNullOrEmpty(ColumnFilter))
                {
                    if (string.IsNullOrEmpty(Filter))
                        Filter = ColumnFilter;
                    else
                        Filter += " AND (" + ColumnFilter + ")";
                }
            }

            _dtStayList.DefaultView.RowFilter = Filter;

            lblNumberOfStays.Text =
                _dtStayList.DefaultView.Count.ToString();
        }

        private void CBfilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool IsStatusFilter = CBfilterBy.Text == "Status";

            CBStayStatus.Visible = IsStatusFilter;

            txtFilterByValue.Visible =
                CBfilterBy.SelectedIndex != 0 && !IsStatusFilter;

            txtFilterByValue.Clear();

            if (IsStatusFilter)
            {
                if (CBStayStatus.Items.Count > 0)
                    CBStayStatus.SelectedIndex = 0;

                _ApplyFilter();
            }
            else if (CBfilterBy.Text == "None")
            {
                _ApplyFilter();
            }
            else
            {
                txtFilterByValue.Focus();
                _ApplyFilter();
            }
        }

        private void txtFilterByValue_TextChanged(object sender, EventArgs e)
        {
            _ApplyFilter();
        }

        private void CBStayStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyFilter();
        }

        private int _GetSelectedStayID()
        {
            if (DGVStays.CurrentRow == null)
            {
                ClsUtil.ShowErrorMessage("Please Select A Stay First!");
                return -1;
            }

            if (!DGVStays.Columns.Contains("StayID"))
            {
                ClsUtil.ShowErrorMessage("StayID Column Was Not Found!");
                return -1;
            }

            object Value = DGVStays.CurrentRow.Cells["StayID"].Value;

            if (Value == null || Value == DBNull.Value)
            {
                ClsUtil.ShowErrorMessage("Invalid Stay ID!");
                return -1;
            }

            return Convert.ToInt32(Value);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TSMIaddStay_Click(object sender, EventArgs e)
        {
            FrmAddEditStayInfo frm = new FrmAddEditStayInfo();

            frm.ShowDialog();

            _RefreshList();
        }

        private void TSMIshowStayInfo_Click(object sender, EventArgs e)
        {
            int StayID = _GetSelectedStayID();

            if (StayID == -1)
                return;

            FRMshowStayInfo frm = new FRMshowStayInfo(StayID);

            frm.ShowDialog();
        }

        private void TSMIeditinfo_Click(object sender, EventArgs e)
        {
            int StayID = _GetSelectedStayID();

            if (StayID == -1)
                return;

            FrmAddEditStayInfo frm = new FrmAddEditStayInfo(StayID);

            frm.ShowDialog();

            _RefreshList();
        }

        private void TSMCancel_Click(object sender, EventArgs e)
        {
            int StayID = _GetSelectedStayID();

            if (StayID == -1)
                return;

            ClsStay Stay = ClsStay.Find(StayID);

            if (Stay == null)
            {
                ClsUtil.ShowErrorMessage(
                    $"No Stay Found With ID = {StayID}");

                return;
            }

            if (MessageBox.Show(
                "Are You Sure You Want To Cancel This Stay?",
                "Confirmation!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }

            if (Stay.CancelStay())
            {
                ClsUtil.ShowSuccessMessage(
                    "Stay Cancelled Successfully!");

                _RefreshList();
            }
            else
            {
                ClsUtil.ShowErrorMessage(
                    "An Error Occurred While Cancelling The Stay!");
            }
        }

        private void FrmManageStays_Load_1(object sender, EventArgs e)
        {

        }

        private void TSMCancel_Click_1(object sender, EventArgs e)
        {

        }
    }
}
