using ClsGlobalClasses;
using HMS_Business;
using System.Windows.Forms;

namespace HMS.Order.Controls
{
    public partial class ctrlOrderInfo : UserControl
    {
        ClsOrder _CurrentOrder;

        public ctrlOrderInfo()
        {
            InitializeComponent();
        }

        private void _FillOrderInfo()
        {
            lblOrderID.Text = _CurrentOrder.OrderID.ToString();

            lblOrderType.Text = _CurrentOrder.orderTypeInfo.OrderTypeName;

            lblUserID.Text = _CurrentOrder.UserID.ToString();

            lblOrderDate.Text = _CurrentOrder.OrderDate.ToString();

            lblStatus.Text = ClsOrder.GetStatusString(
                _CurrentOrder.Status);
        }

        public void Reset()
        {
            lblOrderID.Text = "[????]";
            lblOrderType.Text = "[????]";
            lblUserID.Text = "[????]";
            lblOrderDate.Text = "[????]";
            lblStatus.Text = "[????]";
        }

        public void LoadOrderInfo(int OrderID)
        {
            _CurrentOrder = ClsOrder.Find(OrderID);

            if (_CurrentOrder == null)
            {
                ClsUtil.ShowErrorMessage(
                    $"No Order With ID = {OrderID}");

                Reset();
                return;
            }

            _FillOrderInfo();
        }
    }
}