using System;
using System.Windows.Forms;

namespace HMS.Service_Usage
{
    public partial class frmServiceUsageDetails : Form
    {
        int ServiceUsageID;
        public frmServiceUsageDetails(int ID)
        {
            InitializeComponent();
            ServiceUsageID = ID;
        }

        private void frmServiceUsageDetails_Load(object sender, EventArgs e)
        {
            ctrlServiceUsageInfo1.LoadServiceUsageInfo(ServiceUsageID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
