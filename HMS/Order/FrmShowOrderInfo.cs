using ClsGlobalClasses;
using HMS_Business;
using System;
using System.Windows.Forms;

namespace HMS.Order
{
    public partial class FrmShowOrderInfo : Form
    {
        private int _ID;
        public FrmShowOrderInfo(int orderID)
        {
            InitializeComponent();
            _ID = orderID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmShowOrderInfo_Load(object sender, EventArgs e)
        {
            ClsOrder order = ClsOrder.Find(_ID);
            if (order == null)
            {
                ClsUtil.ShowErrorMessage($"No Order With ID = {_ID}");
                this.Close();
                return;
            }
            ctrlOrderInfo1.LoadOrderInfo(_ID);
        }
    }
}
