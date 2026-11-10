using ClsGlobalClasses;
using HMS_Business;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace HMS.Order
{
    public partial class FrmAddEditOrder : Form
    {
        private int? _OrderID;

        private ClsOrder _orderInfo = new ClsOrder();

        private enum EnMode
        {
            Add = 1,
            Update = 2
        }

        private EnMode _mode;

        private void _LoadDefaultValues()
        {
            CBorderType.DataSource = ClsOrderType.OrderTypesList();
            CBorderType.DisplayMember = "OrderTypeName";
            CBorderType.ValueMember = "OrderTypeID";

            CBstatus.DataSource =
                Enum.GetValues(typeof(ClsOrder.EnOrderStatus));

            DTPorderDate.Enabled = false;

            switch (_mode)
            {
                case EnMode.Add:
                    {
                        lblTitle.Text = "Add New Order";

                        lblOrderID.Text = "[????]";

                        txtUserID.Text = "1";
                        txtUserID.Enabled = false;

                        CBorderType.SelectedIndex = 0;

                        CBstatus.SelectedItem =
                            ClsOrder.EnOrderStatus.Pending;

                        DTPorderDate.Value = DateTime.Now;

                    }
                    break;

                case EnMode.Update:
                    {
                        if (_orderInfo != null)
                        {
                            lblTitle.Text = "Update Order";

                            lblOrderID.Text =
                                _orderInfo.OrderID.ToString();

                            txtUserID.Text =
                                _orderInfo.UserID.ToString();

                            txtUserID.Enabled = false;

                            CBorderType.SelectedValue =
                                _orderInfo.OrderTypeID;

                            CBstatus.SelectedItem =
                                (ClsOrder.EnOrderStatus)_orderInfo.Status;

                            DTPorderDate.Value =
                                _orderInfo.OrderDate;
                        }
                    }
                    break;
            }

        }

        private void _FillNewInfo()
        {
            _orderInfo.OrderTypeID =
                (int)CBorderType.SelectedValue;

            if (int.TryParse(txtUserID.Text, out int ID))
            {
                _orderInfo.UserID = ID;
            }


            _orderInfo.OrderDate =
                DTPorderDate.Value;

            _orderInfo.Status = (short)(ClsOrder.EnOrderStatus)CBstatus.SelectedItem;

        }

        public FrmAddEditOrder()
        {
            InitializeComponent();
            _mode = EnMode.Add;
        }
        public FrmAddEditOrder(int ID)
        {
            InitializeComponent();

            _OrderID = ID;
            _mode = EnMode.Update;

            _orderInfo = ClsOrder.Find(_OrderID.Value);

            if (_orderInfo == null)
            {
                ClsUtil.ShowErrorMessage(
                    $"No Order with ID = {_OrderID.Value}");

                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddEditOrder_Load(object sender, EventArgs e)
        {
            _LoadDefaultValues();
        }

        private void txtUserID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserID.Text))
            {
                InputsEP.SetError(
                    txtUserID,
                    "User ID Cannot Be Empty!");

                e.Cancel = true;
            }
            else if (!ClsValidation.IsNumber(txtUserID.Text))
            {
                InputsEP.SetError(
                    txtUserID,
                    "Please enter a valid ID!");

                e.Cancel = true;
            }
            else if (Clsuser.Find(int.Parse(txtUserID.Text)) == null)
            {
                InputsEP.SetError(
                    txtUserID,
                    $"No User With ID = {txtUserID.Text}");

                e.Cancel = true;
            }
            else
            {
                InputsEP.SetError(txtUserID, "");
            }
        }

        private void CBorderType_Validating(object sender, CancelEventArgs e)
        {
            if (CBorderType.SelectedIndex == -1)
            {
                InputsEP.SetError(
                    CBorderType,
                    "Please Select an Order Type!");

                e.Cancel = true;
            }
            else
            {
                InputsEP.SetError(CBorderType, "");
            }
        }

        private void CBstatus_Validating(object sender, CancelEventArgs e)
        {
            if (_mode == EnMode.Add)
            {
                ClsOrder.EnOrderStatus SelectedStatus =
                    (ClsOrder.EnOrderStatus)CBstatus.SelectedItem;

                if (SelectedStatus != ClsOrder.EnOrderStatus.Pending)
                {
                    InputsEP.SetError(
                        CBstatus,
                        "Wrong Status For New Order!");

                    e.Cancel = true;
                }
                else
                {
                    InputsEP.SetError(CBstatus, "");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                ClsUtil.ShowErrorMessage(
                    "Please Fix The Errors Before Save!");

                return;
            }

            _FillNewInfo();

            if (_orderInfo.Save())
            {
                _mode = EnMode.Update;

                _OrderID = _orderInfo.OrderID;

                _orderInfo = ClsOrder.Find(_OrderID.Value);

                ClsUtil.ShowSuccessMessage(
                    "Order Saved Successfully!");

                lblOrderID.Text =
                    _orderInfo.OrderID.ToString();

                lblTitle.Text = "Update Order";

                _orderInfo.Mode = ClsOrder.EnMode.Update;
            }
            else
            {
                ClsUtil.ShowErrorMessage(
                    "Failed To Save Order!");

                return;
            }
        }

        private void DTPorderDate_Validated(object sender, EventArgs e)
        {

        }
    }
}


