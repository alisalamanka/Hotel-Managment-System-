
using ClsGlobalClasses;
using HMS_Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace HMS.Services
{
    public partial class FrmManageServices : Form
    {
        private static DataTable _dtServices = ClsService.GetAllServices();

        private DataTable _ServicesTable = _dtServices.DefaultView.ToTable(
            false,
            "ServiceID",
            "ServiceName",
            "Status"
        );

        public FrmManageServices()
        {
            InitializeComponent();
        }

        private void _RefreshList()
        {
            _dtServices = ClsService.GetAllServices();

            _ServicesTable = _dtServices.DefaultView.ToTable(
                false,
                "ServiceID",
                "ServiceName",
                "Status"
            );

            DGVListServices.DataSource = _ServicesTable;

            LBLnumberOfservices.Text =
                _ServicesTable.Rows.Count.ToString();

        }


       

        private void btnAddNewRoom_Click(object sender, EventArgs e)
        {
            FrmAddEdditServiceInfo frm = new FrmAddEdditServiceInfo();
            frm.ShowDialog();

            _RefreshList();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmManageServices_Load(
            object sender, EventArgs e)
        {

         

            _RefreshList();

            CBfilterBy.SelectedIndex = 0;

            DGVListServices.Columns["ServiceID"].HeaderText =
                "Service ID";
            DGVListServices.Columns["ServiceID"].Width = 120;

            DGVListServices.Columns["ServiceName"].HeaderText =
                "Service Name";
            DGVListServices.Columns["ServiceName"].Width = 200;

            DGVListServices.Columns["Status"].HeaderText =
                "Status";
            DGVListServices.Columns["Status"].Width = 120;

            LBLnumberOfservices.Text =
                DGVListServices.Rows.Count.ToString();
        }

        

        
      

        private void txtFilterByValue_TextChanged(object sender, EventArgs e)
        {
            string FilterBy = CBfilterBy.Text.Trim();
            string FilterValue = txtFilterByValue.Text.Trim();

            _ServicesTable.DefaultView.RowFilter = "";

            if (FilterBy == "None")
                return;

            if (string.IsNullOrEmpty(FilterValue))
                return;

            switch (FilterBy)
            {
                case "Service ID":

                    if (int.TryParse(FilterValue, out int ServiceID))
                    {
                        _ServicesTable.DefaultView.RowFilter =
                            $"[ServiceID] = {ServiceID}";
                    }

                    break;

                case "Service Name":

                    

                    _ServicesTable.DefaultView.RowFilter =
                        $"[ServiceName] LIKE '%{FilterValue}%'";

                    break;
            }

            LBLnumberOfservices.Text =
                DGVListServices.Rows.Count.ToString();
        }

        private void btnAddNewRoom_Click_1(object sender, EventArgs e)
        {
            FrmAddEdditServiceInfo frm = new FrmAddEdditServiceInfo();
            frm.ShowDialog();

            _RefreshList();
        }

        private void TSMIaddNewService_Click(object sender, EventArgs e)
        {
            FrmAddEdditServiceInfo frm = new FrmAddEdditServiceInfo();
            frm.ShowDialog();

            _RefreshList();
        }

        private void TSMIeditRoomInfo_Click(object sender, EventArgs e)
        {
            if (DGVListServices.CurrentRow == null)
                return;

            int ServiceID = Convert.ToInt32(
                DGVListServices.CurrentRow.Cells["ServiceID"].Value);

            FrmAddEdditServiceInfo frm =
                new FrmAddEdditServiceInfo(ServiceID);

            frm.ShowDialog();

            _RefreshList();
        }

        private void TSMIshowdetails_Click_1(object sender, EventArgs e)
        {
            if (DGVListServices.CurrentRow == null)
                return;

            int ServiceID = Convert.ToInt32(
                DGVListServices.CurrentRow.Cells["ServiceID"].Value);

            FrmServiceDetails frm =
                new FrmServiceDetails(ServiceID);

            frm.ShowDialog();
        }

        private void CBfilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterByValue.Visible =
               CBfilterBy.Text != "None" &&
               CBfilterBy.Text != "Status";

            CBstatus.Visible =
                CBfilterBy.Text == "Status";

            _ServicesTable.DefaultView.RowFilter = "";

            if (txtFilterByValue.Visible)
            {
                txtFilterByValue.Text = "";
                txtFilterByValue.Focus();
            }

            
            LBLnumberOfservices.Text =
                DGVListServices.Rows.Count.ToString();
        }

        private void CBstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CBstatusValue = CBstatus.Text.Trim();
            if (CBstatusValue=="Active")
            {
                _ServicesTable.DefaultView.RowFilter = "Status like 'Active'";
            }
            else if (CBstatusValue=="InActive")
            {
                _ServicesTable.DefaultView.RowFilter = "Status like 'InActive'";

            }
            else
            {
                _ServicesTable.DefaultView.RowFilter = "";
            }
            LBLnumberOfservices.Text=DGVListServices.Rows.Count.ToString();
        }
    }
}
