using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HMS_DataAccess
{
    public class ClsGuestTypeData
    {
        public static int? AddNewGuestType(
            string GuestTypeName,
            ref Exception ErrorOccurred)
        {
            string conn =
                ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(
                    "SP_AddNewGuestType", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@GuestTypeName", GuestTypeName);

                    cnn.Open();

                    object result = cmd.ExecuteScalar();

                    if (result == null || result == DBNull.Value)
                        return null;

                    return Convert.ToInt32(result);
                }
            }
            catch (Exception e)
            {
                ErrorOccurred = e;
                return null;
            }
        }

        public static bool UpdateGuestTypeName(
            int GuestTypeID,
            string GuestTypeName,
            ref Exception ErrorOccurred)
        {
            string conn =
                ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(
                    "SP_UpdateGuestTypeName", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@GuestTypeID", GuestTypeID);

                    cmd.Parameters.AddWithValue(
                        "@GuestTypeName", GuestTypeName);

                    cnn.Open();

                    int RowsAffected =
                        Convert.ToInt32(cmd.ExecuteScalar());

                    return RowsAffected > 0;
                }
            }
            catch (Exception e)
            {
                ErrorOccurred = e;
                return false;
            }
        }

        public static bool GetGuestTypeInfoByID(
            int GuestTypeID,
            ref string GuestTypeName,
            ref Exception ErrorOccurred)
        {
            string conn =
                ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(
                    "SP_GetGuestTypeInfoByID", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@GuestTypeID", GuestTypeID);

                    cnn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            GuestTypeName =
                                dr["GuestTypeName"].ToString();

                            return true;
                        }

                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                ErrorOccurred = e;
                return false;
            }
        }

        public static bool GetGuestTypeInfoByName(
            string GuestTypeName,
            ref int GuestTypeID,
            ref Exception ErrorOccurred)
        {
            string conn =
                ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(
                    "SP_GetGuestTypeInfoByName", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@GuestTypeName", GuestTypeName);

                    cnn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            GuestTypeID =
                                Convert.ToInt32(dr["GuestTypeID"]);

                            return true;
                        }

                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                ErrorOccurred = e;
                return false;
            }
        }

        public static DataTable GetGuestTypesList(
            ref Exception ErrorOccurred)
        {
            string conn =
                ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(
                    "SP_GetGuestTypesList", cnn))
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
            catch (Exception e)
            {
                ErrorOccurred = e;
                return null;
            }
        }
    }
}