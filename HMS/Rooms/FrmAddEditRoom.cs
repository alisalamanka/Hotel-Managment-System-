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

namespace HMS.Rooms
{
    public partial class FrmAddEditRoom : Form
    {
        private ClsRoom _CurrentRoomInfo;
        private int _RoomId;
        public FrmAddEditRoom()
        {
            InitializeComponent();
            _Mode = EnMode.Add;
        }
        public FrmAddEditRoom(int RoomId)
        {
            InitializeComponent();
            _RoomId = RoomId;
            _Mode = EnMode.Update;
        }

        public enum EnMode
        {
            Add=1,Update=2
        }
        private EnMode _Mode;

        private event Action<int> DataBackEventHandler;

        protected void DataBack(int RoomID)
        {
            if (DataBackEventHandler!=null)
            {
                DataBackEventHandler.Invoke(_RoomId);
            }
        }

        private void _FillRoomTypesComboBox()
        {
            DataTable RoomTypes = ClsRoomType.GetAllRoomTypes();
            CBRoomTypes.DataSource = RoomTypes;
            CBRoomTypes.ValueMember = "RoomTypeID";
            CBRoomTypes.DisplayMember = "RoomTypeName";
        }

        private void _FillStatusComboBox()
        {
            CBstatus.Items.Add(ClsRoom.EnRoomStatus.Available);
            CBstatus.Items.Add(ClsRoom.EnRoomStatus.Reserved);
            CBstatus.Items.Add(ClsRoom.EnRoomStatus.Occupied);
            CBstatus.Items.Add(ClsRoom.EnRoomStatus.Cleaning);
            CBstatus.Items.Add(ClsRoom.EnRoomStatus.Maintenance);
        }

        private void _FillInputs()
        {
            txtPricePerNight.Text = _CurrentRoomInfo.PricePerNight.ToString();
            txtRoomNumber.Text = _CurrentRoomInfo.RoomNumber.ToString();
            CBRoomTypes.SelectedValue = _CurrentRoomInfo.RoomTypeID;
            CBstatus.SelectedItem =( ClsRoom.EnRoomStatus)_CurrentRoomInfo.Status;
        }

        private void _Reset()
        {
            _CurrentRoomInfo = new ClsRoom();
            txtPricePerNight.Text = "";
            txtRoomNumber.Text = "";
            CBstatus.SelectedIndex = 0;
            CBRoomTypes.SelectedIndex = 0;

        }

        private void _ReadInputs()
        {
            _CurrentRoomInfo.PricePerNight= Convert.ToDecimal(txtPricePerNight.Text);
            _CurrentRoomInfo.RoomNumber = Convert.ToInt32(txtRoomNumber.Text);
            _CurrentRoomInfo.RoomTypeID = Convert.ToInt32(CBRoomTypes.SelectedValue);
            _CurrentRoomInfo.RoomStatus = (ClsRoom.EnRoomStatus)CBstatus.SelectedItem;

        }

        private void _SetDefaultValues()
        {
            _FillRoomTypesComboBox();
            _FillStatusComboBox();
            if (_Mode == EnMode.Update)
            {
                _CurrentRoomInfo = ClsRoom.Find(_RoomId);
                if (_CurrentRoomInfo==null)
                {
                    ClsUtil.ShowErrorMessage($"No Room With ID = {_RoomId}");
                    this.Close();
                    return;
                }

                lblRoomID.Text =_CurrentRoomInfo.GuestRoomID.ToString();
                lblTitle.Text = "Update Room";
                _FillInputs();
            }
            else
            {
                lblTitle.Text = "Add New Room";
                _Reset();
            }
        }

        private void txtPricePerNight_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPricePerNight.Text))
            {
                EPinputs.SetError(txtPricePerNight, "Please Enter The Price");
                e.Cancel=true;
            }
            else if(!ClsValidation.IsNumber(txtPricePerNight.Text))
            {
                EPinputs.SetError(txtPricePerNight, "Please Enter a Valid Price");
                e.Cancel = true;
            }
            else
            {
                EPinputs.SetError(txtPricePerNight, "");

            }
        }

        private void txtRoomNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtRoomNumber.Text))
            {
                EPinputs.SetError(txtRoomNumber, "Please Enter The Number Of The Room");
                e.Cancel = true;
            }
            else if (!ClsValidation.IsNumber(txtRoomNumber.Text))
            {
                EPinputs.SetError(txtRoomNumber, "Please Enter a Valid Room Number");
                e.Cancel = true;
            }
            else
            {
                EPinputs.SetError(txtRoomNumber, "");

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                ClsUtil.ShowErrorMessage("Some Fields are Not Valide Please Fix the Errors Before Save!");
                return;
            }
            _ReadInputs();
            if (_CurrentRoomInfo.Save())
            {
                if (_Mode==EnMode.Add)
                {
                    _Mode = EnMode.Update;
                    lblTitle.Text = "Update Room";
                }
                ClsUtil.ShowSuccessMessage("Room Saved Successfully!");
            }
            else
            {
                ClsUtil.ShowErrorMessage("Failed To save This Room!");
                return;
            }
        }

        private void FrmAddEditRoom_Load(object sender, EventArgs e)
        {
            _SetDefaultValues();
        }
    }
}
