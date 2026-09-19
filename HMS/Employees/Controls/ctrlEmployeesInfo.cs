using GlobalClasses;
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

namespace HMS.Employees.Controls
{
    public partial class ctrlEmployeesInfo : UserControl
    {
        public ctrlEmployeesInfo()
        {
            InitializeComponent();
        }

        private ClsEmployee _CurrentEmployee;
        private int? _EmployeeID;

        private void _FillEmployeeInfo()
        {
            lblEmployeeID.Text = _CurrentEmployee.EmployeeID.ToString();
            lblSalary.Text = _CurrentEmployee.Salary.ToString("C");
            lblISActive.Text = _CurrentEmployee.IsActive ? "Yes" : "No";
            uCpersonCard1._LoadPersonInfo(_CurrentEmployee.PersonID.Value);
            lblDepartment.Text = _CurrentEmployee.DepartmentInfo.DepartmentName;
        }

        public void LoadEmployeeInfo(int? employeeID)
        {
            _EmployeeID = employeeID;
            if (_EmployeeID != null && _EmployeeID.HasValue)
            {
                _CurrentEmployee = ClsEmployee.Find(_EmployeeID.Value);
                if (_CurrentEmployee != null)
                {
                    _FillEmployeeInfo();
                }
                else
                {
                    ClsUtil.ShowErrorMessage("Employee not found or An Error Occured please check the event log!");
                    _Reset();
                }
            }

        }



        private void _Reset()
        {
            _EmployeeID = null;
            _CurrentEmployee = new ClsEmployee();
            lblISActive.Text = "????";
            lblEmployeeID.Text = "????";
            lblDepartment.Text = "????";
            lblSalary.Text = "????";
            uCpersonCard1.Clear();
        }

    }
}
