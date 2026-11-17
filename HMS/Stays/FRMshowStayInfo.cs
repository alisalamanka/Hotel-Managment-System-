using System;
using System.Windows.Forms;

namespace HMS.Stays
{
    public partial class FRMshowStayInfo : Form
    {
        int? StayId;
        public FRMshowStayInfo(int Id)
        {
            InitializeComponent();
            StayId = Id;
        }


        private void FRMshowStayInfo_Load(object sender, EventArgs e)
        {
            ctrlStayInfo2.LoadStayInfo(StayId.Value);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
