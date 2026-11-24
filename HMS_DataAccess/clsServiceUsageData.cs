using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HMS_DataAccess
{
    public class clsServiceUsageData
    {
        public static bool GetServiceUsageInfoByID(
            int ServiceUsageID,
            ref int StayID,
            ref int ServiceID,
            ref int EmployeeID,
            ref int ApplicationID,
            ref decimal Price,
            ref int CreatedByUserID,
            ref string Notes,
            ref short Status,
            ref Exception ErrorOccurred)
        {
            string conn = ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand("SP_GetServiceUsageInfoByID", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ServiceUsageID);

                    cnn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            StayID = (int)dr["StayID"];
                            ServiceID = (int)dr["ServiceID"];
                            EmployeeID = dr["EmployeeID"] != DBNull.Value ? (int)dr["EmployeeID"] : 0;
                            ApplicationID = dr["ApplicationID"] != DBNull.Value ? (int)dr["ApplicationID"] : 0;
                            Price = (decimal)dr["Price"];
                            CreatedByUserID = (int)dr["CreatedByUserID"];
                            Notes = dr["Notes"] != DBNull.Value ? dr["Notes"].ToString() : string.Empty;
                            Status = (short)dr["Status"];

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

        public static int? AddNewServiceUsage(
            int StayID,
            int ServiceID,
            int EmployeeID,
            int OrderID,
            decimal Price,
            int CreatedByUserID,
            string Notes,
            ref Exception ErrorOccurred)
        {
            string conn = ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand("SP_AddNewServiceUsage", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@StayID", StayID);
                    cmd.Parameters.AddWithValue("@ServiceID", ServiceID);
                    cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                    cmd.Parameters.AddWithValue("@OrderID", OrderID);
                    cmd.Parameters.AddWithValue("@Price", Price);
                    cmd.Parameters.AddWithValue("@UserID", CreatedByUserID);
                    cmd.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(Notes) ? (object)DBNull.Value : Notes);
                    SqlParameter NewID = cmd.Parameters.Add("@NewID", SqlDbType.Int);
                    NewID.Direction = ParameterDirection.Output;

                    cnn.Open();
                    cmd.ExecuteNonQuery();

                    return Convert.ToInt32(NewID.Value);
                }
            }
            catch (Exception e)
            {
                ErrorOccurred = e;
                return null;
            }
        }

        public static bool UpdateServiceUsage(
            int ServiceUsageID,
            int StayID,
            int ServiceID,
            int EmployeeID,
            int OrderID,
            decimal Price,
            string Notes,
            short Status,
            ref Exception ErrorOccurred)
        {
            string conn = ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand("SP_UpdateServiceUsage", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ServiceUsageID", ServiceUsageID);
                    cmd.Parameters.AddWithValue("@StayID", StayID);
                    cmd.Parameters.AddWithValue("@ServiceID", ServiceID);
                    cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                    cmd.Parameters.AddWithValue("@OrderID", OrderID);
                    cmd.Parameters.AddWithValue("@Price", Price);
                    cmd.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(Notes) ? (object)DBNull.Value : Notes);
                    cmd.Parameters.AddWithValue("@Status", Status);

                    SqlParameter UpdatedBit = cmd.Parameters.Add("@Updated", SqlDbType.Bit);
                    UpdatedBit.Direction = ParameterDirection.Output;

                    cnn.Open();
                    cmd.ExecuteNonQuery();

                    bool Updated = Convert.ToSingle(UpdatedBit.Value) == 1;
                    return Updated;
                }
            }
            catch (Exception e)
            {
                ErrorOccurred = e;
                return false;
            }
        }

        public static bool CancelServiceUsage(int ServiceUsageID, ref Exception ErrorOccurred)
        {
            string conn = ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand("SP_CancelServiceUsage", cnn))
                {
                    SqlParameter CanceledBit = new SqlParameter("@Canceled", SqlDbType.Bit);
                    CanceledBit.Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ServiceUsageID", ServiceUsageID);
                    cmd.Parameters.Add(CanceledBit);

                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    bool Canceled = Convert.ToByte(CanceledBit.Value) == 1;

                    return Canceled;
                }
            }
            catch (Exception e)
            {
                ErrorOccurred = e;
                return false;
            }
        }

        public static DataTable GetServiceUsagesList(ref Exception ErrorOccurred)
        {
            string conn = ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand("SP_GetServiceUsagesList", cnn))
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