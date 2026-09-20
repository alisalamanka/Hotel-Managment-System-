using GlobalClasses;
using HMS.Users.UserControls;
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

namespace HMS.Employees
{
    public partial class FrmEmployeeDetails : Form
    {
        private int? _EmployeeID;
        public FrmEmployeeDetails(int EmployeeID)
        {
            InitializeComponent();
            _EmployeeID=EmployeeID;
        }

        private void FrmEmployeeDetails_Load(object sender, EventArgs e)
        {
            if (_EmployeeID != null && _EmployeeID.HasValue)
            {
                ctrlEmployeesInfo1.LoadEmployeeInfo(_EmployeeID);
            }
            else
            {
                ClsUtil.ShowErrorMessage("User ID is not provided or invalid!");
                this.Close();
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
