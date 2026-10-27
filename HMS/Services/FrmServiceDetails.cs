using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.Services
{
    public partial class FrmServiceDetails : Form
    {
        private int _id;
        public FrmServiceDetails(int ID)
        {
            InitializeComponent();
            _id = ID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmServiceDetails_Load(object sender, EventArgs e)
        {
            ucServiceInfo1.LoadServiceInfo(_id);
        }
    }
}
