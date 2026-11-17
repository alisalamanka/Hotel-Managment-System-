
using ClsGlobalClasses;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HMS_DataAccess
{
    public class ClsStayData
    {
        public static bool GetStayInfoByID(
            int stayID,
            ref int guestID,
            ref int roomID,
            ref int reservationID,
            ref int userID,
            ref DateTime actualCheckIn,
            ref DateTime actualCheckOut,
            ref short status,
            ref string notes)
        {
            bool isFound = false;

            try
            {
                string connString =
                    ConfigurationManager.AppSettings["ConnectionString"];

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand(
                        "SP_GetStayInfoByID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@StayID", stayID);

                        conn.Open();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                isFound = true;

                                guestID = Convert.ToInt32(dr["CostomerID"]);
                                roomID = Convert.ToInt32(dr["GuestRoomID"]);
                                reservationID = Convert.ToInt32(dr["ReservationID"]);
                                userID = Convert.ToInt32(dr["CreatedByUserID"]);

                                actualCheckIn = Convert.ToDateTime(dr["ActualCheckIn"]);

                                actualCheckOut = dr["ActualCheckOut"] == DBNull.Value
                                    ? DateTime.MinValue
                                    : Convert.ToDateTime(dr["ActualCheckOut"]);

                                status = Convert.ToInt16(dr["Status"]);
                                notes = dr["Notes"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;

                ClsUtil.ClsLogger.LogError(
                    $"Failed to get stay with id = {stayID}", ex);
            }

            return isFound;
        }

        public static DataTable GetAllStays()
        {
            DataTable dt = new DataTable();

            try
            {
                string connString =
                    ConfigurationManager.AppSettings["ConnectionString"];

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand(
                        "SP_GetAllStays", conn))
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
                ClsUtil.ClsLogger.LogError(
                    "Failed to get all stays", ex);
            }

            return dt;
        }

        public static int? AddNewStay(
            int guestID,
            int roomID,
            int reservationID,
            int userID,
            DateTime actualCheckIn,
            DateTime? actualCheckOut,
            int status,
            string notes)
        {
            int? stayID = null;

            try
            {
                string connString =
                    ConfigurationManager.AppSettings["ConnectionString"];

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand(
                        "SP_AddStay", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter outputParameter =
                            new SqlParameter("@newStayID", SqlDbType.Int);

                        outputParameter.Direction =
                            ParameterDirection.Output;

                        cmd.Parameters.Add(outputParameter);

                        cmd.Parameters.AddWithValue("@guestID", guestID);
                        cmd.Parameters.AddWithValue("@RoomID", roomID);
                        cmd.Parameters.AddWithValue("@ReservationID", reservationID);
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        cmd.Parameters.AddWithValue("@ActualCheckin", actualCheckIn);

                        cmd.Parameters.AddWithValue(
                            "@ActualCheckout",
                            actualCheckOut.HasValue
                                ? (object)actualCheckOut.Value
                                : DBNull.Value);

                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.Parameters.AddWithValue("@Notes",
                            string.IsNullOrWhiteSpace(notes)
                                ? (object)DBNull.Value
                                : notes);

                        conn.Open();

                        cmd.ExecuteNonQuery();

                        stayID = Convert.ToInt32(outputParameter.Value);
                    }
                }
            }
            catch (Exception ex)
            {
                stayID = null;

                ClsUtil.ClsLogger.LogError(
                    "Failed to add new stay", ex);
            }

            return stayID;
        }

        public static bool UpdateStay(
            int stayID,
            int guestID,
            int roomID,
            int reservationID,
            int userID,
            DateTime actualCheckIn,
            DateTime? actualCheckOut,
            int status,
            string notes)
        {
            bool isUpdated = false;

            try
            {
                string connString =
                    ConfigurationManager.AppSettings["ConnectionString"];

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand(
                        "SP_UpdateStay", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter PR = new SqlParameter("@Updated", SqlDbType.Bit);
                        PR.Direction = ParameterDirection.Output;
                        cmd.Parameters.AddWithValue("@StayID", stayID);
                        cmd.Parameters.AddWithValue("@GuestID", guestID);
                        cmd.Parameters.AddWithValue("@RoomID", roomID);
                        cmd.Parameters.AddWithValue("@ReservationID", reservationID);
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        cmd.Parameters.AddWithValue("@ActualCheckin", actualCheckIn);

                        cmd.Parameters.AddWithValue(
                            "@ActualCheckout",
                            actualCheckOut.HasValue
                                ? (object)actualCheckOut.Value
                                : DBNull.Value);
                        cmd.Parameters.Add(PR);

                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.Parameters.AddWithValue("@Notes",
                            string.IsNullOrWhiteSpace(notes)
                                ? (object)DBNull.Value
                                : notes);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        int UpdatedBit = Convert.ToInt16(PR.Value);
                        isUpdated = UpdatedBit == 1;
                    }
                }
            }
            catch (Exception ex)
            {
                isUpdated = false;

                ClsUtil.ClsLogger.LogError(
                    $"Failed to update stay with id = {stayID}", ex);
            }

            return isUpdated;
        }

        public static bool DeleteStay(int stayID)
        {
            bool deleted = false;

            try
            {
                string connString =
                    ConfigurationManager.AppSettings["ConnectionString"];

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand(
                        "SP_DeleteStay", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@StayID", stayID);

                        conn.Open();

                        deleted = cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                deleted = false;

                ClsUtil.ClsLogger.LogError(
                    $"Failed to delete stay with id = {stayID}", ex);
            }

            return deleted;
        }

        public static bool CancelStay(int StayID, ref Exception e)
        {
            bool Canceled = false;
            try
            {
                string Connstring = ConfigurationManager.AppSettings["ConnectionString"];
                using (SqlConnection cnn = new SqlConnection(Connstring))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_CancelStay", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter PR = new SqlParameter("@Canceled", SqlDbType.Bit);
                        PR.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(PR);
                        cmd.Parameters.AddWithValue("@StayID", StayID);

                        cmd.ExecuteNonQuery();

                        Canceled = Convert.ToByte(PR.Value) == 1;
                    }
                }
            }
            catch (Exception ex)
            {
                e = ex;
                return false;
            }
            return Canceled;
        }
    }
}
