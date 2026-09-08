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

namespace HMS.Users.UserControls
{
    public partial class ctrlUserInfoWithFilter : UserControl
    {
        private Clsuser _currentUserInfo;
        private int? _currentUserId;

        public Clsuser CurrentUserInfo
        {
            get
            {
                return _currentUserInfo;
            }
        }
        public int CurrentUserId
        {
            get
            {
                return _currentUserId.Value;
            }
          
        }
        public ctrlUserInfoWithFilter()
        {
            InitializeComponent();
        }

        private void ctrlUserInfo1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
