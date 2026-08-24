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




    }
}
