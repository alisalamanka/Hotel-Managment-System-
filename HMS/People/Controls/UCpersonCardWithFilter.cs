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

namespace HMS.People.Controls
{
    public partial class UCpersonCardWithFilter : UserControl
    {
        public UCpersonCardWithFilter()
        {
            InitializeComponent();
        }

        public event Action<int> OnPersonSelected;

        protected void RaiseOnPersonSelected(int  personID)
        {
            OnPersonSelected?.Invoke(personID);
        }

        private bool ShowAddNewPerson = true;

        public bool ShowAddnewPerson
        {
            get { return ShowAddNewPerson; }
            set
            {
                ShowAddNewPerson = value;
                btnAddNewPerson.Visible = ShowAddNewPerson;
            }

        }

        private bool _FilterEnabled = true;

        public bool FilterEnabled
        {
            get { return _FilterEnabled; }
            set
            {
                _FilterEnabled = value;
                GPFilter.Enabled = _FilterEnabled;
            }
        }

        private int? PersonID = null;
        
        public int? SelectedPersonID
        {
            get { return uCpersonCard1.PersonID; }
        }

        public ClsPerson SelectedPersonInfo
        {
            get { return uCpersonCard1.SelectedPersonInfo; }
        }

        private void Find()
        {
            string FindBytext=CBfilterby.Text.Trim();

            switch(FindBytext)
            {
                case "PersonID":
                    uCpersonCard1._LoadPersonInfo(int.Parse(txtFilterByValue.Text.Trim()));
                    break;
                case "National Number":
                    uCpersonCard1._LoadPersonInfo(txtFilterByValue.Text.Trim());
                    break;
            }

            if(FilterEnabled&& OnPersonSelected != null)
            {
                RaiseOnPersonSelected(uCpersonCard1.PersonID.Value);
            }
        }

        private void CBfilterby_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterByValue.Text = "";
            txtFilterByValue.Focus();
        }

        private void txtFilterByValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterByValue.Text.Trim()))
            {
                InputsErrorPro.SetError(txtFilterByValue, "please enter a value to find!");
                e.Cancel = true;
            }
            else
            {
                InputsErrorPro.SetError(txtFilterByValue, "");
            }
        }

        private void txtFilterByValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CBfilterby.Text=="Person ID")
            {
                e.Handled = !char.IsControl(e.KeyChar) || !char.IsDigit(e.KeyChar);
                return;
            }
            if (e.KeyChar==(char)13)
            {
                btnFind.PerformClick();

            }

        }

        public void LoadPersonInfo(int PersonID)
        {
            CBfilterby.SelectedIndex = 0;
            txtFilterByValue.Text = PersonID.ToString();
            Find();
        }

        public void LoadPersonInfo(string NatNumber)
        {
            CBfilterby.SelectedIndex = 1;
            txtFilterByValue.Text = NatNumber;
            Find();
        }

        private void UCpersonCardWithFilter_Load(object sender, EventArgs e)
        {
            CBfilterby.SelectedIndex = 0;
            txtFilterByValue.Text = "";
        }

        public void DataBackEvent(object sender,int PersonID)
        {
            CBfilterby.SelectedIndex = 0;
            txtFilterByValue.Text = PersonID.ToString();
            Find();
        }

        public void FilterFocus()
        {
            txtFilterByValue.Focus();
        }
    }
}
