using ClsGlobalClasses;
using HMS_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            // Order Types
            CBorderType.DataSource = ClsOrderType.GetAllOrderTypes();
            CBorderType.DisplayMember = "OrderTypeName";
            CBorderType.ValueMember = "OrderTypeID";

            // Status
            CBstatus.DataSource =
                Enum.GetValues(typeof(ClsOrder.EnStatus));

            DTPorderDate.Enabled = false;

            switch (_mode)
            {
                case EnMode.Add:
                    {
                        lblTitle.Text = "Add New Order";

                        lblReservationID.Text = "";

                        txtUserID.Text = "2";
                        txtUserID.Enabled = false;

                        CBorderType.SelectedIndex = 0;

                        CBstatus.SelectedItem =
                            ClsOrder.EnStatus.Pending;

                        DTPorderDate.Value = DateTime.Now;

                    }
                    break;

                case EnMode.Update:
                    {
                        if (_orderInfo != null)
                        {
                            lblTitle.Text = "Update Order";

                            lblReservationID.Text =
                                _orderInfo.OrderID.ToString();

                            txtUserID.Text =
                                _orderInfo.UserID.ToString();

                            txtUserID.Enabled = false;

                            CBorderType.SelectedValue =
                                _orderInfo.OrderTypeID;

                            CBstatus.SelectedItem =
                                (ClsOrder.EnStatus)_orderInfo.Status;

                            DTPorderDate.Value =
                                _orderInfo.OrderDate;
                        }
                    }
                    break;
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




    }
}
