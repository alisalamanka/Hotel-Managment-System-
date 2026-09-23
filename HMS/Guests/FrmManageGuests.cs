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

namespace HMS.Guests
{
    public partial class FrmManageGuests : Form
    {
        private static DataTable _dtGuests = ClsGuest.GetAllGuests();
        private static DataTable _dtCurrentPage = _dtGuests.Clone();
        private static int _CurrentPage = 1;
        private static int _TotalPages;
        private static short _PageSize = 7;

        private void _LoadCurrentPage()
        {
            int StartIndex = (_CurrentPage - 1) * _PageSize;
            int EndIndex = Math.Min(StartIndex + _PageSize, _dtGuests.Rows.Count);
            _dtCurrentPage.Rows.Clear();
            for (int i = StartIndex; i < EndIndex; i++)
            {
                _dtCurrentPage.ImportRow(_dtGuests.Rows[i]);
            }
            DGVListGuests.DataSource = _dtCurrentPage;
            lblNOusers.Text = _dtCurrentPage.Rows.Count.ToString();

        }

        private void _UpdatePaginationButtons()
        {
            btnNext.Enabled = _CurrentPage < _TotalPages;
            btnPrev.Enabled = _CurrentPage > 1;
        }

        private void _RefreshPagination()
        {
            _TotalPages = (int)Math.Ceiling((double)(_dtGuests.Rows.Count / _PageSize));
            _LoadCurrentPage();
            _UpdatePaginationButtons();
        }

        public FrmManageGuests()
        {
            InitializeComponent();
        }

        private void FrmManageGuests_Load(object sender, EventArgs e)
        {

            _CurrentPage = 1;
            CBfilterBy.SelectedIndex = 0;

            cbIsActive.Visible = false;
            txtFilterByValue.Visible = false;

            _RefreshPagination();

        }

        private void CBfilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Filter = CBfilterBy.Text.Trim();

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
                _dtCurrentPage.DefaultView.RowFilter = "";

                _LoadCurrentPage();
            }
        }

        private void txtFilterByValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (CBfilterBy.Text)
            {
                case "Guest ID":
                    FilterColumn = "GuestID";
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
            }


            if (string.IsNullOrWhiteSpace(txtFilterByValue.Text) ||
                CBfilterBy.Text == "None")
            {
                _dtGuests.DefaultView.RowFilter = "";
                _LoadCurrentPage();
            }
            else
            {
                string Value =
                    txtFilterByValue.Text.Trim();

                if (CBfilterBy.Text == "Guest ID" ||
                    CBfilterBy.Text == "Person ID")
                {
                    _dtGuests.DefaultView.RowFilter =
                        $"[{FilterColumn}] = {Value}";
                }
                else
                {
                    _dtGuests.DefaultView.RowFilter =
                        $"[{FilterColumn}] LIKE '{Value}%'";
                }
            }
            DGVListGuests.DataSource = _dtGuests;
            lblNOusers.Text =
                DGVListGuests.Rows.Count.ToString();
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterValue = cbIsActive.Text.Trim();

            if (FilterValue == "All")
            {
                _dtGuests.DefaultView.RowFilter = "";
            }
            else if (FilterValue == "Yes")
            {
                _dtGuests.DefaultView.RowFilter =
                    "[IsActive] = 1";
            }
            else if (FilterValue == "No")
            {
                _dtGuests.DefaultView.RowFilter =
                    "[IsActive] = 0";
            }

            DGVListGuests.DataSource = _dtGuests;
            lblNOusers.Text =
                DGVListGuests.Rows.Count.ToString();
        }

        private void txtFilterByValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CBfilterBy.Text == "Guest ID" ||
       CBfilterBy.Text == "Person ID")
            {
                e.Handled =
                    !char.IsControl(e.KeyChar) &&
                    !char.IsDigit(e.KeyChar);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_CurrentPage < _TotalPages)
            {
                _CurrentPage++;
                _LoadCurrentPage();
            }
            _RefreshPagination();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_CurrentPage > 1)
            {
                _CurrentPage--;
                _LoadCurrentPage();
            }
            _RefreshPagination();
        }

        private void btnAddNewGuest_Click(object sender, EventArgs e)
        {
            FrmAddEditGuestForm frm = new FrmAddEditGuestForm();
            frm.ShowDialog();
            _RefreshPagination();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TSMIaddNewGuest_Click(object sender, EventArgs e)
        {
           FrmAddEditGuestForm form = new FrmAddEditGuestForm();
            form.ShowDialog();
            _RefreshPagination();
        }

        private void TSMIshowdetails_Click(object sender, EventArgs e)
        {
            if (DGVListGuests.CurrentRow != null)
            {
                int GuestID = (int)DGVListGuests.CurrentRow.Cells[0].Value;
                FrmGuestDetails drm = new FrmGuestDetails(GuestID);
                drm.ShowDialog();
            }
        }

        private void TSMIdelete_Click(object sender, EventArgs e)
        {
            if (DGVListGuests.CurrentRow != null)
            {
                if (MessageBox.Show("Are You Sure You Want To delete This Guest?", "Delete Confirmation!", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    int GuestID = (int)DGVListGuests.CurrentRow.Cells[0].Value;
                    ClsGuest Guest = ClsGuest.Find(GuestID);
                    if (Guest!=null)
                    {
                        if (Guest.DeleteGuest())
                        {
                            ClsUtil.ShowSuccessMessage("Guest Deleted Successfully!");
                            _RefreshPagination();
                            return;
                        }
                        else
                        {
                            ClsUtil.ShowErrorMessage("Failed To delete This Guest!");
                            return;
                        }
                    }
                }
            }
        }

        private void TSMIeditinfo_Click(object sender, EventArgs e)
        {
            if (DGVListGuests.CurrentRow != null)
            {
                int GuestID = (int)DGVListGuests.CurrentRow.Cells[0].Value;
                FrmAddEditGuestForm drm = new FrmAddEditGuestForm(GuestID);
                drm.ShowDialog();
                _RefreshPagination();
            }
        }
    } 
}

