using ClsGlobalClasses;
using HMS_Business;
using System;
using System.Windows.Forms;

namespace HMS.Invoices
{
    public partial class frmAddEditInvoice : Form
    {
        private int _InvoiceID;
        private ClsInvoice _InvoiceInfo = new ClsInvoice();

        private enum _ENMode
        {
            Add = 1, Edit = 2
        }
        private _ENMode Mode;

        private void _LoadDefaultValues()
        {
            txtRemainingAmount.Enabled = false;
            txtTotalAmount.Enabled = false;
            CBstatus.Enabled = false;
            switch (Mode)
            {

                case _ENMode.Add:
                    {
                        lblTitle.Text = "Add New Invoice";
                        txtRemainingAmount.Text = "0";
                        txtStayID.Text = "????";
                        txtTotalAmount.Text = "0";
                        //txtUserID.Text =CLSglobal.LoggedInUser.UserID.ToString();
                        txtUserID.Text = "2";
                        DTPissueDate.Value = DateTime.Now;
                        DTPissueDate.Enabled = false;

                        CBstatus.SelectedIndex = 0;
                    }
                    break;
                case _ENMode.Edit:
                    {
                        lblTitle.Text = "Update Invoice";
                        lblInvoiceID.Text = _InvoiceInfo.InvoiceID.ToString();
                        DTPissueDate.Value = _InvoiceInfo.IssueDate;
                        txtRemainingAmount.Text = _InvoiceInfo.RemainingAmount.ToString();
                        txtStayID.Text = _InvoiceInfo.StayID.ToString();
                        txtTotalAmount.Text = _InvoiceInfo.TotalAmount.ToString();
                        txtUserID.Text = _InvoiceInfo.UserID.ToString();
                        CBstatus.SelectedIndex = (short)_InvoiceInfo.Status - 1;
                    }
                    break;
            }
        }

        private void _ReadNewInfo()
        {
            _InvoiceInfo.StayID = int.Parse(txtStayID.Text);
            _InvoiceInfo.UserID = int.Parse(txtUserID.Text);
            _InvoiceInfo.IssueDate = DTPissueDate.Value;
        }


        public frmAddEditInvoice()
        {
            InitializeComponent();
            Mode = _ENMode.Add;
        }
        public frmAddEditInvoice(int ID)
        {
            InitializeComponent();
            _InvoiceID = ID;
            _InvoiceInfo = ClsInvoice.Find(_InvoiceID);
            Mode = _ENMode.Edit;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserID_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserID.Text))
            {
                errorProvider1.SetError(txtUserID, "User ID Cannot be Empty!");
                e.Cancel = true;
            }
            else if (!ClsValidation.IsNumber(txtUserID.Text))
            {
                errorProvider1.SetError(txtUserID, "Please Enter A valid  User ID");
                e.Cancel = true;
            }
            else if (Clsuser.Find(int.Parse(txtUserID.Text)) == null)
            {
                errorProvider1.SetError(txtUserID, $"No User With ID = {txtUserID.Text} !");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtUserID, "");

            }
        }

        private void txtStayID_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtStayID.Text))
            {
                errorProvider1.SetError(txtStayID, "Stay ID Cannot be Empty!");
                e.Cancel = true;
            }
            else if (!ClsValidation.IsNumber(txtStayID.Text))
            {
                errorProvider1.SetError(txtStayID, "Please Enter A Valid Stay ID!");
                e.Cancel = true;
            }
            else if (ClsStay.Find(int.Parse(txtStayID.Text)) == null)
            {
                errorProvider1.SetError(txtStayID, $"No Stay With ID = {txtStayID.Text}!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtStayID, "");
            }
        }

        private void DTPissueDate_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (DTPissueDate.Value.Date > DateTime.Now.Date)
            {
                errorProvider1.SetError(DTPissueDate, "Issue Date Cannot Be In The Future!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(DTPissueDate, "");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                ClsUtil.ShowErrorMessage("Please Fix The Errors Before Save!");
                return;
            }
            _ReadNewInfo();
            if (_InvoiceInfo.Save())
            {
                if (Mode == _ENMode.Add)
                {
                    Mode = _ENMode.Edit;
                    lblTitle.Text = "Update Invoice";
                    lblInvoiceID.Text = _InvoiceInfo.InvoiceID.ToString();
                }
                ClsUtil.ShowSuccessMessage("Data Saved Successfully!");
            }
            else
            {
                ClsUtil.ShowErrorMessage("Failed To Save Invoice Data");
            }
        }

        private void frmAddEditInvoice_Load(object sender, EventArgs e)
        {
            _LoadDefaultValues();
        }
    }
}
