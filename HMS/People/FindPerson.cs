using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    
    public partial class FrmFindPerson : Form
    {

        public event Action<object,int?> OnPersonSelected;
        public FrmFindPerson()
        {
            InitializeComponent();
        }

        //private void btnClose_Click(object sender, EventArgs e)
        //{
        //    OnPersonSelected.Invoke(this, uCpersonCardWithFilter2.SelectedPersonID);
        //}

        //private void BNclose_Click(object sender, EventArgs e)
        //{
        //    OnPersonSelected.Invoke(this, uCpersonCardWithFilter1.SelectedPersonID);

        //}
    }
}
