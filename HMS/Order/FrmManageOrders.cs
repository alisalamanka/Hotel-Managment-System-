using ClsGlobalClasses;
using HMS_Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace HMS.Order
{
    public partial class FrmManageOrders : Form
    {
        private static short TotalPages = 0;

        private static short PageSize = 10;

        private static short CurrentPage = 1;

        private static DataTable _dtOrderList = ClsOrder.GetOrdersPerPage(CurrentPage, PageSize);

        private static DataTable _dtCurrentPage = new DataTable();

        public FrmManageOrders()
        {
            InitializeComponent();
        }
        private void _UpdatePaginationButtons()
        {
            btNext.Enabled = CurrentPage < TotalPages;

            btnPrevieus.Enabled = CurrentPage > 1;
        }

        //private void _RefreshList()
        //{
        //    _dtOrderList = ClsOrder.OrderList();

        //    lblNumberOfOrders.Text =
        //        _dtOrderList.Rows.Count.ToString();

        //    CurrentPage = 1;

        //    _RefreshPagination();
        //}
        private void _RefreshPagination()
        {
            TotalPages = (short)Math.Ceiling(
                (double)_dtOrderList.Rows.Count / PageSize);

            if (TotalPages > 0 && CurrentPage > TotalPages)
                CurrentPage = TotalPages;

            if (TotalPages == 0)
                CurrentPage = 1;

            _LoadCurrentPage();
        }

        private void _LoadCurrentPage()
        {
            _dtCurrentPage.Rows.Clear();

            _dtCurrentPage = ClsOrder.GetOrdersPerPage(
                CurrentPage, PageSize);

            DGVorders.DataSource = _dtCurrentPage;

            _ConfigureDGV();

            lblCurrentPage.Text =
                TotalPages == 0 ? "0" : CurrentPage.ToString();

            _UpdatePaginationButtons();
        }

        private void _ConfigureDGV()
        {
            if (DGVorders.Columns.Count == 0)
                return;

            DGVorders.Columns[0].HeaderText = "Order ID";
            DGVorders.Columns[0].Width = 120;

            DGVorders.Columns[1].HeaderText = "Order Type Name";
            DGVorders.Columns[1].Width = 150;

            DGVorders.Columns[2].HeaderText = "User ID";
            DGVorders.Columns[2].Width = 120;

            DGVorders.Columns[3].HeaderText = "Order Date";
            DGVorders.Columns[3].Width = 200;

            DGVorders.Columns[4].HeaderText = "Status";
            DGVorders.Columns[4].Width = 150;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewReservation_Click(object sender, EventArgs e)
        {
            FrmAddEditOrder frm = new FrmAddEditOrder();
            frm.ShowDialog();
            _LoadCurrentPage();

        }

        private void FrmManageOrders_Load(object sender, EventArgs e)
        {
            txtFilterByValue.Visible = false;
            CBorderStatus.Visible = false;
            _dtCurrentPage = _dtOrderList.Clone();
            _RefreshPagination();

            lblNumberOfOrders.Text =
                _dtOrderList.Rows.Count.ToString();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            if (CurrentPage < TotalPages)
            {
                CurrentPage++;

                _LoadCurrentPage();
            }
        }

        private void btnPrevieus_Click(object sender, EventArgs e)
        {
            if (CurrentPage > 1)
            {
                CurrentPage--;

                _LoadCurrentPage();
            }
        }

        private void CBfilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBorderStatus.Visible = CBfilterBy.SelectedIndex == 4;

            txtFilterByValue.Visible =
                (CBfilterBy.SelectedIndex != 0) &&
                CBorderStatus.Visible == false;

            if (txtFilterByValue.Visible)
            {
                txtFilterByValue.Text = "";
                txtFilterByValue.Focus();
            }
        }

        private void txtFilterByValue_TextChanged(object sender, EventArgs e)
        {
            string ColumnName = "";
            string FilterValue = txtFilterByValue.Text;


            switch (CBfilterBy.Text)
            {
                case "None":
                    ColumnName = "";
                    break;

                case "OrderID":
                    ColumnName = "OrderID";
                    break;

                case "Order Type":
                    ColumnName = "ordertypename";
                    break;

                case "User ID":
                    ColumnName = "UserID";
                    break;

                default:
                    ColumnName = "";
                    break;
            }

            if ((ColumnName == "") ||
                string.IsNullOrEmpty(FilterValue))
            {
                _dtCurrentPage.DefaultView.RowFilter = "";
                return;
            }
            else
            {
                switch (ColumnName)
                {
                    case "OrderID":

                        if (int.TryParse(FilterValue, out int OrderID))
                        {
                            _dtCurrentPage.DefaultView.RowFilter =
                                $"[OrderID] = {OrderID}";
                        }

                        break;

                    case "ordertypename":


                        _dtCurrentPage.DefaultView.RowFilter =
                            $"[ordertypename] like '%{FilterValue}'";


                        break;

                    case "UserID":

                        if (int.TryParse(FilterValue, out int UserID))
                        {
                            _dtCurrentPage.DefaultView.RowFilter =
                                $"[UserID] = {UserID}";
                        }

                        break;
                }
            }

            lblNumberOfOrders.Text = DGVorders.RowCount.ToString();
        }

        private void CBorderStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CBorderStatus.Text.Trim())
            {
                case "Pending":

                    _dtCurrentPage.DefaultView.RowFilter =
                        "[StatusSTring] like  '%Pending'";

                    break;

                case "Completed":

                    _dtCurrentPage.DefaultView.RowFilter =
                        "[StatusSTring] like '%Completed' ";

                    break;

                case "Canceled":

                    _dtCurrentPage.DefaultView.RowFilter =
                        "[StatusSTring] like '%Canceled'";

                    break;

                default:

                    _dtCurrentPage.DefaultView.RowFilter = "";

                    break;
            }

            lblNumberOfOrders.Text = DGVorders.RowCount.ToString();
        }

        private void TSMISHoworderInfo_Click(object sender, EventArgs e)
        {
            int ID = (int)DGVorders.CurrentRow.Cells[0].Value;
            FrmShowOrderInfo frm = new FrmShowOrderInfo(ID);
            frm.ShowDialog();
        }

        private void TSMIeditinfo_Click(object sender, EventArgs e)
        {
            int ID = (int)DGVorders.CurrentRow.Cells[0].Value;
            FrmAddEditOrder frm = new FrmAddEditOrder(ID);
            frm.ShowDialog();
            _LoadCurrentPage();

        }

        private void TSMCancel_Click(object sender, EventArgs e)
        {
            int ID = (int)DGVorders.CurrentRow.Cells[0].Value;
            ClsOrder order = ClsOrder.Find(ID);
            if (order.CancelOrder())
            {
                ClsUtil.ShowSuccessMessage("Order Canceled Successfully!");
                _LoadCurrentPage();

                return;
            }
            else
            {
                ClsUtil.ShowErrorMessage("failed to Cancel This Order!");
                return;
            }
        }
    }
}


