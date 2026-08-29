using GlobalClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Security.Policy;
using System.Data;

namespace HMS_DataAccess
{
    public class ClsPersonsData
    {
        public static bool GetPersonInfoByID(int personID, ref string Fname, ref string Lname, ref DateTime DateOfBirth,
           ref byte Gendor , ref string Phone, ref string Email, ref string NatNumber, ref string imagePath, ref int CountryID, ref bool IsActive)
        {

            bool Isfound = false;
            try
            {
                string ConnString = ConfigurationManager.AppSettings["ConnectionString"];
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_FindPersonByID", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PersonID", personID);
                        conn.Open();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                Isfound = true;
                                Fname = dr["FirstName"].ToString();
                                Lname = dr["LastName"].ToString();
                                DateOfBirth = Convert.ToDateTime(dr["DateOfBirth"]);
                                Gendor = Convert.ToByte(dr["Gendor"]);
                                Phone = dr["Phone"].ToString();
                                imagePath = dr["imagePath"] == DBNull.Value ? string.Empty : dr["imagePath"].ToString();
                                Email = dr["Email"] == DBNull.Value ? string.Empty : dr["Email"].ToString();
                                NatNumber = dr["NationalNo"].ToString();
                                CountryID = Convert.ToInt32(dr["CountryID"]);
                                IsActive = Convert.ToBoolean(dr["IsActive"]);
                            }
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                Isfound = false;
                ClsUtil.ClsLogger.LogError($"Failed to get person with id = {personID}", ex);
            }

            return Isfound;



        }

        public static bool GetPersonInfoByNatNumber(string NatNumber,ref string Fname,ref string Lname, ref int PersonID, ref DateTime DateOfBirth,
            ref byte Gendor,ref string Phone, ref string Email, ref string imagePath, ref int CountryID, ref bool IsActive)
        {

            bool Isfound = false;
            try
            {
                string ConnString = ConfigurationManager.AppSettings["ConnectionString"];

                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_FindPersonByName", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NatNumber", NatNumber);
                        conn.Open();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                Isfound = true;
                                PersonID = Convert.ToInt16(dr["PersonID"]);
                                Fname = dr["FirstName"].ToString();
                                Lname = dr["LastName"].ToString();
                                DateOfBirth = Convert.ToDateTime(dr["DateOfBirth"]);
                                Gendor = Convert.ToByte(dr["Gendor"]);
                                Phone = dr["Phone"].ToString();
                                imagePath = dr["imagePath"] == DBNull.Value ? string.Empty : dr["imagePath"].ToString();
                                Email = dr["Email"] == DBNull.Value ? string.Empty : dr["Email"].ToString();
                                CountryID = Convert.ToInt32(dr["CountryID"]);
                                IsActive = Convert.ToBoolean(dr["IsActive"]);
                            }
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                Isfound = false;
                ClsUtil.ClsLogger.LogError($"Failed to get person with National Number = {NatNumber}", ex);
            }

            return Isfound;



        }

        public static int? AddNewPerson(string Fname, string Lname, DateTime dateOfbirth, string phone, int CountryID, string NatNumber,byte Gendor, string Email = null, string EmagePath = null)
        {
            int? PersonID = null;

            try
            {
                string ConnString = ConfigurationManager.AppSettings["ConnectionString"];
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_AddNewPerson", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@FirstName", Fname);
                        cmd.Parameters.AddWithValue("@LastName", Lname);
                        cmd.Parameters.AddWithValue("@DateOfBirth", dateOfbirth);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@CountryID", CountryID);
                        cmd.Parameters.AddWithValue("@NatNumber", NatNumber);
                        cmd.Parameters.AddWithValue("@Gendor", Gendor);
                        if (string.IsNullOrEmpty(Email))
                            cmd.Parameters.AddWithValue("@Email", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@Email", Email);
                        if (string.IsNullOrEmpty(EmagePath))
                            cmd.Parameters.AddWithValue("@imagePath", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@imagePath", EmagePath);

                        conn.Open();
                        PersonID = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                }
            }
            catch (Exception ex)
            {
                PersonID = null;
                ClsUtil.ClsLogger.LogError($"Failed to add new person with National Number = {NatNumber}", ex);
            }
            return PersonID;

        }

        public static bool DeletePerson(int PersonID)
        {
            bool IsDeleted = false;
            try
            {
                string ConnString = ConfigurationManager.AppSettings["ConnectionString"];
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_DeletePerson", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PersonID", PersonID);
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        IsDeleted = rowsAffected > 0;
                    }

                }
            }
            catch (Exception ex)
            {
                IsDeleted = false;
                ClsUtil.ClsLogger.LogError($"Failed to delete person with ID = {PersonID}", ex);
            }
            return IsDeleted;

        }

        public static bool UpdatePerson(int PersonID, string Fname, string Lname, DateTime DateOfBirth,byte Gendor,string Phone, string Email, int CountryID, string NatNumber, string ImagePAth)
        {
            int RowsAffected = 0;

            try
            {
                string ConnString = ConfigurationManager.AppSettings["ConnectionString"];
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_UpdatePersonInfo", conn))
                    {
                        cmd.CommandType =CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PersonID", PersonID);
                        cmd.Parameters.AddWithValue("@FirstName", Fname);
                        cmd.Parameters.AddWithValue("@LastName", Lname);
                        cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        cmd.Parameters.AddWithValue("@Phone", Phone);
                        cmd.Parameters.AddWithValue("@CountryID", CountryID);
                        cmd.Parameters.AddWithValue("@NatNumber", NatNumber);
                        cmd.Parameters.AddWithValue("@Gendor", Gendor);
                        if (string.IsNullOrEmpty(Email))
                            cmd.Parameters.AddWithValue("@Email", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@Email", Email);
                        if (string.IsNullOrEmpty(ImagePAth))
                            cmd.Parameters.AddWithValue("@imagePath", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@imagePath", ImagePAth);

                        conn.Open();
                        RowsAffected = cmd.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {
                
                ClsUtil.ClsLogger.LogError($"Failed to Update  person with ID = {PersonID}", ex);
                return false;
            }
            return RowsAffected>0;
        }

        public static DataTable GetAllPersons()
        {
            string ConnString = ConfigurationManager.AppSettings["ConnectionString"];
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_GetAllPersons", conn))
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
                ClsUtil.ClsLogger.LogError($"Failed to get all persons", ex);
            }
            return dt;



        }

        public static bool PersonExistsByID(int ID)
        {
            string Cnn = ConfigurationManager.AppSettings["ConnectionString"];
            bool exists = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(Cnn))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("Sp_PersonExistsByID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PersonID", ID);
                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            exists = rd.HasRows;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                exists = false;
                ClsUtil.ClsLogger.LogError($"Failed to check if person exists with ID = {ID}", ex);
            }
            return exists;
        }

        public static bool PersonExistsByNatNumber(string NatNumber)
        {
            string Cnn = ConfigurationManager.AppSettings["ConnectionString"];
            bool exists = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(Cnn))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("Sp_PersonExistsByNatNumber", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NatNumber", NatNumber);
                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            exists = rd.HasRows;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                exists = false;
                ClsUtil.ClsLogger.LogError($"Failed to check if person exists with National Number = {NatNumber}", ex);
            }
            return exists;
        }



    }
}