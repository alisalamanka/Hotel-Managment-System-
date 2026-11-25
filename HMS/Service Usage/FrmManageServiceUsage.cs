using ClsGlobalClasses;
using HMS_Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace HMS.Service_Usage
{
    public partial class FrmManageServiceUsages : Form
    {
        private DataTable _dtServiceUsageList = new DataTable();

        public FrmManageServiceUsages()
        {
            InitializeComponent();

            // Manually connect events
            Load += FrmManageServiceUsages_Load;

            CBfilterBy.SelectedIndexChanged += CBfilterBy_SelectedIndexChanged;
            CBServiceUsageStatus.SelectedIndexChanged += CBServiceUsageStatus_SelectedIndexChanged;
            txtFilterByValue.TextChanged += txtFilterByValue_TextChanged;

            TSMIaddServiceUsage.Click += TSMIaddServiceUsage_Click;
            TSMIshowServiceusageInfo.Click += TSMIshowServiceUsageInfo_Click;
            TSMIeditinfo.Click += TSMIeditInfo_Click;
            TSMCancel.Click += TSMCancel_Click;
            btnClose.Click += btnClose_Click;
        }

        private void FrmManageServiceUsages_Load(object sender, EventArgs e)
        {
            CBServiceUsageStatus.Visible = false;
            txtFilterByValue.Visible = false;

            //_LoadStatusValues();
            _RefreshList();
        }

        private void _RefreshList()
        {
            _dtServiceUsageList = clsServiceUsage.GetAllServiceUsages();

            if (_dtServiceUsageList == null)
            {
                ClsUtil.ShowErrorMessage("Unable To Load Service Usages!");
                return;
            }

            DGVserviceusages.DataSource = _dtServiceUsageList;

            _ConfigureDGV();

            lblNumberOfServiceUsages.Text = DGVserviceusages.Rows.Count.ToString();
        }

        //private void _LoadStatusValues()
        //{
        //    CBServiceUsageStatus.Items.Clear();

        //    CBServiceUsageStatus.Items.Add("All");
        //    CBServiceUsageStatus.Items.Add("Active");
        //    CBServiceUsageStatus.Items.Add("Cancelled");

        //    CBServiceUsageStatus.SelectedIndex = 0;
        //}

        private void _ConfigureDGV()
        {
            if (DGVserviceusages.Columns.Count == 0)
                return;

            if (DGVserviceusages.Columns.Contains("ServiceUsageID"))
            {
                DGVserviceusages.Columns["ServiceUsageID"].HeaderText = "Usage ID";
                DGVserviceusages.Columns["ServiceUsageID"].Width = 85;
            }

            if (DGVserviceusages.Columns.Contains("StayID"))
            {
                DGVserviceusages.Columns["StayID"].HeaderText = "Stay ID";
                DGVserviceusages.Columns["StayID"].Width = 80;
            }

            if (DGVserviceusages.Columns.Contains("ServiceName"))
            {
                DGVserviceusages.Columns["ServiceName"].HeaderText = "Service Name";
                DGVserviceusages.Columns["ServiceName"].Width = 140;
            }

            if (DGVserviceusages.Columns.Contains("CostomerID"))
            {
                DGVserviceusages.Columns["CostomerID"].HeaderText = "Guest ID";
                DGVserviceusages.Columns["CostomerID"].Width = 85;
            }

            if (DGVserviceusages.Columns.Contains("GuestRoomID"))
            {
                DGVserviceusages.Columns["GuestRoomID"].HeaderText = "Room ID";
                DGVserviceusages.Columns["GuestRoomID"].Width = 85;
            }

            if (DGVserviceusages.Columns.Contains("EmployeeID"))
            {
                DGVserviceusages.Columns["EmployeeID"].HeaderText = "Employee ID";
                DGVserviceusages.Columns["EmployeeID"].Width = 95;
            }

            if (DGVserviceusages.Columns.Contains("ApplicationID"))
            {
                DGVserviceusages.Columns["ApplicationID"].HeaderText = "App ID";
                DGVserviceusages.Columns["ApplicationID"].Width = 80;
            }

            if (DGVserviceusages.Columns.Contains("Price"))
            {
                DGVserviceusages.Columns["Price"].HeaderText = "Price";
                DGVserviceusages.Columns["Price"].Width = 95;
                DGVserviceusages.Columns["Price"].DefaultCellStyle.Format = "N2";
            }

            if (DGVserviceusages.Columns.Contains("CreatedByUserID"))
            {
                DGVserviceusages.Columns["CreatedByUserID"].HeaderText = "Created By";
                DGVserviceusages.Columns["CreatedByUserID"].Width = 95;
            }

            if (DGVserviceusages.Columns.Contains("Status"))
            {
                DGVserviceusages.Columns["Status"].HeaderText = "Status";
                DGVserviceusages.Columns["Status"].Width = 95;
            }

            if (DGVserviceusages.Columns.Contains("Notes"))
            {
                DGVserviceusages.Columns["Notes"].HeaderText = "Notes";
                DGVserviceusages.Columns["Notes"].Width = 180;
            }
        }


        private void _ApplyFilter()
        {
            string FilterColumn = "";
            string FilterValue = txtFilterByValue.Text;

            switch (CBfilterBy.Text)
            {
                case "ServiceUsage ID":
                    FilterColumn = "ServiceUsageID";
                    break;

                case "Stay ID":
                    FilterColumn = "StayID";
                    break;

                case "Guest ID":
                    FilterColumn = "CostomerID";
                    break;

                case "Order ID":
                    FilterColumn = "ApplicationID";
                    break;

                case "Status":
                    FilterColumn = "Status";
                    break;

                default:

                    FilterColumn = "Null";
                    break;

            }


            if (FilterColumn == "Null")
            {
                _dtServiceUsageList.DefaultView.RowFilter = "";

            }

            else if (FilterColumn != "Status")
            {
                _dtServiceUsageList.DefaultView.RowFilter = string.Format("{0}={1}", FilterColumn, FilterValue);
            }
            else
            {
                switch (CBServiceUsageStatus.SelectedIndex)
                {
                    case 0:
                        _dtServiceUsageList.DefaultView.RowFilter = "";

                        break;
                    case 1:
                        _dtServiceUsageList.DefaultView.RowFilter = string.Format("{0} like '%{1}'", FilterColumn, "Confirmed");

                        break;
                    case 2:
                        _dtServiceUsageList.DefaultView.RowFilter = string.Format("{0} like '%{1}'", FilterColumn, "Cancelled");

                        break;
                    default:
                        _dtServiceUsageList.DefaultView.RowFilter = "";
                        break;
                }

            }


            lblNumberOfServiceUsages.Text = _dtServiceUsageList.DefaultView.Count.ToString();
        }

        private void CBfilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isStatusFilter = CBfilterBy.Text == "Status";

            CBServiceUsageStatus.Visible = isStatusFilter;
            txtFilterByValue.Visible = CBfilterBy.SelectedIndex != 0 && !isStatusFilter;

            txtFilterByValue.Clear();

            if (isStatusFilter)
            {
                if (CBServiceUsageStatus.Items.Count > 0)
                    CBServiceUsageStatus.SelectedIndex = 0;
            }
            else if (!isStatusFilter && CBfilterBy.SelectedIndex != 0)
            {
                txtFilterByValue.Focus();
            }

            _ApplyFilter();
        }

        private void txtFilterByValue_TextChanged(object sender, EventArgs e)
        {
            _ApplyFilter();
        }

        private void CBServiceUsageStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyFilter();
        }

        private int _GetSelectedServiceUsageID()
        {
            if (DGVserviceusages.CurrentRow == null)
            {
                ClsUtil.ShowErrorMessage("Please Select A Service Usage First!");
                return -1;
            }

            if (!DGVserviceusages.Columns.Contains("ServiceUsageID"))
            {
                ClsUtil.ShowErrorMessage("ServiceUsageID Column Was Not Found!");
                return -1;
            }

            object value = DGVserviceusages.CurrentRow.Cells["ServiceUsageID"].Value;

            if (value == null || value == DBNull.Value)
            {
                ClsUtil.ShowErrorMessage("Invalid Service Usage ID!");
                return -1;
            }

            return Convert.ToInt32(value);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TSMIaddServiceUsage_Click(object sender, EventArgs e)
        {
            frmAddEditServiceUsageInfo frm = new frmAddEditServiceUsageInfo();
            frm.ShowDialog();
            _RefreshList();
        }

        private void TSMIshowServiceUsageInfo_Click(object sender, EventArgs e)
        {
            int serviceUsageID = _GetSelectedServiceUsageID();
            if (serviceUsageID == -1)
                return;

            frmServiceUsageDetails frm = new frmServiceUsageDetails(serviceUsageID);
            frm.ShowDialog();
        }

        private void TSMIeditInfo_Click(object sender, EventArgs e)
        {
            int serviceUsageID = _GetSelectedServiceUsageID();
            if (serviceUsageID == -1)
                return;

            frmAddEditServiceUsageInfo frm = new frmAddEditServiceUsageInfo(serviceUsageID);
            frm.ShowDialog();
            _RefreshList();
        }

        private void TSMCancel_Click(object sender, EventArgs e)
        {
            int serviceUsageID = _GetSelectedServiceUsageID();
            if (serviceUsageID == -1)
                return;

            clsServiceUsage usage = clsServiceUsage.Find(serviceUsageID);
            if (usage == null)
            {
                ClsUtil.ShowErrorMessage($"No Service Usage Found With ID = {serviceUsageID}");
                return;
            }

            if (MessageBox.Show(
                "Are You Sure You Want To Cancel This Service Usage?",
                "Confirmation!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }

            if (usage.CancelServiceUsage())
            {
                ClsUtil.ShowSuccessMessage("Service Usage Cancelled Successfully!");
                _RefreshList();
            }
            else
            {
                ClsUtil.ShowErrorMessage("An Error Occurred While Cancelling The Service Usage!");
            }
        }

        private void btnAddServiceUsage_Click(object sender, EventArgs e)
        {
            frmAddEditServiceUsageInfo frm = new frmAddEditServiceUsageInfo();
            frm.ShowDialog();
            _RefreshList();
        }
    }
}