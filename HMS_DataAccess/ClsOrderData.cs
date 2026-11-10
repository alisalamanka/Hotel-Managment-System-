
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HMS_DataAccess
{
    public class ClsOrderData
    {
        public static int AddNewOrder(
            int OrderTypeID,
            int UserID,
            ref Exception ErrorOccurred)
        {
            string conn =
                ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(
                    "SP_AddNewOrder", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@OrderTypeID", OrderTypeID);

                    cmd.Parameters.AddWithValue(
                        "@UserID", UserID);

                    cnn.Open();

                    int OrderID = Convert.ToInt32(
                        cmd.ExecuteScalar());

                    return OrderID;
                }
            }
            catch (Exception e)
            {
                ErrorOccurred = e;
                return -1;
            }
        }


        public static bool UpdateOrder(
            int OrderID,
            int OrderTypeID,
            short status,
            int UserID,
            ref Exception ErrorOccurred)
        {
            string conn =
                ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(
                    "SP_UpdateOrder", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@OrderID", OrderID);

                    cmd.Parameters.AddWithValue(
                        "@OrderTypeID", OrderTypeID);

                    cmd.Parameters.AddWithValue(
                        "@UserID", UserID);
                    cmd.Parameters.AddWithValue("@Status", status);

                    SqlParameter RowsAffectedParam =
                        new SqlParameter(
                            "@RowsAffected", SqlDbType.Int);

                    RowsAffectedParam.Direction =
                        ParameterDirection.Output;

                    cmd.Parameters.Add(RowsAffectedParam);

                    cnn.Open();

                    cmd.ExecuteNonQuery();

                    int RowsAffected =
                        Convert.ToInt32(
                            RowsAffectedParam.Value);

                    return RowsAffected > 0;
                }
            }
            catch (Exception e)
            {
                ErrorOccurred = e;
                return false;
            }
        }


        public static bool GetOrderInfoByID(
            int OrderID,
            ref int OrderTypeID,
            ref int UserID,
            ref DateTime OrderDate,
            ref int Status,
            ref Exception ErrorOccurred)
        {
            string conn =
                ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(
                    "SP_FindOrderByID", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@OrderID", OrderID);

                    cnn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            OrderTypeID =
                                Convert.ToInt32(dr["OrderTypeID"]);

                            UserID =
                                Convert.ToInt32(dr["UserID"]);

                            OrderDate =
                                Convert.ToDateTime(dr["OrderDate"]);

                            Status =
                                Convert.ToInt32(dr["Status"]);

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


        public static DataTable GetOrdersList(
            ref Exception ErrorOccurred)
        {
            string conn =
                ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(
                    "SP_GetAllOrders", cnn))
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


        public static bool CancelOrder(
            int OrderID,
            ref Exception ErrorOccurred)
        {
            string conn =
                ConfigurationManager.AppSettings["ConnectionString"];

            try
            {
                using (SqlConnection cnn = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(
                    "SP_CancelOrder", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@OrderID", OrderID);

                    SqlParameter RowsAffectedParam =
                        new SqlParameter(
                            "@RowsAffected", SqlDbType.Int);

                    RowsAffectedParam.Direction =
                        ParameterDirection.Output;

                    cmd.Parameters.Add(RowsAffectedParam);

                    cnn.Open();

                    cmd.ExecuteNonQuery();

                    int RowsAffected =
                        Convert.ToInt32(
                            RowsAffectedParam.Value);

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
