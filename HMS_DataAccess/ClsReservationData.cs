using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DataAccess
{
    public class ClsReservationData
    {
        public static bool GetReservationInfoByID(
     int ReservationID,
     ref int UserID,
     ref int GuestID,
     ref int RoomID,
     ref int GuestTypeID,
     ref int NumberOfGuests,
     ref DateTime ReservationDate,
     ref DateTime PlannedCheckin,
     ref DateTime PlannedCheckOut,
     ref decimal PricePerNight,
     ref decimal TotalAmount,
     ref int Status,
     ref string Notes,
     ref Exception ErrorOccurred)
        {
            string conn =
                ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(
                    "SP_GetReservationInfo", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@ResID", ReservationID);

                    cnn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {

                            UserID = (int)dr["UserID"];
                            GuestID = (int)dr["CostomerID"];
                            RoomID = (int)dr["RoomID"];
                            GuestTypeID = (int)dr["GuestTypeID"];
                            NumberOfGuests = (int)dr["NumberOfGuests"];
                            ReservationDate=(DateTime)dr["ReservationDate"];
                            PlannedCheckin =
                                (DateTime)dr["PlannedCheckIn"];

                            PlannedCheckOut =
                                (DateTime)dr["PlannedCheckOut"];

                            PricePerNight =
                                (decimal)dr["PricePerNight"];

                            TotalAmount =
                                (decimal)dr["TotalAmount"];

                            Status =
                                (int)dr["Status"];

                            Notes =
                                dr["Notes"].ToString();

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

     public static bool CancelResrvation(int ReservationID,int RoomID,ref Exception ErrorOccurred)
        {
            string conn =
                ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(
                    "SP_CancelReservation", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@ReservationID", ReservationID);
                    cmd.Parameters.AddWithValue(
                        "@RoomID", RoomID);

                    cnn.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception e)
            {
                ErrorOccurred = e;
                return false;
            }
        }

        public static int? AddNewReservation(
       int UserID,
       int GuestID,
       int RoomID,
       int GuestTypeID,
       int NumberOfGuests,
       DateTime PlannedCheckIn,
       DateTime PlannedCheckOut,
       decimal PricePerNight,
       int Status,
       string Notes,
       ref Exception ErrorOccurred)
        {
            string conn =
                ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(
                    "SP_AddNewReservation", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@UserID", UserID);
                    cmd.Parameters.AddWithValue("@CostumerID", GuestID);
                    cmd.Parameters.AddWithValue("@RoomID", RoomID);
                    cmd.Parameters.AddWithValue("@GuestTypeID", GuestTypeID);
                    cmd.Parameters.AddWithValue("@NumberOfGuests", NumberOfGuests);
                    cmd.Parameters.AddWithValue("@PlanedCheckInDate", PlannedCheckIn);
                    cmd.Parameters.AddWithValue("@PlanedCheckOut", PlannedCheckOut);
                    cmd.Parameters.AddWithValue("@PricePerNight", PricePerNight);
                    cmd.Parameters.AddWithValue("@Status", Status);
                    cmd.Parameters.AddWithValue("@Notes", Notes);

                    SqlParameter NewID = cmd.Parameters.Add("@ResID", DbType.Int32);
                    NewID.Direction= ParameterDirection.Output;

                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    return Convert.ToInt32( NewID.Value);
                }
            }
            catch (Exception e)
            {
                ErrorOccurred = e;
                return null;
            }
        }

        public static bool UpdateReservation(
    int ReservationID,
    int UserID,
    int GuestID,
    int RoomID,
    int GuestTypeID,
    int NumberOfGuests,
    DateTime PlannedCheckIn,
    DateTime PlannedCheckOut,
    decimal PricePerNight,
    int Status,
    string Notes,
    ref Exception ErrorOccurred)
        {
            string conn =
                ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(
                    "SP_UpdateReservation", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ResID", ReservationID);
                    cmd.Parameters.AddWithValue("@UserID", UserID);
                    cmd.Parameters.AddWithValue("@GuestID", GuestID);
                    cmd.Parameters.AddWithValue("@RoomID", RoomID);
                    cmd.Parameters.AddWithValue("@GuestTypeID", GuestTypeID);
                    cmd.Parameters.AddWithValue("@NumberOfGuests", NumberOfGuests);
                    cmd.Parameters.AddWithValue("@CheckIn", PlannedCheckIn);
                    cmd.Parameters.AddWithValue("@CheckOut", PlannedCheckOut);
                    cmd.Parameters.AddWithValue("@PricePerNight", PricePerNight);
                    cmd.Parameters.AddWithValue("@ReservationStatus", Status);
                    cmd.Parameters.AddWithValue("@Notes", Notes);
                   SqlParameter RP= cmd.Parameters.Add("@RowsAffected", DbType.Int32);
                    RP.Direction = ParameterDirection.Output;

                    cnn.Open();
                    cmd.ExecuteNonQuery();

                    int RowsAffected =Convert.ToInt32( RP.Value);

                    return RowsAffected > 0;
                }
            }
            catch (Exception e)
            {
                ErrorOccurred = e;
                return false;
            }
        }

        public static DataTable GetReservationsList(
        ref Exception ErrorOccurred)
        {
            string conn =
                ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(
                    "SP_ReservationsList", cnn))
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

        public static bool IsRoomAvaibleForReservation(int RoomID,DateTime CheckIn,DateTime CheckOut,ref Exception e ,int? ResID=null)
        {
          string Connstring=ConfigurationManager.AppSettings["ConnectionString"];
            try
            {
                using (SqlConnection cnn = new SqlConnection(Connstring))
                using (SqlCommand cmd = new SqlCommand(
                    "SP_IsRoomAvailableForReservation", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RoomID", RoomID);
                    cmd.Parameters.AddWithValue("@CheckIn", CheckIn);
                    cmd.Parameters.AddWithValue("@CheckOut", CheckOut);
                    if (ResID.HasValue)
                        cmd.Parameters.AddWithValue("@ReservationID", ResID.Value);
                    else
                        cmd.Parameters.AddWithValue("@ReservationID", DBNull.Value);

                    cnn.Open();

                    return Convert.ToBoolean(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                e = ex;
                return false;
            }
        }
    }
}
