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

namespace HMS.Services
{
    public partial class UcServiceInfo : UserControl
    {
        private ClsService _ServiceInfo=new ClsService();
        private int? _ServiceID=null;
        public UcServiceInfo()
        {
            InitializeComponent();
        }

        private void UcServiceInfo_Load(object sender, EventArgs e)
        {

        }

        
        private void _FillServiceInfo()
        {
            lblServiceID.Text = _ServiceInfo.ServiceID.ToString();
            lblServiceName.Text = _ServiceInfo.ServiceName.ToString();
            lblStatus.Text = _ServiceInfo.Status == true ?"Avaible":"Not Avaible";

        }

        public void Reset()
        {
            lblServiceID.Text = "[????]";
            lblServiceName.Text = "[????]";
            lblStatus.Text = "[????]";
            
        }

        public void LoadServiceInfo(int ServicceID)
        {
            _ServiceInfo = ClsService.Find(ServicceID);
            if (_ServiceInfo == null)
            {
                ClsUtil.ShowErrorMessage($"No Service With ID = {ServicceID}");
                Reset();
                return;
            }
            _FillServiceInfo();
        }

    }
}
