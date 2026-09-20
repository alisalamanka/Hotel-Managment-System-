using GlobalClasses;
using HMS_Business;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace HMS.Employees
{
    public partial class FrmAddEditEmployee : Form
    {
        public enum EnMode
        {
            AddNew = 0,
            Update = 1
        }

        public EnMode Mode;

        private int? _EmployeeID;

        public int? CurrentEmployeeID
        {
            get
            {
                return _EmployeeID;
            }
        }

        private ClsEmployee _CurrentEmployee = new ClsEmployee();


        public FrmAddEditEmployee()
        {
            InitializeComponent();

            Mode = EnMode.AddNew;
        }


        public FrmAddEditEmployee(int EmployeeID)
        {
            InitializeComponent();

            _EmployeeID = EmployeeID;
            Mode = EnMode.Update;
        }


        private void _LoadDepartments()
        {
            DataTable dt = ClsDepartment.GetAllDepartments();

            if (dt == null)
                return;

            CBdepartment.DataSource = dt;
            CBdepartment.DisplayMember = "DepartmentName";
            CBdepartment.ValueMember = "DepartmentID";
        }


        private void _SetDefaultValues()
        {
            _LoadDepartments();

            if (Mode == EnMode.AddNew)
            {
                lblEmployeeID.Text = "[????]";

                CBdepartment.SelectedIndex = -1;
                txtSalary.Text = "";
                CBactive.Checked = true;

                Tuserinfo.Enabled = false;
                btnSave.Enabled = false;
                btnNext.Enabled = true;

                uCpersonCardWithFilter1.Clear();

                TBuser.SelectedTab = TBuser.TabPages["TPpersoninfo"];
            }
            else
            {
                _CurrentEmployee = ClsEmployee.Find(_EmployeeID.Value);

                if (_CurrentEmployee != null)
                {
                    _EmployeeID = _CurrentEmployee.EmployeeID;

                    lblEmployeeID.Text =
                        _CurrentEmployee.EmployeeID.ToString();

                    CBactive.Checked =
                        _CurrentEmployee.IsActive;

                    txtSalary.Text =
                        _CurrentEmployee.Salary.ToString("C");

                    CBdepartment.SelectedValue =
                        _CurrentEmployee.DepartmentID;

                    uCpersonCardWithFilter1.LoadPersonInfo(
                        _CurrentEmployee.PersonID.Value);

                    Tuserinfo.Enabled = true;

                    btnSave.Enabled = true;
                    TBuser.SelectedTab =
                        TBuser.TabPages["Tuserinfo"];

                    TPpersoninfo.Enabled = false;
                }
                else
                {
                    ClsUtil.ShowErrorMessage(
                        $"No Employee With ID = {_EmployeeID}");

                    return;
                }
            }
        }



     

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            bool ErrorOccurred = false;

            if (Mode == EnMode.AddNew)
            {
                if (uCpersonCardWithFilter1.SelectedPersonID == null ||
                    !uCpersonCardWithFilter1.SelectedPersonID.HasValue)
                {
                    ClsUtil.ShowErrorMessage(
                        "Please select a person!");

                    uCpersonCardWithFilter1.FilterFocus();
                    return;
                }


                bool EmployeeExists =
                    ClsEmployee.EmployeeExists(
                        uCpersonCardWithFilter1.SelectedPersonID.Value,
                        ref ErrorOccurred);


                if (ErrorOccurred)
                {
                    ClsUtil.ShowErrorMessage(
                        "An Error Occurred! Please check the event log.");

                    return;
                }


                if (EmployeeExists)
                {
                    ClsUtil.ShowErrorMessage(
                        "This Person is already an Employee. Please choose another person.");

                    uCpersonCardWithFilter1.FilterFocus();
                    return;
                }


                Tuserinfo.Enabled = true;

                TBuser.SelectedTab =
                    TBuser.TabPages["Tuserinfo"];

                btnSave.Enabled = true;
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                ClsUtil.ShowErrorMessage(
                    "Some fields are not valid. Please fix the errors before Save.");

                return;
            }


            if (uCpersonCardWithFilter1.SelectedPersonID == null)
            {
                ClsUtil.ShowErrorMessage(
                    "Please select a person!");

                return;
            }


            _CurrentEmployee.PersonID =
                uCpersonCardWithFilter1.SelectedPersonID;

            _CurrentEmployee.DepartmentID =
                Convert.ToInt32(CBdepartment.SelectedValue);

            _CurrentEmployee.IsActive =
                CBactive.Checked;

            _CurrentEmployee.Salary =
                decimal.Parse(txtSalary.Text.Trim());


            if (_CurrentEmployee.Save())
            {
                _EmployeeID = _CurrentEmployee.EmployeeID;

                lblEmployeeID.Text =
                    _CurrentEmployee.EmployeeID.Value.ToString();

                Mode = EnMode.Update;

                TPpersoninfo.Enabled = false;

                lblEmployeeID.Text =
                    _CurrentEmployee.EmployeeID.Value.ToString();

                ClsUtil.ShowSuccessMessage(
                    "Employee Saved Successfully");
            }
            else
            {
                ClsUtil.ShowErrorMessage(
                    "Failed To Save This Employee!");
            }
        }

        private void CBdepartment_Validating_1(object sender, CancelEventArgs e)
        {
            if (CBdepartment.SelectedIndex == -1)
            {
                InputsEP.SetError(
                    CBdepartment,
                    "Please select a department!");

                e.Cancel = true;
            }
            else
            {
                InputsEP.SetError(CBdepartment, "");
            }
        }

        private void txtSalary_Validating_1(object sender, CancelEventArgs e)
        {
            decimal Salary;

            if (string.IsNullOrWhiteSpace(txtSalary.Text))
            {
                InputsEP.SetError(
                    txtSalary,
                    "Salary is required!");

                e.Cancel = true;
                return;
            }

            if (!decimal.TryParse(
                txtSalary.Text.Trim(),
                out Salary))
            {
                InputsEP.SetError(
                    txtSalary,
                    "Please enter a valid salary!");

                e.Cancel = true;
                return;
            }

            if (Salary < 0)
            {
                InputsEP.SetError(
                    txtSalary,
                    "Salary cannot be negative!");

                e.Cancel = true;
                return;
            }

            InputsEP.SetError(txtSalary, "");
        }

        private void CBactive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmAddEditEmployee_Load_1(object sender, EventArgs e)
        {
            _SetDefaultValues();
        }

        private void uCpersonCardWithFilter1_OnPersonSelected_1(int obj)
        {
            _CurrentEmployee.PersonID = obj;

            btnNext.Enabled = true;
        }
    }
}