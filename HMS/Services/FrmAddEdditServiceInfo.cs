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
    public partial class FrmAddEdditServiceInfo : Form
    {
       

        private void FrmAddEdditServiceInfo_Load(object sender, EventArgs e)
        {
            _SetDefaultValues();
        }
        private EnMode _Mode;

        private ClsService _CurrentService=new ClsService();
            
        private int _ServiceID;
        public FrmAddEdditServiceInfo()
        {
            InitializeComponent();
            _Mode = EnMode.Add;
        }
        public FrmAddEdditServiceInfo(int ServiceId)
        {
            InitializeComponent();
            _ServiceID = ServiceId;
            _Mode = EnMode.Update;
        }

        public enum EnMode
        {
            Add = 1, Update = 2
        }

        private event Action<int> DataBackEventHandler;

        protected void DataBack(int ServiceId)
        {
            if (DataBackEventHandler != null)
            {
                DataBackEventHandler.Invoke(_ServiceID);
            }
        }

      
        private void _FillServicesComboBox()
        {
                  List<string> _Services = new List<string>
                   {
                       "Active",
                       "InActive"
                   };
           CBstatus.DataSource = _Services;
        }
        
        private void _FillInputs()
        {
            txtServiceName.Text = _CurrentService.ServiceName.ToString();
            lblServiceId.Text = _CurrentService.ServiceID.ToString();
            CBstatus.SelectedIndex=_CurrentService.Status== "Active" ? 0 : 1;
        }

        private void _Reset()
        {
            _CurrentService = new ClsService();
            txtServiceName.Text = "";
            lblServiceId.Text = "";
            CBstatus.SelectedIndex = 1;

        }

        private void _ReadInputs()
        {
          _CurrentService.ServiceName = txtServiceName.Text;
          _CurrentService.Status=CBstatus.SelectedIndex==0? "Active" : "InActive";

        }

        private void _SetDefaultValues()
        {
            _FillServicesComboBox();
            if (_Mode == EnMode.Update)
            {
                _CurrentService = ClsService.Find(_ServiceID);
                if (_CurrentService == null)
                {
                    ClsUtil.ShowErrorMessage($"No Service With ID = {_ServiceID}");
                    this.Close();
                    return;
                }

                lblServiceId.Text =_CurrentService.ServiceID.ToString();
                lblTitle.Text = "Update Service";
                _FillInputs();
            }
            else
            {
                lblTitle.Text = "Add New Service";
                _Reset();
            }
        }



      

        private void FrmAddEditRoom_Load(object sender, EventArgs e)
        {
            
        }

        private void txtServiceName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtServiceName.Text))
            {
                EPinputs.SetError(txtServiceName, "Please enter the service neme!");
                e.Cancel=true;
            }
            else
            {
                EPinputs.SetError(txtServiceName, "");

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                ClsUtil.ShowErrorMessage("Some Fields are Not Valide Please Fix the Errors Before Save!");
                return;
            }
            _ReadInputs();
            if (_CurrentService.Save())
            {
                if (_Mode == EnMode.Add)
                {
                    _Mode = EnMode.Update;
                    lblTitle.Text = "Update Service";
                }
                ClsUtil.ShowSuccessMessage("Service Saved Successfully!");
            }
            else
            {
                ClsUtil.ShowErrorMessage("Failed To save This Service!");
                return;
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
