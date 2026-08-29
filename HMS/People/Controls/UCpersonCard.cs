using GlobalClasses;
using HMS.Properties;
using HMS_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.People.Controls
{
    public partial class UCpersonCard : UserControl
    {
        public UCpersonCard()
        {
            InitializeComponent();
        }

        private ClsPerson _Person;
        private int? _PersonID;


        public int? PersonID 
        {
            get { return _PersonID; }
        }

        public ClsPerson SelectedPersonInfo {  get { return _Person; } }

        private void FillPersonInfo()
        {
            LblPersonID.Text = _Person.Id.ToString();
            lblCountry.Text = _Person.CountryInfo.CountryName;
            lblDOBirth.Text = _Person.DateOfBirth.ToShortDateString();
            lblEmail.Text = _Person.Email;
            lblPhone.Text = _Person.Phone;
            lblFullname.Text = _Person.FullName;
            lblGendor.Text=_Person.Gendor == 0 ? "Male" : "Female";
            lblNationalNumber.Text = _Person.NationalNumber;
            _LoadPersonImage();
        }

        public void _LoadPersonInfo(int  personID)
        {
            _Person = ClsPerson.Find(personID);
            if (_Person.Id!=null)
            {
                _PersonID = _Person.Id;
                FillPersonInfo();
            }
            else
            {
                ClsUtil.ShowErrorMessage($"No Person With ID = {personID}");
            }
        }

        public void _LoadPersonInfo(string NatNumber)
        {
            _Person = ClsPerson.Find(NatNumber);
            if (_Person.Id != null)
            {
                _PersonID = _Person.Id;
                FillPersonInfo();
            }
            else
            {
                ClsUtil.ShowErrorMessage($"No Person With National Number = {NatNumber}");
            }
        }
        private void _LoadPersonImage()
        {
            if (string.IsNullOrEmpty(_Person.ImagePath))
            {
                if (_Person.Gendor==0)
                {
                    CPBPersonImage.Image = Resources.man;
                }
                else
                    CPBPersonImage.Image= Resources.woman;
                
            }
            else
            {
                if (File.Exists(_Person.ImagePath))
                {
                    CPBPersonImage.Image = Image.FromFile(_Person.ImagePath);
                }
                else
                    ClsUtil.ShowErrorMessage($"Could not Find the image With path = {_Person.ImagePath}");
                return;
            }
        }
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void llblEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAdd_EditPersonInfo frm = new FrmAdd_EditPersonInfo(_Person.Id.Value);
            frm.ShowDialog();
        }
    }
}
