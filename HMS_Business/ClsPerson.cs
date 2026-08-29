using HMS_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Business
{
    public class ClsPerson
    {
        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int CountryID { get; set; }

        public ClsCountry CountryInfo { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string NationalNumber { get; set; }
       public string ImagePath { get; set; }

        public byte Gendor { get; set; }
        public bool IsActive { get; set; }

        public enum EnMode
        {
            AddNew=0,Update=1
        }

        public EnMode Mode { get; set; }
        public ClsPerson()
        {
            Id = null;
            FirstName = string.Empty;
            LastName = string.Empty;
            DateOfBirth = DateTime.Now;
            Phone = string.Empty;
            Email = string.Empty;
            NationalNumber = string.Empty;
            Gendor = 0;
            ImagePath = string.Empty;
            IsActive = false;
            Mode = EnMode.AddNew;
        }

        public ClsPerson(int? id, string firstName, string lastName, DateTime dateOfBirth,byte gendor, string phone, string email, string nationalNumber,int countryID, string imagePath, bool isActive)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            FullName = FirstName + " " + LastName;
            DateOfBirth = dateOfBirth;
            Phone = phone;
            Email = email;
            Gendor = gendor;
            CountryID = countryID;
            CountryInfo = ClsCountry.GetCountryInfoByID(countryID);
            NationalNumber = nationalNumber;
            ImagePath = imagePath;
            IsActive = isActive;
            Mode = EnMode.Update;
        }

        public static bool PersonExists(int id)
        {
            return ClsPersonsData.PersonExistsByID(id);
        }


        public int? AddNewPerson()
        {
            return ClsPersonsData.AddNewPerson(FirstName, LastName, DateOfBirth, Phone,CountryID, NationalNumber,Gendor,Email, ImagePath);
        }

        public static bool PersonExists(string nationalNumber)
        {
            return ClsPersonsData.PersonExistsByNatNumber(nationalNumber);
        }

        public static ClsPerson Find(int id)
        {
            string Fname="", Lname = "", Phone = "", Email = "", NatNumber = "", ImagePath = "";
            int CountryID = -1;
            bool isActive = false;
            byte gendor = 0;
            DateTime DateOfBirth = DateTime.Now;

            if (ClsPersonsData.GetPersonInfoByID(id, ref Fname, ref Lname, ref DateOfBirth,ref gendor, ref Phone, ref Email, ref NatNumber, ref ImagePath,ref CountryID,ref isActive))
            {
                return new ClsPerson(id, Fname, Lname, DateOfBirth,gendor, Phone, Email, NatNumber,CountryID, ImagePath,isActive);
            }
            else
            {
                return null;
            }

        }

        public static ClsPerson Find(string NatNumber)
        {
            string Fname = "", Lname = "", Phone = "", Email = "", ImagePath = "";
            int CountryID = -1,PersonID=-1;
            bool isActive = false;
            byte gendor = 0;
            DateTime DateOfBirth = DateTime.Now;

            if (ClsPersonsData.GetPersonInfoByNatNumber(NatNumber,ref Fname,ref Lname,ref PersonID, ref DateOfBirth,ref gendor, ref Phone, ref Email, ref ImagePath, ref CountryID, ref isActive))
            {
                return new ClsPerson(PersonID, Fname, Lname, DateOfBirth,gendor, Phone, Email, NatNumber,CountryID, ImagePath, isActive);
            }
            else
            {
                return null;
            }

        }

        public static DataTable GetAllPersons()
        {
            return ClsPersonsData.GetAllPersons();
        }

        public bool deletePerson()
        {
            return ClsPersonsData.DeletePerson(Id.Value);
        }

        public bool UpdatePerson()
        {
            return ClsPersonsData.UpdatePerson(Id.Value, FirstName, LastName, DateOfBirth,Gendor, Phone,Email, CountryID, NationalNumber, ImagePath);
        }

        public bool Save()
        {
            switch(Mode)
            {
                case EnMode.AddNew:
                    {
                        Id = AddNewPerson();
                        Mode = EnMode.Update;
                        return Id != null;
                    }
                case EnMode.Update:
                    {
                        return UpdatePerson();
                    }
                default:
                    return false;
            }
        }

    }
}
