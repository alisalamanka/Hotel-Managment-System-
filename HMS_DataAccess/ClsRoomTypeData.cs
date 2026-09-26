using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HMS_DataAccess
{
    public class ClsRoomTypeData
    {
        public static bool GetRoomTypeInfoByID(
            int RoomTypeID,
            ref string RoomTypeName,
            ref Exception ErrorOccurred)
        {
            string conn =
                ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(
                    "SP_GetRoomTypeInfoByID", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@RoomTypeID", RoomTypeID);

                    cnn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            RoomTypeName =
                                dr["RoomTypeName"].ToString();

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


        public static DataTable GetRoomTypesList(
            ref Exception ErrorOccurred)
        {
            string conn =
                ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(
                    "SP_GetRoomTypesList", cnn))
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


        public static bool UpdateRoomType(
            int RoomTypeID,
            string RoomTypeName,
            ref Exception ErrorOccurred)
        {
            string conn =
                ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(
                    "SP_UpdateRoomType", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@RoomTypeID", RoomTypeID);

                    cmd.Parameters.AddWithValue(
                        "@RoomTypeName", RoomTypeName);

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
    }
}