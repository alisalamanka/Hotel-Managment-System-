using ClsGlobalClasses;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HMS_DataAccess
{
    public class ClsInvoiceData
    {
        public static bool GetInvoiceInfoByID(int InvoiceID, ref int StayID, ref int UserID,
            ref short Status, ref DateTime IssueDate, ref decimal TotalAmount, ref decimal RemainingAmount)
        {
            bool IsFound = false;
            try
            {
                string ConnString = ConfigurationManager.AppSettings["ConnectionString"];
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_GetInvoiceInfoByID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@InvoiceID", InvoiceID);
                        conn.Open();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                IsFound = true;
                                StayID = Convert.ToInt32(dr["StayID"]);
                                UserID = Convert.ToInt32(dr["CreatedByUserID"]);
                                Status = Convert.ToInt16(dr["Status"]);
                                IssueDate = Convert.ToDateTime(dr["IssueDate"]);
                                TotalAmount = Convert.ToDecimal(dr["TotalAmount"]);
                                RemainingAmount = Convert.ToDecimal(dr["RamainingAmount"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                IsFound = false;
                ClsUtil.ClsLogger.LogError($"Failed to get invoice with id = {InvoiceID}", ex);
            }

            return IsFound;
        }

        public static int AddNewInvoice(int StayID, int UserID, short Status,
            DateTime IssueDate, decimal TotalAmount, decimal RemainingAmount)
        {
            int InvoiceID = -1;
            try
            {
                string ConnString = ConfigurationManager.AppSettings["ConnectionString"];
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_AddNewInvoice", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@StayID", StayID);
                        cmd.Parameters.AddWithValue("@UserID", UserID);
                        cmd.Parameters.AddWithValue("@Status", Status);
                        cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
                        cmd.Parameters.AddWithValue("@TotalAmount", TotalAmount);
                        cmd.Parameters.AddWithValue("@RemainingAmount", RemainingAmount);

                        SqlParameter outputIdParam = new SqlParameter("@InvoiceID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(outputIdParam);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        if (outputIdParam.Value != DBNull.Value)
                        {
                            InvoiceID = Convert.ToInt32(outputIdParam.Value);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                InvoiceID = -1;
                ClsUtil.ClsLogger.LogError($"Failed to add new invoice for StayID = {StayID}", ex);
            }

            return InvoiceID;
        }

        public static bool UpdateInvoice(int InvoiceID, int StayID, int UserID, short Status,
            DateTime IssueDate, decimal TotalAmount, decimal RemainingAmount)
        {
            int rowsAffected = 0;
            try
            {
                string ConnString = ConfigurationManager.AppSettings["ConnectionString"];
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_UpdateInvoice", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@InvoiceID", InvoiceID);
                        cmd.Parameters.AddWithValue("@StayID", StayID);
                        cmd.Parameters.AddWithValue("@UserID", UserID);
                        cmd.Parameters.AddWithValue("@Status", Status);
                        cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
                        cmd.Parameters.AddWithValue("@TotalAmount", TotalAmount);
                        cmd.Parameters.AddWithValue("@RemainingAmount", RemainingAmount);

                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int count))
                        {
                            rowsAffected = count;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                rowsAffected = 0;
                ClsUtil.ClsLogger.LogError($"Failed to update invoice with id = {InvoiceID}", ex);
            }

            return (rowsAffected > 0);
        }

        public static bool DeleteInvoice(int InvoiceID)
        {
            int rowsAffected = 0;
            try
            {
                string ConnString = ConfigurationManager.AppSettings["ConnectionString"];
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_deleteinvoice", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@InvoiceID", InvoiceID);

                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int count))
                        {
                            rowsAffected = count;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                rowsAffected = 0;
                ClsUtil.ClsLogger.LogError($"Failed to delete invoice with id = {InvoiceID}", ex);
            }

            return (rowsAffected > 0);
        }

        public static bool IsInvoiceExist(int InvoiceID)
        {
            bool IsFound = false;
            try
            {
                string ConnString = ConfigurationManager.AppSettings["ConnectionString"];
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_InvoiceExistsByID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@InvoiceID", InvoiceID);

                        conn.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            IsFound = dr.HasRows;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                IsFound = false;
                ClsUtil.ClsLogger.LogError($"Failed to check if invoice exists with id = {InvoiceID}", ex);
            }

            return IsFound;
        }

        public static DataTable GetAllInvoices()
        {
            DataTable dt = new DataTable();
            try
            {
                string ConnString = ConfigurationManager.AppSettings["ConnectionString"];
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_InvoicesList", conn))
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
                ClsUtil.ClsLogger.LogError("Failed to get all invoices", ex);
            }

            return dt;
        }
    }
}