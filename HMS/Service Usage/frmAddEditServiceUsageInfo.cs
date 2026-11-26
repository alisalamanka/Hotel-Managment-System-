
using ClsGlobalClasses;
using HMS_Business;
using System;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace HMS.Service_Usage
{
    public partial class frmAddEditServiceUsageInfo : Form
    {
        private int? _ServiceUsageID;

        private clsServiceUsage _ServiceUsage = new clsServiceUsage();

        private enum EnMode
        {
            Add = 1,
            Update = 2
        }

        private EnMode _mode;

        public frmAddEditServiceUsageInfo()
        {
            InitializeComponent();

            _mode = EnMode.Add;

            _ConnectEvents();
        }

        public frmAddEditServiceUsageInfo(int serviceUsageID)
        {
            InitializeComponent();

            _ConnectEvents();

            _ServiceUsageID = serviceUsageID;

            _mode = EnMode.Update;

            _ServiceUsage = clsServiceUsage.Find(_ServiceUsageID.Value);

            if (_ServiceUsage == null)
            {
                ClsUtil.ShowErrorMessage(
                    $"No Service Usage With ID {_ServiceUsageID.Value}");

                return;
            }
        }

        private void _ConnectEvents()
        {
            this.Load += frmAddEditServiceUsageInfo_Load;

            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;

            txtStayID.Validating += txtStayID_Validating;
            cbServices.Validating += cbServices_Validating;
            txtEmployeeID.Validating += txtEmployeeID_Validating;
            txtOrderID.Validating += txtOrderID_Validating;
            txtUserID.Validating += txtUserID_Validating;
            txtTotalAmount.Validating += txtTotalAmount_Validating;
            CBstatus.Validating += CBstatus_Validating;
        }

        private void _LoadServices()
        {
            DataTable services = ClsService.GetAllServices();

            cbServices.DataSource = services;
            cbServices.ValueMember = "ServiceID";
            cbServices.DisplayMember = "ServiceName";
        }

        private void _LoadDefaultValues()
        {
            CBstatus.Items.Clear();

            CBstatus.Items.Add("Active");
            CBstatus.Items.Add("Cancelled");

            switch (_mode)
            {
                case EnMode.Add:
                    {
                        CBstatus.SelectedIndex = 0;
                        CBstatus.Enabled = false;
                        lblTitle.Text = "Add New Service Usage";

                        lblServiceUsageID.Text = "????";

                        txtStayID.Text = "";

                        cbServices.SelectedIndex = -1;

                        txtEmployeeID.Text = "";
                        txtOrderID.Text = "";

                        txtUserID.Text = "2";
                        txtUserID.Enabled = false;

                        txtTotalAmount.Text = "0.00";

                        CBstatus.SelectedIndex = 0;

                        txtNotes.Text = "";

                        break;
                    }

                case EnMode.Update:
                    {
                        CBstatus.Enabled = true;
                        if (_ServiceUsage != null)
                        {
                            lblTitle.Text = "Update Service Usage";

                            lblServiceUsageID.Text =
                                _ServiceUsage.ServiceUsageID.ToString();

                            txtStayID.Text =
                                _ServiceUsage.StayID.ToString();

                            cbServices.SelectedValue =
                                _ServiceUsage.ServiceID.Value;

                            txtEmployeeID.Text =
                                _ServiceUsage.EmployeeID.ToString();

                            txtOrderID.Text =
                                _ServiceUsage.ApplicationID.ToString();

                            txtUserID.Text =
                                _ServiceUsage.CreatedByUserID.ToString();

                            txtUserID.Enabled = false;

                            txtTotalAmount.Text =
                                _ServiceUsage.Price.ToString("0.00");

                            CBstatus.SelectedIndex =
                                _ServiceUsage.Status == 1 ? 0 : 1;

                            txtNotes.Text = _ServiceUsage.Notes;
                        }

                        break;
                    }
            }
        }

        private void _FillNewInfo()
        {
            _ServiceUsage.StayID =
                int.Parse(txtStayID.Text);

            _ServiceUsage.ServiceID =
                int.Parse(cbServices.SelectedValue.ToString());

            _ServiceUsage.EmployeeID =
                string.IsNullOrEmpty(txtEmployeeID.Text)
                ? (int?)null
                : int.Parse(txtEmployeeID.Text);

            _ServiceUsage.ApplicationID =
                string.IsNullOrEmpty(txtOrderID.Text)
                ? (int?)null
                : int.Parse(txtOrderID.Text);

            _ServiceUsage.CreatedByUserID =
                int.Parse(txtUserID.Text);

            _ServiceUsage.Price =
                decimal.Parse(
                    txtTotalAmount.Text,
                    CultureInfo.CurrentCulture);

            _ServiceUsage.Status =
                (short)(CBstatus.SelectedIndex + 1);

            _ServiceUsage.Notes = txtNotes.Text;
        }

        private void frmAddEditServiceUsageInfo_Load(
            object sender,
            EventArgs e)
        {
            if (_mode == EnMode.Update && _ServiceUsage == null)
            {
                return;
            }

            _LoadServices();

            _LoadDefaultValues();
        }

        private void txtStayID_Validating(
            object sender,
            CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtStayID.Text))
            {
                errorProvider1.SetError(
                    txtStayID,
                    "Stay ID Cannot Be Null");

                e.Cancel = true;
            }
            else if (!ClsValidation.IsNumber(txtStayID.Text))
            {
                errorProvider1.SetError(
                    txtStayID,
                    "Please Enter A Valid Stay ID!");

                e.Cancel = true;
            }
            else if (ClsStay.Find(int.Parse(txtStayID.Text)) == null)
            {
                errorProvider1.SetError(
                    txtStayID,
                    $"No Stay With ID = {txtStayID.Text}");

                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtStayID, "");
            }
        }

        private void cbServices_Validating(
            object sender,
            CancelEventArgs e)
        {
            if (cbServices.SelectedIndex == -1)
            {
                errorProvider1.SetError(
                    cbServices,
                    "Please Select A Service");

                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(cbServices, "");
            }
        }

        private void txtEmployeeID_Validating(
            object sender,
            CancelEventArgs e)
        {
            bool ErrorOccoured = false;
            if (string.IsNullOrEmpty(txtEmployeeID.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmployeeID, "Please enter a Employee ID");
            }
            else if (!ClsValidation.IsNumber(txtEmployeeID.Text))
            {
                errorProvider1.SetError(
                    txtEmployeeID,
                    "Please Enter A Valid Employee ID!");

                e.Cancel = true;
            }
            else if (!ClsEmployee.EmployeeExists(Convert.ToInt16(txtEmployeeID.Text), ref ErrorOccoured))
            {

                e.Cancel = true;
                errorProvider1.SetError(txtEmployeeID, "Employee with this ID not found Or An Error Occoured");

            }
            else
            {
                errorProvider1.SetError(txtEmployeeID, "");
            }
        }

        private void txtOrderID_Validating(
            object sender,
            CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtOrderID.Text))
            {
                errorProvider1.SetError(txtOrderID, "");
            }
            else if (!ClsValidation.IsNumber(txtOrderID.Text))
            {
                errorProvider1.SetError(
                    txtOrderID,
                    "Please Enter A Valid Order ID!");

                e.Cancel = true;
            }
            else if (ClsOrder.Find(Convert.ToInt16(txtOrderID.Text)) == null)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtOrderID, "No Order Found With This ID!");
            }
            else
            {
                errorProvider1.SetError(txtOrderID, "");
            }
        }

        private void txtUserID_Validating(
            object sender,
            CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserID.Text))
            {
                errorProvider1.SetError(
                    txtUserID,
                    "User ID Cannot Be Null");

                e.Cancel = true;
            }
            else if (!ClsValidation.IsNumber(txtUserID.Text))
            {
                errorProvider1.SetError(
                    txtUserID,
                    "Please Enter A Valid User ID!");

                e.Cancel = true;
            }
            else if (Clsuser.Find(int.Parse(txtUserID.Text)) == null)
            {
                errorProvider1.SetError(
                    txtUserID,
                    $"No User With ID = {txtUserID.Text}");

                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtUserID, "");
            }
        }

        private void txtTotalAmount_Validating(
            object sender,
            CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTotalAmount.Text))
            {
                errorProvider1.SetError(
                    txtTotalAmount,
                    "Price Cannot Be Null");

                e.Cancel = true;
            }
            else if (!decimal.TryParse(
                txtTotalAmount.Text,
                NumberStyles.Number,
                CultureInfo.CurrentCulture,
                out decimal price) || price < 0)
            {
                errorProvider1.SetError(
                    txtTotalAmount,
                    "Please Enter A Valid Price!");

                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtTotalAmount, "");
            }
        }

        private void CBstatus_Validating(
            object sender,
            CancelEventArgs e)
        {
            if (CBstatus.SelectedItem == null)
            {
                errorProvider1.SetError(
                    CBstatus,
                    "Please Select A Status");

                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(CBstatus, "");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                ClsUtil.ShowErrorMessage(
                    "Please Correct The Errors Before Save!");

                return;
            }

            _FillNewInfo();

            if (_ServiceUsage.Save())
            {
                _mode = EnMode.Update;

                _ServiceUsageID = _ServiceUsage.ServiceUsageID;

                _ServiceUsage.Mode =
                    clsServiceUsage.EnMode.Update;

                lblServiceUsageID.Text =
                    _ServiceUsage.ServiceUsageID.ToString();

                lblTitle.Text = "Update Service Usage";

                ClsUtil.ShowSuccessMessage(
                    "Service Usage Saved Successfully!");
            }
            else
            {
                ClsUtil.ShowErrorMessage(
                    "Failed To Save Service Usage!");

                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
