using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.People
{
    public partial class FrmPersonDetails : Form
    {
        public FrmPersonDetails(int?PerosnID)
        {
            InitializeComponent();
            LoadPersonDetails(PerosnID.Value);
        }

        public FrmPersonDetails(string NatNumber)
        {
            InitializeComponent();
            LoadPersonDetails(NatNumber);
        }

        public void LoadPersonDetails(int PersoID)
        {
            uCpersonCard1._LoadPersonInfo(PersoID);
        }
        public void LoadPersonDetails(string NatNumber)
        {
            uCpersonCard1._LoadPersonInfo(NatNumber);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
