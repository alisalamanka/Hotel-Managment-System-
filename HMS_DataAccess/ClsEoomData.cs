using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HMS_DataAccess
{
    public class ClsGuestRoomData
    {
        public static bool GetRoomInfoByID(
            int GuestRoomID,
            ref int RoomTypeID,
            ref decimal PricePerNight,
            ref int RoomNumber,
            ref short Status,
            ref Exception ErrorOccurred)
        {
            string conn =
                ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(
                    "SP_GetRoomInfoByID", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@GuestRoomID", GuestRoomID);

                    cnn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            RoomTypeID =
                                (int)dr["RoomTypeID"];

                            PricePerNight =
                                (decimal)dr["PricePerNight"];

                            RoomNumber =
                                (int)dr["RoomNumber"];

                            Status =
                                Convert.ToInt16(dr["Status"]);

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


        public static bool GetRoomInfoByNumber(
            int RoomNumber,
            ref int GuestRoomID,
            ref int RoomTypeID,
            ref decimal PricePerNight,
            ref short Status,
            ref Exception ErrorOccurred)
        {
            string conn =
                ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(
                    "SP_GetRoomInfoByNumber", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@RoomNumber", RoomNumber);

                    cnn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            GuestRoomID =
                                (int)dr["GuestRoomID"];

                            RoomTypeID =
                                (int)dr["RoomTypeID"];

                            PricePerNight =
                                (decimal)dr["PricePerNight"];

                            Status =
                                Convert.ToInt16(dr["Status"]);

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


        public static int? AddNewRoom(
            int RoomTypeID,
            decimal PricePerNight,
            int RoomNumber,
            short Status,
            ref Exception ErrorOccurred)
        {
            string conn =
                ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(
                    "SP_AddNewRoom", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@RoomTypeID", RoomTypeID);

                    cmd.Parameters.AddWithValue(
                        "@PricePerNight", PricePerNight);

                    cmd.Parameters.AddWithValue(
                        "@RoomNumber", RoomNumber);

                    cmd.Parameters.AddWithValue(
                        "@Status", Status);

                    cnn.Open();

                    return Convert.ToInt32(
                        cmd.ExecuteScalar());
                }
            }
            catch (Exception e)
            {
                ErrorOccurred = e;
                return null;
            }
        }


        public static bool UpdateRoom(
            int GuestRoomID,
            int RoomTypeID,
            decimal PricePerNight,
            int RoomNumber,
            short Status,
            ref Exception ErrorOccurred)
        {
            string conn =
                ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(
                    "SP_UpdateRoom", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@GuestRoomID", GuestRoomID);

                    cmd.Parameters.AddWithValue(
                        "@RoomTypeID", RoomTypeID);

                    cmd.Parameters.AddWithValue(
                        "@PricePerNight", PricePerNight);

                    cmd.Parameters.AddWithValue(
                        "@RoomNumber", RoomNumber);

                    cmd.Parameters.AddWithValue(
                        "@Status", Status);

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


      


        public static DataTable GetRoomsList(
            ref Exception ErrorOccurred)
        {
            string conn =
                ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(
                    "SP_GetRoomsList", cnn))
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


        public static bool UpdateRoomStatus(
            int GuestRoomID,
            short Status,
            ref Exception ErrorOccurred)
        {
            string conn =
                ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(
                    "SP_UpdateRoomStatus", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@GuestRoomID", GuestRoomID);

                    cmd.Parameters.AddWithValue(
                        "@Status", Status);

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


        public static bool RoomExistsByNumber(
            int RoomNumber,
            ref Exception ErrorOccurred)
        {
            string conn =
                ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(
                    "SP_RoomExistsByNumber", cnn))
                {ccccc  xbx
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@RoomNumber", RoomNumber);

                    cnn.Open();

                    return Convert.ToInt32(
                        cmd.ExecuteScalar()) > 0;
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