using ClsGlobalClasses;
using HMS_Business;
using System.Windows.Forms;

namespace HMS.Invoices
{
    public partial class ctrlInvoiceInfo : UserControl
    {
        public ctrlInvoiceInfo()
        {
            InitializeComponent();
        }

        private ClsInvoice _InvoiceInfo = new ClsInvoice();

        private void _FillInvoiceInfo()
        {
            lblinvoiceID.Text = _InvoiceInfo.InvoiceID.ToString();
            lblIssueDate.Text = _InvoiceInfo.IssueDate.ToString();
            lblTotalAmount.Text = _InvoiceInfo.TotalAmount.ToString();
            lblRemainingAmount.Text = _InvoiceInfo.RemainingAmount.ToString();
            lblStayID.Text = _InvoiceInfo.StayID.ToString();
            lblStatus.Text = ClsInvoice.GetStatusString(_InvoiceInfo.Status);
            lblUserID.Text = _InvoiceInfo.UserID.ToString();

        }

        public void Clear()
        {
            lblinvoiceID.Text = "????";
            lblIssueDate.Text = "????";
            lblTotalAmount.Text = "????";
            lblRemainingAmount.Text = "????";
            lblStayID.Text = "????";
            lblStatus.Text = "????";
            lblUserID.Text = "????";

        }

        public void LoadInvoiceInfo(int invoiceID)
        {
            _InvoiceInfo = ClsInvoice.Find(invoiceID);
            if (_InvoiceInfo == null)
            {
                ClsUtil.ShowErrorMessage($"No Invoice With ID = {invoiceID}");
                return;
            }
            else
            {
                _FillInvoiceInfo();
            }
        }
    }
}
