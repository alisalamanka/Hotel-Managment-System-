using ClsGlobalClasses;
using HMS_Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace HMS.Invoices
{
    public partial class FRMmanageInvoices : Form
    {
        private static DataTable _dtInvoiceList = ClsInvoice.GetAllInvoices();
        private DataTable _InvoicesTable = _dtInvoiceList.DefaultView.ToTable(
            false, "InvoiceID", "StayID", "IssueDate", "CreatedByUserID", "TotalAmount", "RamainingAmount", "status"
        );

        public FRMmanageInvoices()
        {
            InitializeComponent();

            // Manual Event Wiring
            this.Load += FRMmanageInvoices_Load;
            btnClose.Click += btnClose_Click;

            CBfilterBy.SelectedIndexChanged += CBfilterBy_SelectedIndexChanged;
            txtFilterByValue.TextChanged += txtFilterByValue_TextChanged;
            CBInvoiceStatus.SelectedIndexChanged += CBInvoiceStatus_SelectedIndexChanged;

            TSMIaddInvoice.Click += TSMIaddInvoice_Click;
            TSMIeditinfo.Click += TSMIeditinfo_Click;
            TSMIshowInvoiceInfo.Click += TSMIshowInvoiceInfo_Click;
            TSMCancel.Click += TSMCancel_Click;

            DGVInvoices.CellMouseDown += DGVInvoices_CellMouseDown;
        }

        private void _RefreshList()
        {
            _dtInvoiceList = ClsInvoice.GetAllInvoices();
            _InvoicesTable = _dtInvoiceList.DefaultView.ToTable(
                false, "InvoiceID", "StayID", "IssueDate", "CreatedByUserID", "TotalAmount", "RamainingAmount", "status"
            );

            DGVInvoices.DataSource = _InvoicesTable;
            _ConfigureDGV();
            lblNumberOfInvoices.Text = _InvoicesTable.Rows.Count.ToString();
        }

        private void _ConfigureDGV()
        {
            if (DGVInvoices.Columns.Count == 0)
                return;

            DGVInvoices.Columns[0].HeaderText = "Invoice ID";
            DGVInvoices.Columns[0].Width = 80;

            DGVInvoices.Columns[1].HeaderText = "Stay ID";
            DGVInvoices.Columns[1].Width = 80;

            DGVInvoices.Columns[2].HeaderText = "Issue Date";
            DGVInvoices.Columns[2].Width = 120;

            DGVInvoices.Columns[3].HeaderText = "Created By";
            DGVInvoices.Columns[3].Width = 100;

            DGVInvoices.Columns[4].HeaderText = "Total Amount";
            DGVInvoices.Columns[4].Width = 120;

            DGVInvoices.Columns[5].HeaderText = "Remaining Amount";
            DGVInvoices.Columns[5].Width = 120;

            DGVInvoices.Columns[6].HeaderText = "Status";
            DGVInvoices.Columns[6].Width = 100;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRMmanageInvoices_Load(object sender, EventArgs e)
        {
            CBfilterBy.SelectedIndex = 0;

            _RefreshList();
        }

        private void CBfilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBInvoiceStatus.Visible = (CBfilterBy.Text == "Status");

            txtFilterByValue.Visible = (CBfilterBy.SelectedIndex != 0) && (CBInvoiceStatus.Visible == false);

            if (txtFilterByValue.Visible)
            {
                txtFilterByValue.Text = "";
                txtFilterByValue.Focus();
            }

            _InvoicesTable.DefaultView.RowFilter = "";
            lblNumberOfInvoices.Text = DGVInvoices.RowCount.ToString();
        }

        private void txtFilterByValue_TextChanged(object sender, EventArgs e)
        {
            string ColumnName = "";
            switch (CBfilterBy.Text)
            {
                case "None":
                    ColumnName = "";
                    break;
                case "Invoice ID":
                case "InvoiceID":
                    ColumnName = "InvoiceID";
                    break;
                case "Stay ID":
                case "StayID":
                    ColumnName = "StayID";
                    break;
                case "User ID":
                    ColumnName = "CreatedByUserID";
                    break;
                case "Status":
                    ColumnName = "status";
                    break;
                default:
                    ColumnName = "";
                    break;
            }

            if ((ColumnName == "") || string.IsNullOrEmpty(txtFilterByValue.Text))
            {
                _InvoicesTable.DefaultView.RowFilter = "";
                lblNumberOfInvoices.Text = DGVInvoices.RowCount.ToString();
                return;
            }
            else
            {
                switch (ColumnName)
                {
                    case "InvoiceID":
                        if (int.TryParse(txtFilterByValue.Text, out int InvID))
                        {
                            _InvoicesTable.DefaultView.RowFilter =
                                $"[InvoiceID] = {InvID}";
                        }
                        break;

                    case "StayID":
                        if (int.TryParse(txtFilterByValue.Text, out int StayID))
                        {
                            _InvoicesTable.DefaultView.RowFilter =
                                $"[StayID] = {StayID}";
                        }
                        break;

                    case "CreatedByUserID":
                        if (int.TryParse(txtFilterByValue.Text, out int UserID))
                        {
                            _InvoicesTable.DefaultView.RowFilter =
                                $"[CreatedByUserID] = {UserID}";
                        }
                        break;

                    case "status":
                        if (short.TryParse(txtFilterByValue.Text, out short status))
                        {
                            _InvoicesTable.DefaultView.RowFilter =
                                $"[status] = {status}";
                        }
                        break;
                }
            }

            lblNumberOfInvoices.Text = DGVInvoices.RowCount.ToString();
        }

        private void CBInvoiceStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBInvoiceStatus.SelectedIndex <= 0)
            {
                _InvoicesTable.DefaultView.RowFilter = "";
            }
            else
            {
                _InvoicesTable.DefaultView.RowFilter =
                    $"[Status] like '{CBInvoiceStatus.Text}'";
            }

            lblNumberOfInvoices.Text = DGVInvoices.RowCount.ToString();
        }

        private void TSMIaddInvoice_Click(object sender, EventArgs e)
        {
            frmAddEditInvoice frm = new frmAddEditInvoice();
            frm.ShowDialog();
            _RefreshList();
        }

        private void TSMIshowInvoiceInfo_Click(object sender, EventArgs e)
        {
            int InvID = int.Parse(DGVInvoices.CurrentRow.Cells[0].Value.ToString());
            InvoiceDetailsForm frm = new InvoiceDetailsForm(InvID);
            frm.ShowDialog();
            _RefreshList();
        }

        private void TSMIeditinfo_Click(object sender, EventArgs e)
        {
            int InvID = int.Parse(DGVInvoices.CurrentRow.Cells[0].Value.ToString());
            frmAddEditInvoice frm = new frmAddEditInvoice(InvID);
            frm.ShowDialog();
            _RefreshList();
        }

        private void TSMCancel_Click(object sender, EventArgs e)
        {
            int InvID = int.Parse(DGVInvoices.CurrentRow.Cells[0].Value.ToString());
            ClsInvoice inv = ClsInvoice.Find(InvID);
            if (inv != null)
            {
                if (MessageBox.Show("Are You Sure You Want To Cancel This Invoice?",
                    "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (inv.DeleteInvoice())
                    {
                        ClsUtil.ShowSuccessMessage("Invoice Cancelled Successfully!");
                        _RefreshList();
                    }
                    else
                    {
                        ClsUtil.ShowErrorMessage("An Error Occoured !");
                        return;
                    }
                    _RefreshList();
                }
            }
            else
            {
                return;
            }
        }

        private void DGVInvoices_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                DGVInvoices.ClearSelection();
                DGVInvoices.Rows[e.RowIndex].Selected = true;
                DGVInvoices.CurrentCell = DGVInvoices.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        }
    }
}
