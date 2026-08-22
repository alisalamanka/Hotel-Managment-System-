using GlobalClasses;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DataAccess
{
    public class ClsCountryData
    {
        public static bool GetCountryInfoByID(int countryID, ref string CountryName)
        {
            bool Isfound = false;
            try
            {
                string ConnString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_GetCountryInfoByID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CountryID", countryID);
                        conn.Open();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                Isfound = true;
                                CountryName = dr["CountryName"].ToString();
                            }
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                Isfound = false;
                ClsUtil.ClsLogger.LogError($"Failed to get country with id = {countryID}", ex);
            }

            return Isfound;
        }

        public static bool GetCountryInfoByName(string CountryNAme, ref int CountryID)
        {
            bool Isfound = false;
            try
            {
                string ConnString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_GetCountryInfoByName", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CountryName", CountryNAme);
                        conn.Open();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                Isfound = true;
                                CountryID = Convert.ToInt16(dr["CountryID"]);
                            }
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                Isfound = false;
                ClsUtil.ClsLogger.LogError($"Failed to get country with Name = {CountryNAme}", ex);
            }

            return Isfound;
        }

        public static DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();
            try
            {
                string ConnString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_GetAllCountries", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                ClsUtil.ClsLogger.LogError($"Failed to get all countries", ex);
            }

            return dt;
        }

    }
}
