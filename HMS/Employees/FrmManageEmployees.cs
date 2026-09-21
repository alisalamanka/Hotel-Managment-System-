using GlobalClasses;
using HMS_Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace HMS.Employees
{
    public partial class FrmManageEmployees : Form
    {
        private DataTable _dtEmployees = ClsEmployee.GetAllEmployees();

        public FrmManageEmployees()
        {
            InitializeComponent();
        }

        private void _RefreshEmployeeList()
        {
            _dtEmployees = ClsEmployee.GetAllEmployees();

            DGVemployeesList.DataSource = _dtEmployees;

            lblNumberOfEmployees.Text =
                DGVemployeesList.Rows.Count.ToString();
        }


        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAddNewEmployee_Click_1(object sender, EventArgs e)
        {
            FrmAddEditEmployee frm =
               new FrmAddEditEmployee();

            frm.ShowDialog();

            _RefreshEmployeeList();
        }

        private void txtFilterByValue_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (CBfilterBy.Text == "EmployeeID" ||
               CBfilterBy.Text == "Person ID")
            {
                e.Handled =
                    !char.IsControl(e.KeyChar) &&
                    !char.IsDigit(e.KeyChar);
            }
        }

        private void cbIsActive_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string FilterValue = cbIsActive.Text.Trim();

            if (FilterValue == "All")
            {
                _dtEmployees.DefaultView.RowFilter = "";
            }
            else if (FilterValue == "Yes")
            {
                _dtEmployees.DefaultView.RowFilter =
                    "[IsActive] = 1";
            }
            else if (FilterValue == "No")
            {
                _dtEmployees.DefaultView.RowFilter =
                    "[IsActive] = 0";
            }

            lblNumberOfEmployees.Text =
                _dtEmployees.DefaultView.Count.ToString();
        }

        private void txtFilterByValue_TextChanged_1(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (CBfilterBy.Text)
            {
                case "Employee ID":
                    FilterColumn = "EmployeeID";
                    break;

                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "National Number":
                    FilterColumn = "NationalNo";
                    break;

                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                case "Department":
                    FilterColumn = "DepartmentName";
                    break;
            }


            if (string.IsNullOrWhiteSpace(txtFilterByValue.Text) ||
                CBfilterBy.Text == "None")
            {
                _dtEmployees.DefaultView.RowFilter = "";
            }
            else
            {
                string Value =
                    txtFilterByValue.Text.Trim();

                if (CBfilterBy.Text == "Employee ID" ||
                    CBfilterBy.Text == "Person ID")
                {
                    _dtEmployees.DefaultView.RowFilter =
                        $"[{FilterColumn}] = {Value}";
                }
                else
                {
                    _dtEmployees.DefaultView.RowFilter =
                        $"[{FilterColumn}] LIKE '{Value}%'";
                }
            }

            lblNumberOfEmployees.Text =
                _dtEmployees.DefaultView.Count.ToString();
        }

        private void CBfilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Filter =
                CBfilterBy.Text.Trim();

            cbIsActive.Visible =
                Filter == "is Active";

            txtFilterByValue.Visible =
                Filter != "is Active" &&
                Filter != "None";

            if (txtFilterByValue.Visible)
            {
                txtFilterByValue.Text = "";
                txtFilterByValue.Focus();
            }

            if (Filter == "None")
            {
                _dtEmployees.DefaultView.RowFilter = "";

                lblNumberOfEmployees.Text =
                    _dtEmployees.DefaultView.Count.ToString();
            }
        }

        private void FrmManageEmployees_Load(object sender, EventArgs e)
        {
            _dtEmployees = ClsEmployee.GetAllEmployees();

            CBfilterBy.SelectedIndex = 0;
            cbIsActive.Visible = false;
            txtFilterByValue.Visible = false;

            DGVemployeesList.DataSource = _dtEmployees;

            lblNumberOfEmployees.Text =
                DGVemployeesList.Rows.Count.ToString();

            // Columns
            DGVemployeesList.Columns[0].HeaderText = "Person ID";
            DGVemployeesList.Columns[0].Width = 110;

            DGVemployeesList.Columns[1].HeaderText = "Employee ID";
            DGVemployeesList.Columns[1].Width = 110;

            DGVemployeesList.Columns[2].HeaderText = "Full Name";
            DGVemployeesList.Columns[2].Width = 220;

            DGVemployeesList.Columns[3].HeaderText = "National Number";
            DGVemployeesList.Columns[3].Width = 120;

            DGVemployeesList.Columns[4].HeaderText = "Date Of Birth";
            DGVemployeesList.Columns[4].Width = 130;

            DGVemployeesList.Columns[5].HeaderText = "Phone";
            DGVemployeesList.Columns[5].Width = 140;

            DGVemployeesList.Columns[6].HeaderText = "Email";
            DGVemployeesList.Columns[6].Width = 250;

            DGVemployeesList.Columns[7].HeaderText = "Country";
            DGVemployeesList.Columns[7].Width = 100;


            DGVemployeesList.Columns[8].HeaderText = "Department";
            DGVemployeesList.Columns[8].Width = 120;

            DGVemployeesList.Columns[9].HeaderText = "Salary";
            DGVemployeesList.Columns[9].Width = 100;

            DGVemployeesList.Columns[10].HeaderText = "Is Active";
            DGVemployeesList.Columns[10].Width = 100;
        }

        private void TSMIaddnewuser_Click(object sender, EventArgs e)
        {

        }

        private void TSMIaddNewEmployee_Click(object sender, EventArgs e)
        {
            FrmAddEditEmployee frm = new FrmAddEditEmployee();
            frm.ShowDialog();
            _RefreshEmployeeList();
        }

        private void TSMIshowdetails_Click(object sender, EventArgs e)
        {
            if (DGVemployeesList.CurrentRow != null)
            {
                int EmpID = (int)DGVemployeesList.CurrentRow.Cells[1].Value;
                FrmEmployeeDetails frm = new FrmEmployeeDetails(EmpID);
                frm.ShowDialog();
            }
            else
                return;
        }

        private void TSMIeditinfo_Click(object sender, EventArgs e)
        {
            if (DGVemployeesList.CurrentRow != null)
            {
                int EmpID = (int)DGVemployeesList.CurrentRow.Cells[1].Value;
                FrmAddEditEmployee frm = new FrmAddEditEmployee(EmpID);
                frm.ShowDialog();
                _RefreshEmployeeList();
            }
            else
                return;
        }

        private void TSMIdelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Delete this Employee?",
                "Delete Confirmation!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                int EmpID = (int)DGVemployeesList.CurrentRow.Cells[1].Value;
                ClsEmployee emp = ClsEmployee.Find(EmpID);
                if (emp.DeleteEmployee())
                {
                    ClsUtil.ShowSuccessMessage("Employee Deleted Successfully!");
                    _RefreshEmployeeList();
                    return;
                }
                else
                {
                    ClsUtil.ShowErrorMessage("Failed To delete this Employee!");
                    return;
                }
            }
        }

        private void DGVemployeesList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVemployeesList.CurrentRow!=null)
            {
                int EmpID = (int)DGVemployeesList.CurrentRow.Cells[1].Value;
                FrmEmployeeDetails frm = new FrmEmployeeDetails(EmpID);
                frm.ShowDialog();
                _RefreshEmployeeList();
            }

        }
    }
}