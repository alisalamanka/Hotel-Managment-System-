using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Runtime.InteropServices.WindowsRuntime;

namespace HMS_DataAccess
{
    public class ClsUserData
    {
        public static bool GetUserInfoByID(int ID, ref int PersonID, ref string UserName, ref string Password, ref byte isActive, ref Exception ErrorAccoured)
        {
            string conn = ConfigurationManager.AppSettings["ConnectionString"];
            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_GetUserInfoByID", cnn))
                    {
                        cnn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@userID", ID);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                PersonID = (int)dr["PersonID"];
                                UserName = dr["UserName"].ToString();
                                Password = dr["Password"].ToString();
                                isActive = (byte)dr["isActive"];
                            }
                            else
                            {
                                return false;
                        }
                    }
                }
            }
            }
            catch (Exception e)
            {
                ErrorAccoured = e;
                return false;
            }
            return true;
        }

        public static bool GetUserInfoBynameAndPasssword(string UserName, string Password, ref int ID, ref int PersonID, ref byte isActive, ref Exception ErrorAccoured)
        {
            string conn = ConfigurationManager.AppSettings["ConnectionString"];
            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_GetUserInfoByUserNameAndPassword", cnn))
                    {
                        cnn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@userName", UserName);
                        cmd.Parameters.AddWithValue("@password", Password);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                ID = (int)dr["UserID"];
                                PersonID = (int)dr["PersonID"];
                                isActive = (byte)dr["isActive"];
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                ErrorAccoured = e;
                return false;
            }
        }


        public static bool UpdateUserInfo(int PersonID,string Fname, string Lname, string NatNumber, DateTime DateOfBirth, string Phone, string Email, byte Gender, string ImagePath,
            int CountryID,   string UserName,  string Password,  bool IsActive,  int UserID,  ref Exception ErrorAccoured)
        {
            string conn = ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_UpdateUserInfo", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@PersonID", PersonID);
                        cmd.Parameters.AddWithValue("@Fname", Fname);
                        cmd.Parameters.AddWithValue("@Lname", Lname);
                        cmd.Parameters.AddWithValue("@NatNumber", NatNumber);
                        cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        cmd.Parameters.AddWithValue("@Phone", Phone);
                        cmd.Parameters.AddWithValue("@Email", Email);
                        cmd.Parameters.AddWithValue("@Gender", Gender);
                        cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
                        cmd.Parameters.AddWithValue("@CountryID", CountryID);
                        cmd.Parameters.AddWithValue("@UserName", UserName);
                        cmd.Parameters.AddWithValue("@Password", Password);
                        cmd.Parameters.AddWithValue("@isActive", IsActive);
                        cmd.Parameters.AddWithValue("@UserID", UserID);

                        cnn.Open();

                        cmd.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                ErrorAccoured = e;
                return false;
            }
        }

        public static bool DeleteUser(int UserID, ref Exception ErrorAccoured)
        {
            string conn = ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_Delete_User", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@UserID", UserID);

                        cnn.Open();

                        int RowsAffected = Convert.ToInt32(cmd.ExecuteScalar());

                        return RowsAffected > 0;
                    }
                }
            }
            catch (Exception e)
            {
                ErrorAccoured = e;
                return false;
            }
        }

        public static int? AddNewUser(  string UserName,  string Password, int PeronID, bool IsActive, ref Exception ErrorAccoured)
        {
            string conn = ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_AddNewUser", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@UserName", UserName);
                        cmd.Parameters.AddWithValue("@Password", Password);
                        cmd.Parameters.AddWithValue("@isActive", IsActive);
                        cmd.Parameters.AddWithValue("@PersonID", PeronID);

                        cnn.Open();

                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception e)
            {
                ErrorAccoured = e;
                return null;
            }
        }

        public static DataTable GetUsersList(ref Exception ErrorAccoured)
        {
            string conn = ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_UsersList", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cnn.Open();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);

                            return dt;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                ErrorAccoured = e;
                return null;
            }
        }




    }
}
