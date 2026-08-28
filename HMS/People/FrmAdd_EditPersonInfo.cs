using GlobalClasses;
using HMS_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using Guna.UI2.WinForms;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMS.Properties;

namespace HMS.People
{
    public partial class FrmAdd_EditPersonInfo : Form
    {
        public FrmAdd_EditPersonInfo()
        {
            InitializeComponent();
            _Mode = EnMode.AddNew;
        }
        public FrmAdd_EditPersonInfo(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            _Mode = EnMode.Update;
        }

        public event Action<object, int?> Databack;

        public enum EnGender
        {
            Mail=1,Female=2
        }
        public enum EnMode
        {
            AddNew=1,Update=2
        }

        private EnMode _Mode;
        private int? _PersonID;
        private ClsPerson _CurrentPerson;

        private void _FillCountries()
        {
            DataTable dtCounties=ClsCountry.GetAllCountries();
            cbContries.DataSource=dtCounties;
            cbContries.DisplayMember = "CountryName";
            cbContries.ValueMember = "CountryID";
        }

        private void _setAddNewMode()
        {
            lblAddEditPerson.Text = "Add New Person";
            _CurrentPerson=new ClsPerson();
            tbEmail.Text = "";
            tbLname.Text = "";
            TBfname.Text = "";
            tbPhone.Text = "";
            tbNationalNumber.Text = "";
            cbContries.SelectedIndex = cbContries.FindString("Morocco");
            dtpDateOfBirth.Value = dtpDateOfBirth.MinDate;
            rbMale.Checked = true;

        }
        private void _SetUpdateMode()
        {
            lblAddEditPerson.Text = "Update Person";
            if (_PersonID!=null)
            {
                _CurrentPerson = ClsPerson.Find(_PersonID.Value);
            }
            if (_CurrentPerson!=null)
            {
                TBfname.Text = _CurrentPerson.FirstName;
                tbLname.Text= _CurrentPerson.LastName;
                tbPhone.Text= _CurrentPerson.Phone;
                tbEmail.Text= _CurrentPerson.Email;
                tbNationalNumber.Text = _CurrentPerson.NationalNumber;
                if (_CurrentPerson.DateOfBirth >= dtpDateOfBirth.MinDate &&
                    _CurrentPerson.DateOfBirth <= dtpDateOfBirth.MaxDate)
                {
                    dtpDateOfBirth.Value = _CurrentPerson.DateOfBirth;
                }
                else
                {
                    dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;
                }
                cbContries.SelectedIndex = cbContries.FindString(_CurrentPerson.CountryInfo.CountryName);
                if (_CurrentPerson.Gendor==1)
                {
                    rbMale.Checked = true;
                }
                else
                {
                    rbFemale.Checked = true;
                }
                if (File.Exists(_CurrentPerson.ImagePath))
                {
                    pbPersonImage.ImageLocation=_CurrentPerson.ImagePath;
                }
            }
            else
            {
                ClsUtil.ShowErrorMessage("No Person With the given Informations!");
                return;
            }
        }

        private bool _HandlePersonImage()
        {
            string imagesFolder = ConfigurationManager.AppSettings["PersonsImages"]?.ToString();

            if (!_EnsureDirectoryExists(imagesFolder))
                return false;

            if (pbPersonImage.ImageLocation != _CurrentPerson.ImagePath)
            {
                _DeleteOldPersonImage();

                if (!string.IsNullOrEmpty(pbPersonImage.ImageLocation))
                {
                    return _CopyAndSetNewPersonImage(imagesFolder);
                }
            }

            return true;
        }

        private bool _EnsureDirectoryExists(string folderPath)
        {
            if (string.IsNullOrEmpty(folderPath))
            {
                ClsUtil.ShowErrorMessage("PersonsImages path is not configured!");
                return false;
            }

            if (!Directory.Exists(folderPath))
            {
                try
                {
                    Directory.CreateDirectory(folderPath);
                }
                catch (Exception ex)
                {
                    ClsUtil.ClsLogger.LogError("Failed to create folder: " + folderPath, ex);
                    ClsUtil.ShowErrorMessage($"An Error Accoured while Creating Folder {folderPath} => Check Event Log.");
                    return false;
                }
            }
            return true;
        }

        private void _DeleteOldPersonImage()
        {
            if (!string.IsNullOrEmpty(_CurrentPerson.ImagePath) && File.Exists(_CurrentPerson.ImagePath))
            {
                try
                {
                    File.Delete(_CurrentPerson.ImagePath);
                }
                catch (Exception ex)
                {
                    ClsUtil.ClsLogger.LogError("Failed to delete old person image", ex);
                    ClsUtil.ShowErrorMessage("An error occurred while deleting the old image. Check Event Log.");
                }
            }
        }

        private bool _CopyAndSetNewPersonImage(string targetFolder)
        {
            string sourceFile = pbPersonImage.ImageLocation;

            if (ClsUtil.CopyImageToFolder(ref sourceFile, targetFolder))
            {
                pbPersonImage.ImageLocation = sourceFile;
                return true;
            }
            else
            {
                ClsUtil.ShowErrorMessage("An error occurred while handling the image.");
                return false;
            }
        }


        private void _FillFormFeilds()
        {
            if (_Mode==EnMode.AddNew)
            {
               _setAddNewMode();
            }
            else
            {
                _SetUpdateMode();
            }
            
        }


        public void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            Guna2TextBox tb = (Guna2TextBox)sender ;
            InputsEP.SetError(tb, string.IsNullOrWhiteSpace(tb.Text) ? "This field is required." : "");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbPersonImage_Click(object sender, EventArgs e)
        {

        }

        private void FrmAdd_EditPersonInfo_Load(object sender, EventArgs e)
        {
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;
            _FillCountries();
            if (_Mode == EnMode.AddNew)
                _setAddNewMode();
            else
                _SetUpdateMode();

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMale.Checked&& pbPersonImage.Image != null)
            {
               pbPersonImage.Image = Resources.man;
            }
          
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFemale.Checked && pbPersonImage.Image != null)
            {
                pbPersonImage.Image = Resources.woman;
            }

        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbEmail.Text))
            {
                if (!ClsValidation.ValidateEmail(tbEmail.Text))
                {
                    InputsEP.SetError(tbEmail, "the Email address is not valide!");
                    e.Cancel = true;
                }
                else
                {
                    InputsEP.SetError(tbEmail, "");
                }
            }
            else
                return;
        }

        private void tbNationalNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbNationalNumber.Text))
            {
                InputsEP.SetError(tbNationalNumber, "National Number Is required!");
                e.Cancel = true;
            }
            else if (_Mode==EnMode.AddNew&&ClsPerson.PersonExists(tbNationalNumber.Text))
            {
                InputsEP.SetError(tbNationalNumber, "This National Number is already exists in the system!");
                e.Cancel = true;
            }
            else
            {
                InputsEP.SetError(tbNationalNumber, "");
            }
        }

        private void llblRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.Image = null;
            if (rbMale.Checked)
            {
                pbPersonImage.Image = Resources.man;
            }
            else
            {
                pbPersonImage.Image = Resources.woman;
            }
            llblRemoveImage.Visible = false;
            pbPersonImage.ImageLocation = null;
        }

        private void llblEditPersonImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OFDImages.Filter = "Image Files|*.jbg;*.jpeg;*.png;*.bmp;*.gif";
            OFDImages.FilterIndex = 1;
            OFDImages.RestoreDirectory = true;

            if (OFDImages.ShowDialog() == DialogResult.OK)
            {
                string FileName = OFDImages.FileName;
                pbPersonImage.Load(FileName);
                llblRemoveImage.Visible = true;
            }
        }

        private void _ReadPersonData()
        {
            int CountryID=Convert.ToInt32(cbContries.SelectedValue);
            _CurrentPerson.FirstName = TBfname.Text;
            _CurrentPerson.LastName = tbLname.Text;
            _CurrentPerson.CountryID = CountryID;
            _CurrentPerson.DateOfBirth=dtpDateOfBirth.Value;
            _CurrentPerson.Email = tbEmail.Text;
            _CurrentPerson.NationalNumber = tbNationalNumber.Text;
            if (rbMale.Checked)
            {
                _CurrentPerson.Gendor = (byte)EnGender.Mail;
            }
            else
            {
                _CurrentPerson.Gendor = (byte)EnGender.Female;
            }
            _CurrentPerson.Phone = tbPhone.Text;
            _CurrentPerson.ImagePath = pbPersonImage.ImageLocation;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                ClsUtil.ShowErrorMessage("Some fields are not valid ,please put the mouse over the red icon(s) to see the erros");
                return;
            }
            if (!_HandlePersonImage())
                return;
            _ReadPersonData();
            if (_CurrentPerson.Save())
            {
                lblPersonID.Text = _CurrentPerson.Id.ToString();
                lblAddEditPerson.Text = "Update Person Info";
                _Mode = EnMode.Update;
                ClsUtil.ShowSuccessMessage("Person Info Saved Successfully!");
                if (Databack != null)
                {
                    Databack(this, _CurrentPerson.Id);
                }
            }
            else
            {
                ClsUtil.ShowErrorMessage("An Error Occoured while Saving Person Info.");
            }

        }
    }
}
