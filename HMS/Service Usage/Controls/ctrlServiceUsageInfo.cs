using ClsGlobalClasses;
using HMS_Business;
using System.ComponentModel;
using System.Windows.Forms;

namespace HMS.Service_Usage.Controls
{
    public partial class ctrlServiceUsageInfo : UserControl
    {
        private clsServiceUsage _ServiceUsage;

        public ctrlServiceUsageInfo()
        {
            InitializeComponent();
        }

        public void LoadServiceUsageInfo(int serviceUsageID)
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                return;
            }

            _ServiceUsage = clsServiceUsage.Find(serviceUsageID);

            if (_ServiceUsage == null)
            {
                ResetServiceUsageInfo();

                ClsUtil.ShowErrorMessage("No Service Usage Found With ID = " + serviceUsageID);

                return;
            }

            DisplayServiceUsageInfo();
        }

        private void DisplayServiceUsageInfo()
        {
            lblServiceUsageID.Text = _ServiceUsage.ServiceUsageID.ToString();
            lblStayID.Text = _ServiceUsage.StayID.ToString();
            lblserviceName.Text = _ServiceUsage.ServiceInfo.ServiceName;
            lblemployeeID.Text = _ServiceUsage.EmployeeID.HasValue ? _ServiceUsage.EmployeeID.Value.ToString() : "N/A";
            lblOrderID.Text = _ServiceUsage.ApplicationID.HasValue ? _ServiceUsage.ApplicationID.Value.ToString() : "N/A";
            lblTotalAmount.Text = _ServiceUsage.Price.ToString("C2");
            lbluserID.Text = _ServiceUsage.CreatedByUserID.ToString();

            lblStatus.Text = clsServiceUsage.GetStatusString(_ServiceUsage.Status);

            lblNotes.Text =
                string.IsNullOrWhiteSpace(_ServiceUsage.Notes)
                ? "No Notes"
                : _ServiceUsage.Notes;
        }

        private void ResetServiceUsageInfo()
        {
            lblServiceUsageID.Text = "????";
            lblStayID.Text = "????";
            lblserviceName.Text = "????";
            lblemployeeID.Text = "????";
            lblOrderID.Text = "????";
            lblTotalAmount.Text = "????";
            lbluserID.Text = "????";
            lblStatus.Text = "????";
            lblNotes.Text = "????";

            _ServiceUsage = null;
        }
    }
}