using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Business
{
    public class ClsCountry
    {
        public int? CountryID { get; set; }
        public string CountryName { get; set; }

        public ClsCountry()
        {
            CountryID = -1;
            CountryName = string.Empty;
        }
        public ClsCountry(int countryID, string countryName)
        {
            CountryID = countryID;
            CountryName = countryName;
        }

        public static ClsCountry GetCountryInfoByID(int id)
        {
            string CountryName = "";
            if (HMS_DataAccess.ClsCountryData.GetCountryInfoByID(id, ref CountryName))
            {
                return new ClsCountry(id, CountryName);
            }
            else
            {
                return null;
            }
        }
        public static ClsCountry GetCountryInfoByName(string Name)
        {
            int CountryID =-1;
            if (HMS_DataAccess.ClsCountryData.GetCountryInfoByName(Name, ref CountryID))
            {
                return new ClsCountry(CountryID, Name);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetAllCountries()
        {
            return HMS_DataAccess.ClsCountryData.GetAllCountries();
        }

    }
}
