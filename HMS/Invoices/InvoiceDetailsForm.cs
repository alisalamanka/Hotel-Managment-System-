using System;
using System.Windows.Forms;

namespace HMS.Invoices
{
    public partial class InvoiceDetailsForm : Form
    {
        private int _ID;
        public InvoiceDetailsForm(int InvoiceID)
        {
            InitializeComponent();
            _ID = InvoiceID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InvoiceDetailsForm_Load(object sender, EventArgs e)
        {
            ctrlInvoiceInfo1.LoadInvoiceInfo(_ID);
        }
    }
}
