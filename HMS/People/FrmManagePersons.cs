using GlobalClasses;
using HMS_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HMS.People
{
    public partial class FrmManagePersons : Form
    {

        private static DataTable _dtPersonsList = ClsPerson.GetAllPersons();
        private DataTable _PersonsTable = _dtPersonsList.DefaultView.ToTable(false, "PersonID", "NationalNo", "FirstName", "LastName", "DateOfBirth",
            "CountryName", "Phone", "Email", "IsActive");

        private void _RefreshList()
        {
            _dtPersonsList = ClsPerson.GetAllPersons();
            _PersonsTable = _dtPersonsList.DefaultView.ToTable(false, "PersonID", "NationalNo", "FirstName", "LastName", "DateOfBirth",
           "CountryName", "Phone", "Email","IsActive");

            dgvListPeople.DataSource = _PersonsTable;
            LBLnumberofreccords.Text = _PersonsTable.Rows.Count.ToString();
        }





        public FrmManagePersons()
        {
            InitializeComponent();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            FrmAdd_EditPersonInfo AddPerson = new FrmAdd_EditPersonInfo();
            AddPerson.ShowDialog();
            _RefreshList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmManagePersons_Load(object sender, EventArgs e)
        {
            dgvListPeople.DataSource = _PersonsTable;
            CBfilterby.SelectedIndex = 0;
            LBLnumberofreccords.Text = (dgvListPeople.Rows.Count).ToString();
            if (dgvListPeople.Rows.Count >= 1)
            {
                dgvListPeople.Columns[0].HeaderText = "Person ID";
                dgvListPeople.Columns[0].Width = 100;

                dgvListPeople.Columns[1].HeaderText = "National Number";
                dgvListPeople.Columns[1].Width = 120;

                dgvListPeople.Columns[2].HeaderText = "First Name";
                dgvListPeople.Columns[2].Width = 130;

                dgvListPeople.Columns[3].HeaderText = "Last Name";
                dgvListPeople.Columns[3].Width = 130;

                dgvListPeople.Columns[4].HeaderText = "Date Of Birth";
                dgvListPeople.Columns[4].Width = 120;

                dgvListPeople.Columns[5].HeaderText = "Country Name";
                dgvListPeople.Columns[5].Width = 130;

                dgvListPeople.Columns[6].HeaderText = "Phone";
                dgvListPeople.Columns[6].Width = 140;

                dgvListPeople.Columns[7].HeaderText = "Email";
                dgvListPeople.Columns[7].Width = 150;

                dgvListPeople.Columns[8].HeaderText = "Is Active?";
                dgvListPeople.Columns[8].Width = 100;

            }
        }

        private void CBfilterby_SelectedIndexChanged(object sender, EventArgs e)
        {
            TBfilterbyvalue.Visible = (CBfilterby.Text.ToLower() != "none" &&CBfilterby.Text.ToLower() != "is active");
            CbIsActive.Visible = (CBfilterby.Text.ToLower() == "is active");
            if (TBfilterbyvalue.Visible)
            {
                TBfilterbyvalue.Text = "";
                TBfilterbyvalue.Focus();
            }
        }

        private void TSMIshowPersonInfo_Click(object sender, EventArgs e)
        {
            int? PersonID = Convert.ToInt32(dgvListPeople.CurrentRow.Cells[0].Value);
            if (PersonID.HasValue)
            {
                FrmPersonDetails frm = new FrmPersonDetails(PersonID);
                frm.ShowDialog();
            }
            
        }

        private void TSMIaddPerson_Click(object sender, EventArgs e)
        {
            FrmAdd_EditPersonInfo frm = new FrmAdd_EditPersonInfo();
            frm.ShowDialog();
            _RefreshList();
        }

        private void TSMIeditPerson_Click(object sender, EventArgs e)
        {
            int? PersonID = Convert.ToInt32(dgvListPeople.CurrentRow.Cells[0].Value);
            if (PersonID.HasValue)
            {
                FrmAdd_EditPersonInfo frm = new FrmAdd_EditPersonInfo(PersonID.Value);
                frm.ShowDialog();
            }
            _RefreshList();
        }

        private void TSMIdelete_Click(object sender, EventArgs e)
        {
            int? PersonID = Convert.ToInt32(dgvListPeople.CurrentRow.Cells[0].Value);
            if (PersonID.HasValue)
            {
                if (MessageBox.Show("Are You Sure You Want To delete this Person?", "Confirm Delete!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    ClsPerson person = ClsPerson.Find(PersonID.Value);
                    if (person.deletePerson())
                    {
                        ClsUtil.ShowSuccessMessage("Person Deleted Successfully!");
                    }
                    else
                    {
                        ClsUtil.ShowErrorMessage("Failed to delete Person, Check the Event Log");
                    }
                }
            }
            _RefreshList();
        }

        private void dgvListPeople_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int? PersonID = Convert.ToInt32(dgvListPeople.CurrentRow.Cells[0].Value);
            FrmPersonDetails frm = new FrmPersonDetails(PersonID);
            frm.ShowDialog();
        }

        private void TBfilterbyvalue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CBfilterby.Text == "Person ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }

        }

        private void TBfilterbyvalue_TextChanged(object sender, EventArgs e)
        {
            

            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (CBfilterby.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "National Number":
                    FilterColumn = "NationalNo";
                    break;

                case "First Name":
                    FilterColumn = "FirstName";
                    break;

                case "Last Name":
                    FilterColumn = "LastName";
                    break;

                case "Country":
                    FilterColumn = "CountryName";
                    break;

                case "Phone":
                    FilterColumn = "Phone";
                    break;

                case "Email":
                    FilterColumn = "Email";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (TBfilterbyvalue.Text.Trim() == "" || FilterColumn == "None")
            {
                _PersonsTable.DefaultView.RowFilter = "";
                LBLnumberofreccords.Text = dgvListPeople.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "PersonID")
                //in this case we deal with integer not string.

                _PersonsTable.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, TBfilterbyvalue.Text.Trim());
            else
                _PersonsTable.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, TBfilterbyvalue.Text.Trim());

            LBLnumberofreccords.Text = dgvListPeople.RowCount.ToString();
        }

        private void CbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColum= "IsActive";
            switch(CbIsActive.Text.ToLower())
            {
                case "yes":
                    _PersonsTable.DefaultView.RowFilter = string.Format("[{0}] = true", FilterColum);
                    break;
                case "no":
                    _PersonsTable.DefaultView.RowFilter = string.Format("[{0}] = false", FilterColum);
                    break;
                default:
                    _PersonsTable.DefaultView.RowFilter = "";
                    break;
            }
            LBLnumberofreccords.Text = dgvListPeople.RowCount.ToString();
        }
    }
}
