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

namespace HMS.Users
{
    public partial class FRMlistUsers : Form
    {
        DataTable _dtUsers=Clsuser.GetAllUsers();
        public FRMlistUsers()
        {
            InitializeComponent();
        }
        private void _RefreshUserList()
        {
            DataTable _UsersList=Clsuser.GetAllUsers();
            DGVListUsers.DataSource = Clsuser.GetAllUsers();
        }



        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            FRMaddNew_EditUser _AddNewUser = new FRMaddNew_EditUser();
            _AddNewUser.ShowDialog();
            _RefreshUserList();
        }

        private void CBfilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbIsActive.Visible = (CBfilterBy.Text.Trim()== "is Active");
            txtFilterByValue.Visible = (CBfilterBy.Text.Trim() != "is Active"&&CBfilterBy.Text.Trim()!="None");
            if (txtFilterByValue.Visible)
            {
                txtFilterByValue.Text = "";
                txtFilterByValue.Focus();
            }
        }

        private void txtFilterByValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch(CBfilterBy.Text)
            {
                case "User ID":
                    FilterColumn = "UserID";
                    break;
                case "Full Name":
                    FilterColumn = "FullName";
                    break;
                case "User Name":
                    FilterColumn = "UserName";
                    break;
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;
                case "Phone":
                    FilterColumn = "Phone";
                    break;
                case "is Active":
                    FilterColumn = "isActive";
                    break;
                case "Email":
                    FilterColumn = "Email";
                    break;
            }

            if (txtFilterByValue.Text==""||CBfilterBy.Text=="None")
            {
                _dtUsers.DefaultView.RowFilter = "";
                lblNOusers.Text=_dtUsers.DefaultView.Count.ToString();
            }
            else
            {
                if (CBfilterBy.Text=="Person ID" ||CBfilterBy.Text=="User ID")
                {
                    _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterByValue.Text.Trim());
                }
                else
                {
                    _dtUsers.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", FilterColumn, txtFilterByValue.Text.Trim());

                }
                lblNOusers.Text=DGVListUsers.Rows.Count.ToString();
            }
        }

        private void FRMlistUsers_Load(object sender, EventArgs e)
        {
            _dtUsers = Clsuser.GetAllUsers();
            CBfilterBy.SelectedIndex = 0;
            DGVListUsers.DataSource = _dtUsers;
            lblNOusers.Text = DGVListUsers.Rows.Count.ToString();
            DGVListUsers.Columns[0].HeaderText = "User ID";
            DGVListUsers.Columns[0].Width = 110;

            DGVListUsers.Columns[1].HeaderText = "Full Name";
            DGVListUsers.Columns[1].Width = 240;

            DGVListUsers.Columns[2].HeaderText = "User Name";
            DGVListUsers.Columns[2].Width = 140;

            DGVListUsers.Columns[3].HeaderText = "Person ID";
            DGVListUsers.Columns[3].Width = 120;

            DGVListUsers.Columns[4].HeaderText = "Phone";
            DGVListUsers.Columns[4].Width = 110;

            DGVListUsers.Columns[5].HeaderText = "Email";
            DGVListUsers.Columns[5].Width = 250;

            DGVListUsers.Columns[6].HeaderText = "Is Active";
            DGVListUsers.Columns[6].Width = 250;


        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = cbIsActive.Text.Trim();
            switch (cbIsActive.Text)
            {
                case "All":
                    break;
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;

            }

            if (FilterValue == "All")
                _dtUsers.DefaultView.RowFilter = "";
            else
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}]={1}", FilterColumn, FilterValue);
            lblNOusers.Text = DGVListUsers.Rows.Count.ToString();
        }

        private void txtFilterByValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CBfilterBy.Text=="User ID"||CBfilterBy.Text=="Person ID")
            {
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar);
            }
        }

        private void TSMIaddnewuser_Click(object sender, EventArgs e)
        {
            FRMaddNew_EditUser frm=new FRMaddNew_EditUser();
            frm.ShowDialog();
            FRMlistUsers_Load(null, null);
        }

        private void TSMIshowdetails_Click(object sender, EventArgs e)
        {
            if (DGVListUsers.CurrentRow!=null)
            {
                UserDetailsForm form = new UserDetailsForm((int)DGVListUsers.CurrentRow.Cells[0].Value);
                form.ShowDialog();
            }
        }

        private void TSMIeditinfo_Click(object sender, EventArgs e)
        {
            if ((DGVListUsers.CurrentRow != null))
            {
                FRMaddNew_EditUser form = new FRMaddNew_EditUser((int)(DGVListUsers.CurrentRow.Cells[0].Value));
                form.ShowDialog();
                FRMlistUsers_Load(null, null);
            }
        }

        private void TSMIdelete_Click(object sender, EventArgs e)
        {
            if (DGVListUsers.CurrentRow!=null)
            {
                if (MessageBox.Show("Are You Sure You Want to delete this User!","Delete Confirmation!",
                    MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)==DialogResult.Yes)
                {
                    Clsuser user = Clsuser.Find((int)DGVListUsers.CurrentRow.Cells[0].Value);
                    if (user.DeleteUserInfo())
                    {
                        ClsUtil.ShowSuccessMessage("User Deleted Successfully!");
                        FRMlistUsers_Load(null, null);
                        return;
                    }
                    else
                    {
                        ClsUtil.ShowErrorMessage("Failed To delete this User!");
                    }
                }
            }
        }

        private void TSMIchangePassword_Click(object sender, EventArgs e)
        {
            if (DGVListUsers.CurrentRow!=null)
            {

                FrmChangePassword frm = new FrmChangePassword((int)DGVListUsers.CurrentRow.Cells[0].Value);
                frm.ShowDialog();

            }

        }

      

        private void DGVListUsers_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {

            UserDetailsForm frm = new UserDetailsForm((int)DGVListUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void DGVListUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UserDetailsForm frm = new UserDetailsForm((int)DGVListUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
